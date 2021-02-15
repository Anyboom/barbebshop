using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using BarberShop.Dialogs;

using Dapper;

using Microsoft.VisualBasic;

namespace BarberShop
{
    public partial class MainForm : Form
    {
        private DataTable mainTable;
        private SqlConnection connString;
        public MainForm()
        {
            InitializeComponent();

            mainTable = new DataTable();
            connString = new SqlConnection(Settings.ConnectionString);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainTable.Columns.Add("Ид", typeof(int));
            mainTable.Columns.Add("Имя сотрудника", typeof(string));
            mainTable.Columns.Add("Фамилия сотрудника", typeof(string));
            mainTable.Columns.Add("Должность сотрудника", typeof(string));
            mainTable.Columns.Add("Имя клиента", typeof(string));
            mainTable.Columns.Add("Фамилия клиента", typeof(string));
            mainTable.Columns.Add("Время записи", typeof(DateTime));
            mainTable.Columns.Add("Оплачен", typeof(string));

            MainGrid.DataSource = mainTable;

            BeforeDatePicker.Value = DateTime.Now.AddDays(-1 * ((int) DateTime.Now.DayOfWeek) + 1);
            AfterDatePicker.Value = DateTime.Now.AddDays(7 - (int) DateTime.Now.DayOfWeek);

            LoadTable();
        }

        private void ShowJobsMenuItem_Click(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count == 0) return;

            int id = (int) MainGrid.SelectedRows[0].Cells[0].Value;

            PurchaseClientForm tempForm = new PurchaseClientForm(id);

            tempForm.ShowDialog();
        }

        private void LoadTable()
        {
            mainTable.Rows.Clear();

            string sqlQuery = "SELECT* FROM dbo.Reception LEFT JOIN dbo.Employee ON dbo.Reception.IdEmployee = dbo.Employee.Id LEFT JOIN dbo.Client ON dbo.Reception.IdClient = dbo.Client.Id LEFT JOIN dbo.Purchase ON dbo.Reception.IdPurchase = dbo.Purchase.Id LEFT JOIN dbo.Position ON dbo.Employee.IdPosition = dbo.Position.Id WHERE CAST(dbo.Reception.DateAt AS date) BETWEEN @beforeDate AND @afterDate AND dbo.Reception.IsCanceled = 0";

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            foreach (Reception item in connString.Query<Reception, Employee, Client, Purchase, Position, Reception>(sqlQuery, (_Reception, _Employee, _Client, _Purchase, _Position) =>
            {
                _Employee.Position = _Position;
                _Reception.Employee = _Employee;
                _Reception.Client = _Client;
                _Reception.Purchase = _Purchase;

                return _Reception;
            }, new { beforeDate = BeforeDatePicker.Value.Date, afterDate = AfterDatePicker.Value.Date }))
            {
                mainTable.Rows.Add(item.Id, item.Employee.FirstName, item.Employee.LastName, item.Employee.Position.Title, item.Client.FirstName, item.Client.LastName, item.DateAt, (item.Purchase == null) ? "Не оплачен" : "Оплачен");
            }

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }
        }

        private void WriteMenuItem_Click(object sender, EventArgs e)
        {
            ReceptionAddForm tempForm = new ReceptionAddForm();
            tempForm.ShowDialog();
        }

        private void EmployeeMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm tempForm = new EmployeeForm();
            tempForm.ShowDialog();
        }

        private void ClientMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm tempForm = new ClientForm();
            tempForm.ShowDialog();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void PayMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int) MainGrid.SelectedRows[0].Cells[0].Value;

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            string existPurchase = connString.QuerySingle<string>("SELECT idPurchase FROM dbo.Reception WHERE dbo.Reception.Id = @id", new { id });

            if (String.IsNullOrEmpty(existPurchase))
            {
                string sql = "SELECT SUM(dbo.Job.Price) FROM dbo.Job LEFT JOIN dbo.JobReception ON dbo.JobReception.IdJob = dbo.Job.Id LEFT JOIN dbo.TypeJob ON dbo.Job.IdType = dbo.TypeJob.Id WHERE dbo.JobReception.IdReception = @idReception";

                decimal total = connString.ExecuteScalar<decimal>(sql, new { idReception = id });

                DialogResult result = MessageBox.Show($"К оплате: {total} руб", "Парикмахерская", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.OK)
                {
                    connString.Execute("INSERT INTO dbo.Purchase VALUES (@total)", new { total });

                    int lastId = connString.ExecuteScalar<int>("SELECT MAX(Id) FROM dbo.Purchase");

                    connString.Execute("UPDATE dbo.Reception SET dbo.Reception.idPurchase = @lastId WHERE dbo.Reception.Id = @id", new { lastId, id });
                }
            }
            else
            {
                MessageBox.Show("За данный прием уже имеется чек.", "Парикмахерская", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }
        }

        private void Search(object sender, EventArgs e)
        {
            string columnName = sender.ToString(),
                   temp = Interaction.InputBox("Введите значение для поиска: ", "Парикмахерская");

            string query = default;

            try
            {
                switch (columnName)
                {
                    case "Ид":
                        query = $"[{columnName}] = {temp}";
                        break;
                    default:
                        query = $"[{columnName}] LIKE '%{temp}%'";
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Попробуйте ввести корректные данные !", "Парикмахерская", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            mainTable.DefaultView.RowFilter = query;
        }

        private void SearchRefreshMenuItem_Click(object sender, EventArgs e)
        {
            mainTable.DefaultView.RowFilter = string.Empty;
        }

        private void CancelMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)MainGrid.SelectedRows[0].Cells[0].Value;

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите отменить прием с ИД: {id}", "Парикмахерская", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if (connString.State == ConnectionState.Closed)
                {
                    connString.Open();
                }

                connString.Execute("UPDATE dbo.Reception SET dbo.Reception.IsCanceled = 1 WHERE dbo.Reception.id = @id", new { id });

                if (connString.State != ConnectionState.Closed)
                {
                    connString.Close();
                }

            }
        }
    } 
}
