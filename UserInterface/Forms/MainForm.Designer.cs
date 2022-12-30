namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tcGeneral = new System.Windows.Forms.TabPage();
            this.btnContracts = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btmEmployees = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tcMain.SuspendLayout();
            this.tcGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tcGeneral);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1181, 110);
            this.tcMain.TabIndex = 0;
            // 
            // tcGeneral
            // 
            this.tcGeneral.Controls.Add(this.btnContracts);
            this.tcGeneral.Controls.Add(this.splitter1);
            this.tcGeneral.Controls.Add(this.btmEmployees);
            this.tcGeneral.Location = new System.Drawing.Point(4, 29);
            this.tcGeneral.Name = "tcGeneral";
            this.tcGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tcGeneral.Size = new System.Drawing.Size(1173, 77);
            this.tcGeneral.TabIndex = 0;
            this.tcGeneral.Text = "Ogólne";
            this.tcGeneral.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.Color.White;
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContracts.Image = global::SystemHR.UserInterface.Properties.Resources.Positions_32;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(162, 3);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(133, 71);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Umowy  ";
            this.btnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContracts.UseVisualStyleBackColor = false;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(155, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(7, 71);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btmEmployees
            // 
            this.btmEmployees.BackColor = System.Drawing.Color.White;
            this.btmEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btmEmployees.Image = global::SystemHR.UserInterface.Properties.Resources.Emplyees_32;
            this.btmEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmEmployees.Location = new System.Drawing.Point(3, 3);
            this.btmEmployees.Name = "btmEmployees";
            this.btmEmployees.Size = new System.Drawing.Size(152, 71);
            this.btmEmployees.TabIndex = 0;
            this.btmEmployees.Text = "Pracownicy";
            this.btmEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmEmployees.UseVisualStyleBackColor = false;
            this.btmEmployees.Click += new System.EventHandler(this.btmEmployees_Click);
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 722);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1181, 32);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(121, 25);
            this.tsslVersion.Text = "Wersja 1.0.0.0";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(191, 25);
            this.tsslDatabase.Text = "Baza: Human Resource";
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(202, 25);
            this.tsslUser.Text = "Użytkownik: Radoław M";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 110);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1181, 612);
            this.pMain.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(110, 18);
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(1181, 612);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 11;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTabs_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 754);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System HR";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tcGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tcGeneral;
        private System.Windows.Forms.Button btmEmployees;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.TabControl tcTabs;
    }
}