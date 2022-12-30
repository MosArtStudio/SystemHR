namespace SystemHR.UserInterface.Forms.Contracts
{
    partial class ContractsForm
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpEmployees = new System.Windows.Forms.TableLayoutPanel();
            this.pEmployees = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.colId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tlpEmployees.SuspendLayout();
            this.pEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId2,
            this.positionDataGridViewTextBoxColumn,
            this.FirstName,
            this.LastName,
            this.StartDate,
            this.EndDate});
            this.dgvEmployees.DataSource = this.employeeModelBindingSource;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 60);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 62;
            this.dgvEmployees.RowTemplate.Height = 28;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(967, 387);
            this.dgvEmployees.TabIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Imię";
            this.FirstName.MinimumWidth = 8;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Nazwisko";
            this.LastName.MinimumWidth = 8;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.FillWeight = 110F;
            this.StartDate.HeaderText = "Data rozpoczęcia umowy";
            this.StartDate.MinimumWidth = 8;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "Data końca umowy";
            this.EndDate.MinimumWidth = 8;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // tlpEmployees
            // 
            this.tlpEmployees.ColumnCount = 1;
            this.tlpEmployees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployees.Controls.Add(this.pEmployees, 0, 0);
            this.tlpEmployees.Controls.Add(this.dgvEmployees, 0, 1);
            this.tlpEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployees.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployees.Name = "tlpEmployees";
            this.tlpEmployees.RowCount = 2;
            this.tlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployees.Size = new System.Drawing.Size(973, 450);
            this.tlpEmployees.TabIndex = 1;
            // 
            // pEmployees
            // 
            this.pEmployees.Controls.Add(this.btnRefresh);
            this.pEmployees.Controls.Add(this.btnDismiss);
            this.pEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEmployees.Location = new System.Drawing.Point(3, 3);
            this.pEmployees.Name = "pEmployees";
            this.pEmployees.Size = new System.Drawing.Size(967, 51);
            this.pEmployees.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Image = global::SystemHR.UserInterface.Properties.Resources.refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(130, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 51);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Odśwież  ";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDismiss.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDismiss.Image = global::SystemHR.UserInterface.Properties.Resources.dissmis_24;
            this.btnDismiss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDismiss.Location = new System.Drawing.Point(0, 0);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(130, 51);
            this.btnDismiss.TabIndex = 2;
            this.btnDismiss.Text = "Zwolnij   ";
            this.btnDismiss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDismiss.UseVisualStyleBackColor = false;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // colId2
            // 
            this.colId2.DataPropertyName = "Id";
            this.colId2.FillWeight = 50F;
            this.colId2.HeaderText = "Id";
            this.colId2.MinimumWidth = 8;
            this.colId2.Name = "colId2";
            this.colId2.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Umowa";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeModelBindingSource
            // 
            this.employeeModelBindingSource.DataSource = typeof(SystemHR.DataAccessLayer.Models.EmployeeModel);
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.tlpEmployees);
            this.Name = "ContractsForm";
            this.Text = "Umowy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContractsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tlpEmployees.ResumeLayout(false);
            this.pEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TableLayoutPanel tlpEmployees;
        private System.Windows.Forms.Panel pEmployees;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.BindingSource employeeModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}