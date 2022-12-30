namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeEditForm));
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.bsGender = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPESEL = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpIdentificationData = new System.Windows.Forms.TabPage();
            this.gpPassport = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDatePassport = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDatePassport = new System.Windows.Forms.Label();
            this.dtpIssueDatePassport = new System.Windows.Forms.DateTimePicker();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.lblIssueDatePassport = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.gpIdentityCard = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDateIdentityCard = new System.Windows.Forms.Label();
            this.dtpIssueDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.txtIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.lblUssueDateIdentityCard = new System.Windows.Forms.Label();
            this.lblIdentityCardNumber = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.txtPESEL = new System.Windows.Forms.TextBox();
            this.lblPESEL = new System.Windows.Forms.Label();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tpEmployementHistory = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPESEL)).BeginInit();
            this.tpIdentificationData.SuspendLayout();
            this.gpPassport.SuspendLayout();
            this.gpIdentityCard.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.tpEmployementHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(772, 12);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 4;
            this.pbEmployee.TabStop = false;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(20, 44);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(310, 37);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Dane Identyfikacyjne";
            // 
            // bsGender
            // 
            this.bsGender.DataSource = typeof(SystemHR.DataAccessLayer.Models.Dictonaries.GenderModel);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(725, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(127, 49);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Image = global::SystemHR.UserInterface.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(587, 532);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(127, 49);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epLastName
            // 
            this.epLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLastName.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFirstName.ContainerControl = this;
            // 
            // epPESEL
            // 
            this.epPESEL.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPESEL.ContainerControl = this;
            this.epPESEL.Icon = ((System.Drawing.Icon)(resources.GetObject("epPESEL.Icon")));
            // 
            // tpIdentificationData
            // 
            this.tpIdentificationData.Controls.Add(this.gpPassport);
            this.tpIdentificationData.Controls.Add(this.gpIdentityCard);
            this.tpIdentificationData.Controls.Add(this.gbContact);
            this.tpIdentificationData.Controls.Add(this.gbGeneral);
            this.tpIdentificationData.Location = new System.Drawing.Point(4, 29);
            this.tpIdentificationData.Name = "tpIdentificationData";
            this.tpIdentificationData.Padding = new System.Windows.Forms.Padding(3);
            this.tpIdentificationData.Size = new System.Drawing.Size(817, 390);
            this.tpIdentificationData.TabIndex = 0;
            this.tpIdentificationData.Text = "Dane Identyfikacyjne";
            this.tpIdentificationData.UseVisualStyleBackColor = true;
            // 
            // gpPassport
            // 
            this.gpPassport.Controls.Add(this.dtpExpirationDatePassport);
            this.gpPassport.Controls.Add(this.lblExpirationDatePassport);
            this.gpPassport.Controls.Add(this.dtpIssueDatePassport);
            this.gpPassport.Controls.Add(this.txtPassportNumber);
            this.gpPassport.Controls.Add(this.lblIssueDatePassport);
            this.gpPassport.Controls.Add(this.lblPassportNumber);
            this.gpPassport.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpPassport.Location = new System.Drawing.Point(432, 221);
            this.gpPassport.Name = "gpPassport";
            this.gpPassport.Size = new System.Drawing.Size(373, 158);
            this.gpPassport.TabIndex = 17;
            this.gpPassport.TabStop = false;
            this.gpPassport.Text = "Paszport";
            // 
            // dtpExpirationDatePassport
            // 
            this.dtpExpirationDatePassport.CustomFormat = " ";
            this.dtpExpirationDatePassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDatePassport.Location = new System.Drawing.Point(187, 113);
            this.dtpExpirationDatePassport.Name = "dtpExpirationDatePassport";
            this.dtpExpirationDatePassport.Size = new System.Drawing.Size(165, 30);
            this.dtpExpirationDatePassport.TabIndex = 12;
            this.dtpExpirationDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationDatePassport
            // 
            this.lblExpirationDatePassport.AutoSize = true;
            this.lblExpirationDatePassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDatePassport.Location = new System.Drawing.Point(13, 113);
            this.lblExpirationDatePassport.Name = "lblExpirationDatePassport";
            this.lblExpirationDatePassport.Size = new System.Drawing.Size(113, 20);
            this.lblExpirationDatePassport.TabIndex = 11;
            this.lblExpirationDatePassport.Text = "Data ważności";
            // 
            // dtpIssueDatePassport
            // 
            this.dtpIssueDatePassport.CustomFormat = " ";
            this.dtpIssueDatePassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDatePassport.Location = new System.Drawing.Point(187, 72);
            this.dtpIssueDatePassport.Name = "dtpIssueDatePassport";
            this.dtpIssueDatePassport.Size = new System.Drawing.Size(165, 30);
            this.dtpIssueDatePassport.TabIndex = 10;
            this.dtpIssueDatePassport.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassportNumber.Location = new System.Drawing.Point(187, 32);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(165, 30);
            this.txtPassportNumber.TabIndex = 4;
            // 
            // lblIssueDatePassport
            // 
            this.lblIssueDatePassport.AutoSize = true;
            this.lblIssueDatePassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDatePassport.Location = new System.Drawing.Point(13, 75);
            this.lblIssueDatePassport.Name = "lblIssueDatePassport";
            this.lblIssueDatePassport.Size = new System.Drawing.Size(105, 20);
            this.lblIssueDatePassport.TabIndex = 3;
            this.lblIssueDatePassport.Text = "Data wydania";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportNumber.Location = new System.Drawing.Point(13, 37);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(131, 20);
            this.lblPassportNumber.TabIndex = 2;
            this.lblPassportNumber.Text = "Numer paszportu";
            // 
            // gpIdentityCard
            // 
            this.gpIdentityCard.Controls.Add(this.dtpExpirationDateIdentityCard);
            this.gpIdentityCard.Controls.Add(this.lblExpirationDateIdentityCard);
            this.gpIdentityCard.Controls.Add(this.dtpIssueDateIdentityCard);
            this.gpIdentityCard.Controls.Add(this.txtIdentityCardNumber);
            this.gpIdentityCard.Controls.Add(this.lblUssueDateIdentityCard);
            this.gpIdentityCard.Controls.Add(this.lblIdentityCardNumber);
            this.gpIdentityCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpIdentityCard.Location = new System.Drawing.Point(432, 11);
            this.gpIdentityCard.Name = "gpIdentityCard";
            this.gpIdentityCard.Size = new System.Drawing.Size(373, 158);
            this.gpIdentityCard.TabIndex = 16;
            this.gpIdentityCard.TabStop = false;
            this.gpIdentityCard.Text = "Dowód osobisty";
            // 
            // dtpExpirationDateIdentityCard
            // 
            this.dtpExpirationDateIdentityCard.CustomFormat = " ";
            this.dtpExpirationDateIdentityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDateIdentityCard.Location = new System.Drawing.Point(187, 113);
            this.dtpExpirationDateIdentityCard.Name = "dtpExpirationDateIdentityCard";
            this.dtpExpirationDateIdentityCard.Size = new System.Drawing.Size(165, 30);
            this.dtpExpirationDateIdentityCard.TabIndex = 12;
            this.dtpExpirationDateIdentityCard.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationDateIdentityCard
            // 
            this.lblExpirationDateIdentityCard.AutoSize = true;
            this.lblExpirationDateIdentityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDateIdentityCard.Location = new System.Drawing.Point(13, 113);
            this.lblExpirationDateIdentityCard.Name = "lblExpirationDateIdentityCard";
            this.lblExpirationDateIdentityCard.Size = new System.Drawing.Size(113, 20);
            this.lblExpirationDateIdentityCard.TabIndex = 11;
            this.lblExpirationDateIdentityCard.Text = "Data ważności";
            // 
            // dtpIssueDateIdentityCard
            // 
            this.dtpIssueDateIdentityCard.CustomFormat = " ";
            this.dtpIssueDateIdentityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDateIdentityCard.Location = new System.Drawing.Point(187, 72);
            this.dtpIssueDateIdentityCard.Name = "dtpIssueDateIdentityCard";
            this.dtpIssueDateIdentityCard.Size = new System.Drawing.Size(165, 30);
            this.dtpIssueDateIdentityCard.TabIndex = 10;
            this.dtpIssueDateIdentityCard.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtIdentityCardNumber
            // 
            this.txtIdentityCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityCardNumber.Location = new System.Drawing.Point(187, 32);
            this.txtIdentityCardNumber.Name = "txtIdentityCardNumber";
            this.txtIdentityCardNumber.Size = new System.Drawing.Size(165, 30);
            this.txtIdentityCardNumber.TabIndex = 4;
            // 
            // lblUssueDateIdentityCard
            // 
            this.lblUssueDateIdentityCard.AutoSize = true;
            this.lblUssueDateIdentityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUssueDateIdentityCard.Location = new System.Drawing.Point(13, 75);
            this.lblUssueDateIdentityCard.Name = "lblUssueDateIdentityCard";
            this.lblUssueDateIdentityCard.Size = new System.Drawing.Size(105, 20);
            this.lblUssueDateIdentityCard.TabIndex = 3;
            this.lblUssueDateIdentityCard.Text = "Data wydania";
            // 
            // lblIdentityCardNumber
            // 
            this.lblIdentityCardNumber.AutoSize = true;
            this.lblIdentityCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityCardNumber.Location = new System.Drawing.Point(13, 37);
            this.lblIdentityCardNumber.Name = "lblIdentityCardNumber";
            this.lblIdentityCardNumber.Size = new System.Drawing.Size(116, 20);
            this.lblIdentityCardNumber.TabIndex = 2;
            this.lblIdentityCardNumber.Text = "Numer dowodu";
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.txtEmail);
            this.gbContact.Controls.Add(this.txtPhoneNumber);
            this.gbContact.Controls.Add(this.lblEmail);
            this.gbContact.Controls.Add(this.lblPhoneNumber);
            this.gbContact.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbContact.Location = new System.Drawing.Point(12, 258);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(387, 121);
            this.gbContact.TabIndex = 15;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Kontakt";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(187, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(187, 32);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(165, 30);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Adres email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 37);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(118, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Numer telefonu";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.txtPESEL);
            this.gbGeneral.Controls.Add(this.lblPESEL);
            this.gbGeneral.Controls.Add(this.dtpDateBirth);
            this.gbGeneral.Controls.Add(this.lblDateBirth);
            this.gbGeneral.Controls.Add(this.cbGender);
            this.gbGeneral.Controls.Add(this.lblGender);
            this.gbGeneral.Controls.Add(this.txtFirstName);
            this.gbGeneral.Controls.Add(this.txtLastName);
            this.gbGeneral.Controls.Add(this.lblFirstName);
            this.gbGeneral.Controls.Add(this.lblLastName);
            this.gbGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbGeneral.Location = new System.Drawing.Point(12, 11);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(387, 240);
            this.gbGeneral.TabIndex = 14;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "Ogólne";
            // 
            // txtPESEL
            // 
            this.txtPESEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPESEL.Location = new System.Drawing.Point(187, 188);
            this.txtPESEL.Name = "txtPESEL";
            this.txtPESEL.Size = new System.Drawing.Size(165, 30);
            this.txtPESEL.TabIndex = 11;
            this.txtPESEL.TextChanged += new System.EventHandler(this.txtPESEL_Validated);
            // 
            // lblPESEL
            // 
            this.lblPESEL.AutoSize = true;
            this.lblPESEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPESEL.Location = new System.Drawing.Point(13, 192);
            this.lblPESEL.Name = "lblPESEL";
            this.lblPESEL.Size = new System.Drawing.Size(61, 20);
            this.lblPESEL.TabIndex = 10;
            this.lblPESEL.Text = "PESEL";
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.CustomFormat = " ";
            this.dtpDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBirth.Location = new System.Drawing.Point(187, 148);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(165, 30);
            this.dtpDateBirth.TabIndex = 9;
            this.dtpDateBirth.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.Location = new System.Drawing.Point(13, 151);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(118, 20);
            this.lblDateBirth.TabIndex = 8;
            this.lblDateBirth.Text = "Data urodzenia";
            // 
            // cbGender
            // 
            this.cbGender.DataSource = this.bsGender;
            this.cbGender.DisplayMember = "Value";
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(187, 110);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(165, 33);
            this.cbGender.TabIndex = 7;
            this.cbGender.ValueMember = "Id";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(13, 113);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(40, 20);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Płeć";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(187, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 30);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(187, 32);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 30);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(13, 75);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(43, 20);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(13, 37);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Nazwisko";
            // 
            // tpEmployementHistory
            // 
            this.tpEmployementHistory.Controls.Add(this.tpIdentificationData);
            this.tpEmployementHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.tpEmployementHistory.Location = new System.Drawing.Point(27, 107);
            this.tpEmployementHistory.Name = "tpEmployementHistory";
            this.tpEmployementHistory.SelectedIndex = 0;
            this.tpEmployementHistory.Size = new System.Drawing.Size(825, 423);
            this.tpEmployementHistory.TabIndex = 5;
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(875, 595);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tpEmployementHistory);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "EmployeeEditForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPESEL)).EndInit();
            this.tpIdentificationData.ResumeLayout(false);
            this.gpPassport.ResumeLayout(false);
            this.gpPassport.PerformLayout();
            this.gpIdentityCard.ResumeLayout(false);
            this.gpIdentityCard.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.tpEmployementHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsGender;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epPESEL;
        private System.Windows.Forms.TabControl tpEmployementHistory;
        private System.Windows.Forms.TabPage tpIdentificationData;
        private System.Windows.Forms.GroupBox gpPassport;
        private System.Windows.Forms.DateTimePicker dtpExpirationDatePassport;
        private System.Windows.Forms.Label lblExpirationDatePassport;
        private System.Windows.Forms.DateTimePicker dtpIssueDatePassport;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label lblIssueDatePassport;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.GroupBox gpIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpExpirationDateIdentityCard;
        private System.Windows.Forms.Label lblExpirationDateIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpIssueDateIdentityCard;
        private System.Windows.Forms.TextBox txtIdentityCardNumber;
        private System.Windows.Forms.Label lblUssueDateIdentityCard;
        private System.Windows.Forms.Label lblIdentityCardNumber;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.TextBox txtPESEL;
        private System.Windows.Forms.Label lblPESEL;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
    }
}