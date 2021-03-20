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
    public partial class ClientForm : Form
    {
        private DataTable mainTable;
        private SqlConnection connString;

        public ClientForm()
        {
            InitializeComponent();

            mainTable = new DataTable();
            connString = new SqlConnection(Settings.ConnectionString);

            if(Settings.CurrentRole != Role.Administrator)
            {
                MainMenu.Items.Remove(AddMenuItem);
                MainMenu.Items.Remove(RemoveMenuItem);
                MainMenu.Items.Remove(EditMenuItem);
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            mainTable.Columns.Add("Ид", typeof(int));
            mainTable.Columns.Add("Имя", typeof(string));
            mainTable.Columns.Add("Фамилия", typeof(string));
            mainTable.Columns.Add("Отчество", typeof(string));
            mainTable.Columns.Add("Телефон", typeof(string));

            MainGrid.DataSource = mainTable;

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            foreach (Client item in connString.Query<Client>("SELECT * FROM dbo.Client WHERE dbo.Client.IsDeleted = 0"))
            {
                mainTable.Rows.Add(item.Id, item.FirstName, item.LastName, item.MiddleName, item.Phone);
            }

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            mainTable.PrimaryKey = new DataColumn[] { mainTable.Columns[0] };
        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            ClientAddEditForm tempForm = new ClientAddEditForm();

            DialogResult resultDialog = tempForm.ShowDialog();

            if(resultDialog == DialogResult.OK)
            {
                Client item = tempForm.ResultModel;

                mainTable.Rows.Add(item.Id, item.FirstName, item.LastName, item.MiddleName, item.Phone);
            }
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            Client temp = new Client()
            {
                Id = (int) MainGrid.SelectedRows[0].Cells[0].Value,
                FirstName = MainGrid.SelectedRows[0].Cells[1].Value.ToString(),
                LastName = MainGrid.SelectedRows[0].Cells[2].Value.ToString(),
                MiddleName = MainGrid.SelectedRows[0].Cells[3].Value.ToString(),
                Phone = MainGrid.SelectedRows[0].Cells[4].Value.ToString()
            };

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            byte[] imageBytes =  connString.QueryFirst<byte[]>("SELECT dbo.Client.Avatar FROM dbo.Client WHERE dbo.Client.Id = @id", new { temp.Id });

            temp.Avatar = imageBytes;

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            ClientAddEditForm tempForm = new ClientAddEditForm(temp);
            DialogResult resultDialog = tempForm.ShowDialog();

            if (resultDialog == DialogResult.OK)
            {
                Client item = tempForm.ResultModel;

                mainTable.Rows.Find(item.Id).SetField(1, item.FirstName);
                mainTable.Rows.Find(item.Id).SetField(2, item.LastName);
                mainTable.Rows.Find(item.Id).SetField(3, item.MiddleName);
                mainTable.Rows.Find(item.Id).SetField(4, item.Phone);
            }
        }

        private void RemoveMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int) MainGrid.SelectedRows[0].Cells[0].Value;

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить клиента с ИД: {id}. Так же удалятся действующии приемы у данного клиента !", "Парикмахерская", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        
            if(result == DialogResult.Yes)
            {
                if (connString.State == ConnectionState.Closed)
                {
                    connString.Open();
                }

                connString.Execute("UPDATE dbo.Client SET dbo.Client.IsDeleted = 1 WHERE dbo.Client.Id = @id", new { id });

                connString.Execute("UPDATE dbo.Reception SET dbo.Reception.IsCanceled = 1 WHERE dbo.Reception.idClient = @id", new { id });

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
            int id = (int)MainGrid.SelectedRows[0].Cells[0].Value;

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            byte[] imageBytes = connString.QueryFirst<byte[]>("SELECT dbo.Client.Avatar FROM dbo.Client WHERE dbo.Client.Id = @id", new { id });

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            if(imageBytes == null)
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
