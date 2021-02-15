using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Dapper;

namespace BarberShop.Dialogs
{
    public partial class PurchaseClientForm : Form
    {
        private int id;

        private DataTable mainTable;
        private SqlConnection connString;

        public PurchaseClientForm(int id)
        {
            InitializeComponent();

            this.id = id;

            mainTable = new DataTable();
            connString = new SqlConnection(Settings.ConnectionString);
        }

        private void JobsClientMain_Load(object sender, EventArgs e)
        {
            mainTable.Columns.Add("Название", typeof(string));
            mainTable.Columns.Add("Цена", typeof(decimal));
            mainTable.Columns.Add("Тип", typeof(string));

            MainGrid.DataSource = mainTable;

            string sql = "SELECT dbo.Job.Title, dbo.Job.Price, dbo.TypeJob.Id, dbo.TypeJob.Title FROM dbo.Job LEFT JOIN dbo.JobReception ON dbo.JobReception.IdJob = dbo.Job.Id LEFT JOIN dbo.TypeJob ON dbo.Job.IdType = dbo.TypeJob.Id WHERE dbo.JobReception.IdReception = @idOfReception";

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            decimal total = 0;

            foreach (Job item in connString.Query<Job, TypeJob, Job>(sql, (_Job, _TypeJob) =>
            {
                _Job.Type = _TypeJob;
                return _Job;
            }, new { idOfReception = id }))
            {
                total += item.Price;

                mainTable.Rows.Add(item.Title, item.Price, item.Type.Title);       
            }

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            ResultCountLabel.Text = mainTable.Rows.Count.ToString();

            ResultSumLabel.Text = total.ToString();
        }
    }
}
