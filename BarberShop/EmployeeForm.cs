
using BarberShop.Dialogs;

using Dapper;

using Microsoft.VisualBasic;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BarberShop
{
    public partial class EmployeeForm : Form
    {
        private DataTable mainTable;
        private SqlConnection connString;

        public EmployeeForm()
        {
            InitializeComponent();

            mainTable = new DataTable();
            connString = new SqlConnection(Settings.ConnectionString);

            if (Settings.CurrentRole != Role.Administrator)
            {
                MainMenu.Items.Remove(AddMenuItem);
                MainMenu.Items.Remove(RemoveMenuItem);
                MainMenu.Items.Remove(EditMenuItem);
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            mainTable.Columns.Add("Ид", typeof(int));
            mainTable.Columns.Add("Имя", typeof(string));
            mainTable.Columns.Add("Фамилия", typeof(string));
            mainTable.Columns.Add("Отчество", typeof(string));
            mainTable.Columns.Add("Телефон", typeof(string));
            mainTable.Columns.Add("ИдДолжности", typeof(int));
            mainTable.Columns.Add("Должность", typeof(string));
            mainTable.Columns.Add("Почта", typeof(string));

            MainGrid.DataSource = mainTable;

            MainGrid.Columns[5].Visible = false;

            string sql = "SELECT * FROM dbo.Employee LEFT JOIN dbo.Position ON dbo.Employee.IdPosition = dbo.Position.Id WHERE dbo.Employee.IsDeleted = 0";

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            foreach (Employee item in connString.Query<Employee, Position, Employee>(sql, (_Employee, _Position) =>
            {
                _Employee.Position = _Position;
                return _Employee;
            }))
            {
                mainTable.Rows.Add(item.Id, item.FirstName, item.LastName, item.MiddleName, item.Phone, item.Position.Id, item.Position.Title, item.Email);
            }

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            mainTable.PrimaryKey = new DataColumn[] { mainTable.Columns[0] };
        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAddEditForm temp = new EmployeeAddEditForm();

            DialogResult resultDialog = temp.ShowDialog();

            if (resultDialog == DialogResult.OK)
            {
                Employee item = temp.ResultModel;

                mainTable.Rows.Add(item.Id, item.FirstName, item.LastName, item.MiddleName, item.Phone, item.Position.Id, item.Position.Title, item.Email);
            }
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            Employee temp = new Employee()
            {
                Id = (int) MainGrid.SelectedRows[0].Cells[0].Value,
                FirstName = MainGrid.SelectedRows[0].Cells[1].Value.ToString(),
                LastName = MainGrid.SelectedRows[0].Cells[2].Value.ToString(),
                MiddleName = MainGrid.SelectedRows[0].Cells[3].Value.ToString(),
                Phone = MainGrid.SelectedRows[0].Cells[4].Value.ToString(),
                Position = new Position()
                {
                    Id = (int) MainGrid.SelectedRows[0].Cells[5].Value,
                    Title = MainGrid.SelectedRows[0].Cells[6].Value.ToString()
                },
                Email = MainGrid.SelectedRows[0].Cells[7].Value.ToString()
            };

            byte[] imageBytes = connString.QueryFirst<byte[]>("SELECT dbo.Employee.Avatar FROM dbo.Employee WHERE dbo.Employee.Id = @id", new { temp.Id });

            temp.Avatar = imageBytes;

            EmployeeAddEditForm tempForm = new EmployeeAddEditForm(temp);
            DialogResult resultDialog = tempForm.ShowDialog();

            if (resultDialog == DialogResult.OK)
            {
                Employee item = tempForm.ResultModel;

                mainTable.Rows.Find(item.Id).SetField(1, item.FirstName);
                mainTable.Rows.Find(item.Id).SetField(2, item.LastName);
                mainTable.Rows.Find(item.Id).SetField(3, item.MiddleName);
                mainTable.Rows.Find(item.Id).SetField(4, item.Phone);
                mainTable.Rows.Find(item.Id).SetField(5, item.Position.Id);
                mainTable.Rows.Find(item.Id).SetField(6, item.Position.Title);
                mainTable.Rows.Find(item.Id).SetField(7, item.Email);
            }
        }

        private void RemoveMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int) MainGrid.SelectedRows[0].Cells[0].Value;

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить сотрудника с ИД: {id}. Так же удалятся действующии приемы у данного сотрудника !", "Парикмахерская", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if (connString.State == ConnectionState.Closed)
                {
                    connString.Open();
                }

                connString.Execute("UPDATE dbo.Employee SET dbo.Employee.IsDeleted = 1 WHERE dbo.Employee.Id = @id", new { id });
                connString.Execute("UPDATE dbo.Reception SET dbo.Reception.IsCanceled = 1 WHERE dbo.Reception.idEmployee = @id", new { id });

                if (connString.State != ConnectionState.Closed)
                {
                    connString.Close();
                }

                mainTable.Rows.Find(id).Delete();
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

        private void ShowAvatarMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int) MainGrid.SelectedRows[0].Cells[0].Value;

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            byte[] imageBytes = connString.QueryFirst<byte[]>("SELECT dbo.Employee.Avatar FROM dbo.Employee WHERE dbo.Employee.Id = @id", new { id });

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            if (imageBytes == null)
            {
                MessageBox.Show("У данного сотрудника не установлена фотография", "Парикмахерская", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowImageForm temp = new ShowImageForm(Image.FromStream(new MemoryStream(imageBytes)));

                temp.ShowDialog();
            }
        }
    }
}
