namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeHireForm
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
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.gpIdentityCard = new System.Windows.Forms.GroupBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.bsPosition = new System.Windows.Forms.BindingSource(this.components);
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpirationDateIdentityCard = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblUssueDateIdentityCard = new System.Windows.Forms.Label();
            this.lblIdentityCardNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.gpIdentityCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEmployee
            // 
            this.pbEmployee.Image = global::SystemHR.UserInterface.Properties.Resources.employee_64;
            this.pbEmployee.Location = new System.Drawing.Point(696, 22);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(64, 64);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEmployee.TabIndex = 6;
            this.pbEmployee.TabStop = false;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(35, 60);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(315, 37);
            this.lblEmployee.TabIndex = 5;
            this.lblEmployee.Text = "Zatrudnij pracownika";
            // 
            // gpIdentityCard
            // 
            this.gpIdentityCard.Controls.Add(this.cbPosition);
            this.gpIdentityCard.Controls.Add(this.dtpEndDate);
            this.gpIdentityCard.Controls.Add(this.lblExpirationDateIdentityCard);
            this.gpIdentityCard.Controls.Add(this.dtpStartDate);
            this.gpIdentityCard.Controls.Add(this.lblUssueDateIdentityCard);
            this.gpIdentityCard.Controls.Add(this.lblIdentityCardNumber);
            this.gpIdentityCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpIdentityCard.Location = new System.Drawing.Point(184, 142);
            this.gpIdentityCard.Name = "gpIdentityCard";
            this.gpIdentityCard.Size = new System.Drawing.Size(440, 158);
            this.gpIdentityCard.TabIndex = 17;
            this.gpIdentityCard.TabStop = false;
            this.gpIdentityCard.Text = "Zatrudnij";
            // 
            // cbPosition
            // 
            this.cbPosition.DataSource = this.bsPosition;
            this.cbPosition.DisplayMember = "PositionName";
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(225, 30);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(196, 33);
            this.cbPosition.TabIndex = 13;
            this.cbPosition.ValueMember = "Id";
            // 
            // bsPosition
            // 
            this.bsPosition.DataSource = typeof(SystemHR.DataAccessLayer.Models.PositionModel);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = " ";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(225, 113);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(196, 30);
            this.dtpEndDate.TabIndex = 12;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblExpirationDateIdentityCard
            // 
            this.lblExpirationDateIdentityCard.AutoSize = true;
            this.lblExpirationDateIdentityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDateIdentityCard.Location = new System.Drawing.Point(13, 113);
            this.lblExpirationDateIdentityCard.Name = "lblExpirationDateIdentityCard";
            this.lblExpirationDateIdentityCard.Size = new System.Drawing.Size(184, 20);
            this.lblExpirationDateIdentityCard.TabIndex = 11;
            this.lblExpirationDateIdentityCard.Text = "Data rozwiązania umowy";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = " ";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(225, 75);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(196, 30);
            this.dtpStartDate.TabIndex = 10;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblUssueDateIdentityCard
            // 
            this.lblUssueDateIdentityCard.AutoSize = true;
            this.lblUssueDateIdentityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUssueDateIdentityCard.Location = new System.Drawing.Point(13, 75);
            this.lblUssueDateIdentityCard.Name = "lblUssueDateIdentityCard";
            this.lblUssueDateIdentityCard.Size = new System.Drawing.Size(186, 20);
            this.lblUssueDateIdentityCard.TabIndex = 3;
            this.lblUssueDateIdentityCard.Text = "Data rozpoczęcia umowy";
            // 
            // lblIdentityCardNumber
            // 
            this.lblIdentityCardNumber.AutoSize = true;
            this.lblIdentityCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityCardNumber.Location = new System.Drawing.Point(13, 37);
            this.lblIdentityCardNumber.Name = "lblIdentityCardNumber";
            this.lblIdentityCardNumber.Size = new System.Drawing.Size(112, 20);
            this.lblIdentityCardNumber.TabIndex = 2;
            this.lblIdentityCardNumber.Text = "Rodzaj umowy";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Image = global::SystemHR.UserInterface.Properties.Resources.cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(633, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(127, 49);
            this.btnCancel.TabIndex = 19;
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
            this.btnSave.Location = new System.Drawing.Point(495, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(127, 49);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EmployeeHireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(793, 410);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gpIdentityCard);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Name = "EmployeeHireForm";
            this.Text = " ";
            this.UseWaitCursor = false;
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.gpIdentityCard.ResumeLayout(false);
            this.gpIdentityCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.GroupBox gpIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblExpirationDateIdentityCard;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblUssueDateIdentityCard;
        private System.Windows.Forms.Label lblIdentityCardNumber;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.BindingSource bsPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}