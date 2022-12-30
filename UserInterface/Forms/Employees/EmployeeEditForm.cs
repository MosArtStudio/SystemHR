using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Data;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictonaries;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Forms.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeEditForm : BaseAddEditForm
    {
        #region Fields 

        private EmployeeModel employee;
        public EventHandler ReloadEmployees;
        private int editingEmployeeId;

        #endregion

        #region Constuctor
        public EmployeeEditForm(int employeeId)
        {
            editingEmployeeId = employeeId;
            InitializeComponent();
            InitializeData();
            employee = GetEmployee(employeeId);
            PrepareEmployeeData(employee);
            ValidateControls();
        }

        private void PrepareEmployeeData(EmployeeModel employee)
        {
            txtLastName.Text = employee.LastName;
            txtFirstName.Text = employee.FirstName;
            cbGender.Text = employee.Gender != null ? employee.Gender.Value : null;
            dtpDateBirth.SetDateTimePickerValue(employee.DateBirth);
            txtPESEL.Text = employee.PESEL;
            txtPhoneNumber.Text = employee.PhoneNumber;
            txtEmail.Text = employee.EmailAdress;
            txtIdentityCardNumber.Text = employee.IdentityCardNumber;
            dtpIssueDateIdentityCard.SetDateTimePickerValue(employee.IssueDateIdentityCard);
            dtpExpirationDateIdentityCard.SetDateTimePickerValue(employee.ExpirationDateIdentityCard);
            txtPassportNumber.Text = employee.PassportNumber;
            dtpIssueDatePassport.SetDateTimePickerValue(employee.IssueDateIdentityPassport);
            dtpExpirationDatePassport.SetDateTimePickerValue(employee.ExpirationDateIdentityPassport);

            lblEmployee.Text = $"{employee.FirstName} {employee.LastName} ({employee.Code.ToString().PadLeft(4, '0')}) - {employee.Status}";
        }


        #endregion

        #region Private Methods
        private void ValidateControls()
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                epLastName.SetError(txtLastName, "Pole Nazwisko jest wymagane.");
            }
            else
            {
                epLastName.Clear();
            }
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                epFirstName.SetError(txtFirstName, "Pole Imię jest wymagane.");
            }
            else
            {
                epFirstName.Clear();
            }
            if (!string.IsNullOrEmpty(txtPESEL.Text) && !ValidatorsHelper.IsValidPESEL(txtPESEL.Text))
            {
                epPESEL.SetError(txtPESEL, "Numer PESEL jest nieprawidłowy.");
            }
            else
            {
                epPESEL.Clear();
            }
        }

        private void InitializeData()
        {
            IList<GenderModel> genders = new List<GenderModel>()
            {
                new GenderModel("kobieta"),
                new GenderModel("mężczyzna"),
                new GenderModel(string.Empty)
            };
            bsGender.DataSource = genders;
            cbGender.Text = string.Empty;
        }



        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMesssage = epLastName.GetError(txtLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMesssage))
            {
                sbErrorMessage.Append(lastNameErrorMesssage);
            }


            string firstNameErrorMesssage = epFirstName.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMesssage))
            {
                sbErrorMessage.Append(firstNameErrorMesssage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Dodawanie pracowanika",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            string peselWarningMessage = epPESEL.GetError(txtPESEL);
            if (!string.IsNullOrEmpty(peselWarningMessage))
            {
                DialogResult answer =
                    MessageBox.Show(
                        peselWarningMessage + Environment.NewLine + "Czy mimo to chcesz zmienić dane pracownika?",
                        "Edycja pracownika.",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }
        private EmployeeModel GetEmployee(int employeeId)
        {          

            EmployeeModel employeeModel = EmployeeData.employeesList.Where(x => x.Id == employeeId).FirstOrDefault();
            return employeeModel;
            
        }
        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DatePickerValueChanged();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPESEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPESEL_Validated(object sender, EventArgs e)
        {
            string pesel = txtPESEL.Text;
            if (!string.IsNullOrEmpty(pesel) && !ValidatorsHelper.IsValidPESEL(pesel))
            {
                epPESEL.SetError(txtPESEL, "Numer PESEL jest nieprawidłowy.");
            }
            else
            {
                epPESEL.Clear();
            }
        }
        #endregion

        #region Override
        protected override void Save()
        {
            if (ValidateForm())
            {
                employee.LastName = txtLastName.Text;
                employee.FirstName = txtFirstName.Text;
                employee.Gender = new GenderModel(cbGender.Text);
                employee.DateBirth = dtpDateBirth.Value;
                employee.PESEL = txtPESEL.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.EmailAdress = txtEmail.Text;
                employee.IdentityCardNumber = txtIdentityCardNumber.Text;
                employee.IssueDateIdentityCard = dtpIssueDateIdentityCard.Value;
                employee.ExpirationDateIdentityCard = dtpExpirationDateIdentityCard.Value;
                employee.PassportNumber = txtPassportNumber.Text;
                employee.IssueDateIdentityPassport = dtpIssueDatePassport.Value;
                employee.ExpirationDateIdentityPassport = dtpExpirationDatePassport.Value;

                
                DBInfo temp = new DBInfo(employee);                
                using (var db = new SQLiteConnection(@"D:\C# CV\System HR\SystemHR\dataBaseHR.db"))
                {
                    db.Update(temp);                    
                    db.Close();
                };                           

                Close();
            }
        }

        protected override void Cancel()
        {
            Close();
        }

        #endregion
                
    }
}
