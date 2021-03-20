using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using Dapper;


namespace BarberShop
{
    public partial class AuthForm : Form
    {
        private SqlConnection connString;

        public AuthForm()
        {
            InitializeComponent();
            connString = new SqlConnection(Settings.ConnectionString);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text,
                   password = PasswordTextBox.Text;

            try
            {
                if (string.IsNullOrEmpty(login))
                {
                    throw new ValidationException("Поле 'Логин' нужно заполнить.");
                }

                if (string.IsNullOrEmpty(password))
                {
                    throw new ValidationException("Поле 'Пароль' нужно заполнить.");
                }

                if (connString.State != ConnectionState.Open)
                {
                    connString.Open();
                }

                string sql = "SELECT * FROM dbo.Employee WHERE dbo.Employee.IsDeleted = 0 AND dbo.Employee.Email = @login";

                Employee temp = connString.QueryFirstOrDefault<Employee>(sql, new { login });

                if (temp == null)
                {
                    throw new ValidationException("Пользователя с таким логином нет.");
                }

                password = CryptoService.CreateMD5($"{password}|{temp.PasswordSalt}");

                if (password != temp.Password)
                {
                    throw new ValidationException("Попробуйте другой пароль или логин.");
                }

                ApplicationContext app = AppContext.Instance;

                Role CurrentRole = Role.Worker;

                if(connString.ExecuteScalar<int>("SELECT dbo.Employee.IdPosition FROM dbo.Employee WHERE dbo.Employee.Id = @id ", new { temp.Id }) == 2)
                {
                    CurrentRole = Role.Administrator;
                }

                if (connString.State != ConnectionState.Closed)
                {
                    connString.Close();
                }

                Settings.CurrentRole = CurrentRole;

                app.MainForm = new MainForm();

                app.MainForm.Show();

                Close();
            }
            catch (ValidationException error)
            {
                MessageBox.Show(error.Message, "Парикмахерская", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = (true ^ PasswordTextBox.UseSystemPasswordChar);
        }
    }
}
