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
using Dapper;
using System.Configuration;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        #region Fields
        private static EmployeesForm _instance = null;
        private EmployeeData employeeData = new EmployeeData();

        #endregion

        #region Properties


        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
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

        private EmployeesForm()
        {

            InitializeComponent();
            PrepareEmployeesData();
        }
        #endregion

        #region Private methods
               
        private void PrepareEmployeesData()
        {
            employeeData.LoadDataFromDatabase();
            var employeesSorted = EmployeeData.employeesList.OrderBy(x => x.Code).ToList();
            employeeModelBindingSource.DataSource = new BindingList<EmployeeModel>(employeesSorted);
            dgvEmployees.DataSource = employeeModelBindingSource;
        }
        
        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        
        #endregion

        #region Events

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();          
            frm.ShowDialog();
            PrepareEmployeesData();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if(dgvEmployees.CurrentRow == null)
            {
                return;
            }
            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value); 
         
            EmployeeEditForm frm = new EmployeeEditForm(employeeId);

            frm.ShowDialog();
            PrepareEmployeesData();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
           

            if (dgvEmployees.CurrentRow == null)
            {
                return;
            }
            DialogResult answer =
                   MessageBox.Show(
                       "Czy na pewno chcesz usunąć pracownika?",
                       "Usuwanie pracownika.",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);
            if (answer == DialogResult.No)
            {
                return;
            }

            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);
            int selectedRowIndex = dgvEmployees.CurrentRow.Index;

            
            EmployeeModel employee = EmployeeData.employeesList.Where(x => x.Id == employeeId).FirstOrDefault();
            if (employee != null)
            {
                EmployeeData.employeesList.Remove(employee); 
                employeeModelBindingSource.Remove(employee);
                if (dgvEmployees.Rows.Count > 1)
                {
                    dgvEmployees.ClearSelection();
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true; 
                }
            }

            
            DBInfo DBToDelete = new DBInfo(employee);
            using (var db = new SQLiteConnection(@"D:\C# CV\System HR\SystemHR\dataBaseHR.db"))                
            {                
                db.Delete(DBToDelete);                
                db.Close();
            };
        }
        private void btnHire_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                return;
            }
            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);


            EmployeeHireForm frm = new EmployeeHireForm(employeeId);

            frm.ShowDialog();
            PrepareEmployeesData(); 
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                return;
            }

            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);
            EmployeeModel employeeModel = EmployeeData.employeesList.Where(x => x.Id == employeeId).FirstOrDefault();
            if (employeeModel.Position == null) { return; }

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

            employeeModel.Status = new StatusModel("Zwolniony");
            employeeModel.Position.PositionName = "";

            DBInfo temp = new DBInfo(employeeModel);
            using (var db = new SQLiteConnection(employeeData.DBpath))
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
