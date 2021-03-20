using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


using Dapper;

namespace BarberShop
{
    public partial class ReceptionAddForm : Form
    {
        private DataTable mainTable;
        private SqlConnection connString;

        List<Client> clientList;
        List<Employee> employeeList;

        public ReceptionAddForm()
        {
            InitializeComponent();

            mainTable = new DataTable();
            connString = new SqlConnection(Settings.ConnectionString);

            clientList = new List<Client>();
            employeeList = new List<Employee>();

            MainDatePicker.Value = DateTime.Now;
        }

        private void ReceptionAddForm_Load(object sender, EventArgs e)
        {
            mainTable.Columns.Add("Ид", typeof(int));
            mainTable.Columns.Add("Название", typeof(string));
            mainTable.Columns.Add("Цена", typeof(decimal));
            mainTable.Columns.Add("Тип", typeof(string));

            MainGrid.DataSource = mainTable;
            MainGrid.Columns[0].Visible = false;

            if (connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            foreach (Job item in connString.Query<Job, TypeJob, Job>("SELECT dbo.Job.Id, dbo.Job.Title, dbo.Job.Price, dbo.TypeJob.Id, dbo.TypeJob.Title FROM dbo.Job LEFT JOIN dbo.TypeJob ON dbo.Job.IdType = dbo.TypeJob.Id", (_Job, _TypeJob) =>
            {
                _Job.Type = _TypeJob;
                return _Job;
            }))
            {
                mainTable.Rows.Add(item.Id, item.Title, item.Price, item.Type.Title);
            }

            foreach (Client item in connString.Query<Client>("SELECT * FROM dbo.Client"))
            {
                clientList.Add(item);
            }

            foreach (Employee item in connString.Query<Employee, Position, Employee>("SELECT* FROM dbo.Employee LEFT JOIN dbo.Position ON dbo.Employee.IdPosition = dbo.Position.Id", (_Employee, _Position) =>
            {
                _Employee.Position = _Position;
                return _Employee;
            }))
            {
                employeeList.Add(item);
            }

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            ClientComboBox.DataSource = clientList;
            ClientComboBox.ValueMember = "Id";
            ClientComboBox.DisplayMember = string.Empty;

            EmployeeComboBox.DataSource = employeeList;
            EmployeeComboBox.ValueMember = "Id";
            EmployeeComboBox.DisplayMember = string.Empty;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(connString.State == ConnectionState.Closed)
            {
                connString.Open();
            }

            SqlTransaction sqlTrans = connString.BeginTransaction();

            DateTime tempDateTime = new DateTime(MainDatePicker.Value.Year, MainDatePicker.Value.Month, MainDatePicker.Value.Day, MainTimePicker.Value.Hour, MainTimePicker.Value.Minute, 0);

            try
            {
                connString.Execute("INSERT INTO dbo.Reception VALUES (@idEmployee, @idClient, NULL, @dateAt, 0)", new { idEmployee = EmployeeComboBox.SelectedValue, idClient = ClientComboBox.SelectedValue, dateAt = tempDateTime.ToString() }, sqlTrans);

                int lastId = connString.ExecuteScalar<int>("SELECT MAX(Id) FROM dbo.Reception", transaction: sqlTrans);

                for (int i = 0; i < MainGrid.SelectedRows.Count; i++)
                {
                    connString.Execute("INSERT INTO dbo.JobReception VALUES (@idJob, @idReception)", new { idJob = MainGrid.SelectedRows[i].Cells[0].Value, idReception = lastId }, sqlTrans);
                }

                sqlTrans.Commit();
            }
            catch (Exception)
            {
                sqlTrans.Rollback();
            }

            if (connString.State != ConnectionState.Closed)
            {
                connString.Close();
            }

            this.Close();
        }

    }
}
