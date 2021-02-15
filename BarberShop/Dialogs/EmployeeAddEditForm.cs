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

                if (model.Avatar != null)
                {
                    AvatarPicture.Image = Image.FromStream(new MemoryStream(model.Avatar));
                }

                PositionComboBox.SelectedValue = model.Position.Id;

                this.ResultModel = model;

                MainGroup.Text = $"Редактирования сотрудника с номером {model.Id}";

                ActionButton.Text = "Обновить";
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

            Employee temp = new Employee()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Avatar = uploadImage
            };

            string query = "INSERT INTO dbo.Employee VALUES (@firstName, @lastName, @middleName, @phone, @idPosition, @image)";

            if (ResultModel != null)
            {
                temp.Id = ResultModel.Id;

                query = "UPDATE dbo.Employee SET dbo.Employee.FirstName = @firstName, dbo.Employee.LastName = @lastName, dbo.Employee.MiddleName = @middleName, dbo.Employee.Phone = @phone, dbo.Employee.idPosition = @idPosition, dbo.Employee.Avatar = @image WHERE dbo.Employee.Id = @id";
            }

            connString.Execute(query, temp);

            if (ResultModel == null)
            {
                temp.Id = connString.ExecuteScalar<int>("SELECT MAX(Id) FROM dbo.Client");
            }

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            DialogResult = DialogResult.OK;

            ResultModel = temp;

            this.Close();
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
