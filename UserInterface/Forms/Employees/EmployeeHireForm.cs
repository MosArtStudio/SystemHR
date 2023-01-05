using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Data;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictonaries;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeHireForm : BaseAddEditForm
    {
        #region Fields
        private EmployeeModel employee;        
        private int editingEmployeeId;
        public string DBpath = Path.Combine(
            Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName,
            "dataBaseHR.db");
        #endregion

        #region Constructor
        public EmployeeHireForm(int employeeId)
        {
            employee = GetEmployee(employeeId);
            editingEmployeeId = employeeId;
            InitializeComponent();
            InitializeData();
            PrepareEmployeeData(employee);                               

        }
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            IList<PositionModel> positions = new List<PositionModel>()
            {
                new PositionModel("Umowa o pracę"),
                new PositionModel("Umowa zlecenie"),
                new PositionModel("Umowa o dzieło"),
                new PositionModel(string.Empty),
            };

            bsPosition.DataSource = positions;
            cbPosition.Text = string.Empty;
        }

        private void PrepareEmployeeData(EmployeeModel employee)
        {
            lblEmployee.Text = 
                $"{employee.FirstName} {employee.LastName} " +
                $"({employee.Code.ToString().PadLeft(4, '0')}) - {employee.Status}";
            if (employee.Position != null)
            {
                cbPosition.Text = employee.Position != null ? employee.Position.PositionName : null;
                dtpStartDate.SetDateTimePickerValue(employee.StartDate);
                dtpEndDate.SetDateTimePickerValue(employee.EndDate);
            }           
        }
        private EmployeeModel GetEmployee(int employeeId)
        {
            EmployeeModel employeeModel = EmployeeData.employeesList.Where(x => x.Id == employeeId).FirstOrDefault();
            return employeeModel;
        }
        #endregion

        #region Events
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DatePickerValueChanged();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Override Methods
        protected override void Save()
        {
            employee.Position = new PositionModel(Convert.ToString(cbPosition.Text));            
            employee.StartDate = dtpStartDate.Value;
            employee.EndDate = dtpEndDate.Value;
            employee.Status = new StatusModel("Zatrudniony");

            EmployeeModel toDelete = EmployeeData.employeesList.Where(x => x.Id == editingEmployeeId).FirstOrDefault();
            EmployeeData.employeesList.Remove(toDelete);
            EmployeeData.employeesList.Add(employee);

            DBInfo temp = new DBInfo(employee);
            using (var db = new SQLiteConnection(DBpath))
            {
                db.Update(temp);
                db.Close();
            };

            Close();
        }

        #endregion
    }
}
