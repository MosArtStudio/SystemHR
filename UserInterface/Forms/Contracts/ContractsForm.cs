using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Data;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictonaries;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Forms.Helpers;


namespace SystemHR.UserInterface.Forms.Contracts
{
    public partial class ContractsForm : Form
    {
        #region Fields
        private static ContractsForm _instance = null;
        private EmployeeData employeeData = new EmployeeData();
        #endregion

        #region Instance
        public static ContractsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContractsForm();
                }
                return _instance;
            }
        }
        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }
        #endregion

        #region Constructor
        public ContractsForm()
        {
            InitializeComponent();
            PrepareEmployeesData();
        }
        #endregion

        #region Private Methods
        private void PrepareEmployeesData()
        {
            employeeData.LoadDataFromDatabase();
            var employeesSorted = EmployeeData.employeesList.Where(x => x.Status.Value == "ZATRUDNIONY").ToList();
            employeeModelBindingSource.DataSource = new BindingList<EmployeeModel>(employeesSorted);
            dgvEmployees.DataSource = employeeModelBindingSource;
        }
        private void ContractsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion

        #region Events
        private void btnDismiss_Click(object sender, EventArgs e)
        {           

            if (dgvEmployees.CurrentRow == null)
            {
                return;
            }

            DialogResult answer =
                MessageBox.Show(
                    "Czy na pewno chcesz zwolnić pracownika?",
                    "Zwalnianie pracownika.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            if (answer == DialogResult.No)
            {
                return;
            }

            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId2"].Value);
            EmployeeModel employeeModel = EmployeeData.employeesList.Where(x => x.Id == employeeId).FirstOrDefault();
            employeeModel.Status = new StatusModel("Zwolniony");
            employeeModel.Position.PositionName = "";

            DBInfo temp = new DBInfo(employeeModel);
            using (var db = new SQLiteConnection(@"D:\C# CV\System HR\SystemHR\dataBaseHR.db"))
            {
                db.Update(temp);
                db.Close();
            };
            PrepareEmployeesData();
            return;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PrepareEmployeesData();
            DialogResult answer =
                MessageBox.Show(
                    "Odświerzono listę pracowników",
                    "Odświerzanie.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            return;
        }
        #endregion
    }
}
