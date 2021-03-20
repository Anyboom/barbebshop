using Dapper;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShop.Dialogs
{
    public partial class EmployeeAddEditForm : Form
    {
        private SqlConnection connString;
        internal Employee ResultModel;

        internal EmployeeAddEditForm(Employee model = null)
        {
            InitializeComponent();

            connString = new SqlConnection(Settings.ConnectionString);

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            PositionComboBox.DataSource = connString.Query<Position>("SELECT * FROM dbo.Position");
            PositionComboBox.DisplayMember = "Title";
            PositionComboBox.ValueMember = "Id";

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            if (model != null)
            {
                FirstNameTextBox.Text = model.FirstName;
                LastNameTextBox.Text = model.LastName;
                MiddleNameTextBox.Text = model.MiddleName;
                PhoneTextBox.Text = model.Phone;
                MailTextBox.Text = model.Email;

                if (model.Avatar != null)
                {
                    AvatarPicture.Image = Image.FromStream(new MemoryStream(model.Avatar));
                }

                PositionComboBox.SelectedValue = model.Position.Id;

                this.ResultModel = model;

                MainGroup.Text = $"Редактирования сотрудника с номером {model.Id}";

                ActionButton.Text = "Обновить";

                PasswordLabel.Visible = false;
                PasswordTextBox.Visible = false;

                ActionButton.Location = new Point(ActionButton.Location.X, 422);
                this.Height = 523;
                MainGroup.Height = 461;
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            byte[] uploadImage = null;

            if (AvatarPicture.Image != null)
            {
                MemoryStream memStream = new MemoryStream();
                AvatarPicture.Image.Save(memStream, AvatarPicture.Image.RawFormat);
                uploadImage = memStream.ToArray();
            }

            string salt = RandomService.RandomString(6);

            Employee temp = new Employee()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Avatar = uploadImage,
                Position = PositionComboBox.SelectedItem as Position,
                Email = MailTextBox.Text
            };

            if (ResultModel == null)
            {
                temp.PasswordSalt = salt;
                temp.Password = CryptoService.CreateMD5($"{PasswordTextBox.Text}|{salt}");
            }

            string query = "INSERT INTO dbo.Employee VALUES (@FirstName, @LastName, @MiddleName, @Phone, @PositionId, @Avatar, 0, @Email, @Password, @PasswordSalt)";

            if (ResultModel != null)
            {
                temp.Id = ResultModel.Id;

                query = "UPDATE dbo.Employee SET dbo.Employee.FirstName = @FirstName, dbo.Employee.LastName = @LastName, dbo.Employee.MiddleName = @MiddleName, dbo.Employee.Phone = @Phone, dbo.Employee.idPosition = @PositionId, dbo.Employee.Avatar = @Avatar, dbo.Employee.Email = @Email WHERE dbo.Employee.Id = @Id";
            }

            try
            {
                connString.Execute(query, new { PositionId = temp.Position.Id, temp.Email, temp.FirstName, temp.LastName, temp.MiddleName, temp.Phone, temp.Avatar, temp.Id, temp.Password, temp.PasswordSalt });

                if (ResultModel == null)
                {
                    temp.Id = connString.ExecuteScalar<int>("SELECT MAX(Id) FROM dbo.Employee");
                }

                DialogResult = DialogResult.OK;

                ResultModel = temp;

                this.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Такой email уже имеется в базе данных", "Парикмахерская", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connString.State != ConnectionState.Closed)
                {
                    connString.Close();
                }
            }
        }

        private void AvatarPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                CheckFileExists = true,
                Multiselect = false,
                Title = "Выберите изображение",
                Filter = "IMAGE FILES (*.PNG;*.JPG;*.JPEG)|*.PNG;*.JPG;*.JPEG"
            };

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                AvatarPicture.Image = Image.FromFile(openFile.FileName);
            }
        }
        private void DeleteImageButton_Click(object sender, EventArgs e)
        {
            AvatarPicture.Image = null;
        }
    }
}
