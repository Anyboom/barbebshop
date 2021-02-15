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

using Dapper;

namespace BarberShop
{
    public partial class ClientAddEditForm : Form
    {
        private SqlConnection connString;
        internal Client ResultModel;

        internal ClientAddEditForm(Client model = null)
        {
            InitializeComponent();

            connString = new SqlConnection(Settings.ConnectionString);

            if (model != null)
            {
                FirstNameTextBox.Text = model.FirstName;
                LastNameTextBox.Text = model.LastName;
                MiddleNameTextBox.Text = model.MiddleName;
                PhoneTextBox.Text = model.Phone;

                if(model.Avatar != null)
                {
                    AvatarPicture.Image = Image.FromStream(new MemoryStream(model.Avatar));
                }

                this.ResultModel = model;

                MainGroup.Text = $"Редактирования клиента с номером {model.Id}";

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

            Client temp = new Client()
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Avatar = uploadImage
            };

            string query = "INSERT INTO dbo.Client VALUES (@firstName, @lastName, @middleName, @phone, @avatar, 0)";

            if (ResultModel != null)
            {
                temp.Id = ResultModel.Id;

                query = "UPDATE dbo.Client SET dbo.Client.FirstName = @firstName, dbo.Client.LastName = @lastName, dbo.Client.MiddleName = @middleName, dbo.Client.Phone = @phone, dbo.Client.Avatar = @avatar WHERE dbo.Client.Id = @id";
            }

            connString.Execute(query, temp);

            if(ResultModel == null)
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
