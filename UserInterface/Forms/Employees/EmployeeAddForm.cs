using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictonaries;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Forms.Helpers;
using SystemHR.DataAccessLayer.Data;
using SQLite;
using System.IO;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditForm
    {
        #region Fields 
        public string DBpath = Path.Combine(
            Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName,
            "dataBaseHR.db");
        #endregion

        #region Constuctor
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
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
                        peselWarningMessage + Environment.NewLine + "Czy mimo to chcesz dodać pracownika?",
                        "Dodawanie pracownika.",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
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
                EmployeeModel employee = new EmployeeModel()
                {

                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Gender = new GenderModel(cbGender.Text),
                    DateBirth = dtpDateBirth.Value,
                    PESEL = txtPESEL.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    EmailAdress = txtEmail.Text,
                    IdentityCardNumber = txtIdentityCardNumber.Text,
                    IssueDateIdentityCard = dtpIssueDateIdentityCard.Value,
                    ExpirationDateIdentityCard = dtpExpirationDateIdentityCard.Value,
                    PassportNumber = txtPassportNumber.Text,
                    IssueDateIdentityPassport = dtpIssueDatePassport.Value,
                    ExpirationDateIdentityPassport = dtpExpirationDatePassport.Value,
                    Status = new StatusModel("Wprowadzony"),
                    Position = null,
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today,


                };
            
                
                if (EmployeeData.employeesList.Any()) 
                {
                    int Id = EmployeeData.employeesList.Max(x => x.Id);
                    employee.Id = Id + 1;
                    employee.Code = Id + 1;
                }
                else
                {
                    employee.Code = 1;
                    employee.Id = 1;
                }
                EmployeeData.employeesList.Add(employee);

                DBInfo temp = new DBInfo(employee);
                var db = new SQLiteConnection(DBpath);
                db.Insert(temp);
                db.Close();

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
