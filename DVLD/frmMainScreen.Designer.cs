namespace DVLD
{
    partial class frmMainScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.msMainNavMenu = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrivingLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewLicenseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLocalDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInternationalDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenewtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplacmenttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleasetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RetaketoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.msMainNavMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainNavMenu
            // 
            this.msMainNavMenu.AutoSize = false;
            this.msMainNavMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.msMainNavMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.msMainNavMenu.ForeColor = System.Drawing.Color.White;
            this.msMainNavMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.msMainNavMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.msMainNavMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainNavMenu.Name = "msMainNavMenu";
            this.msMainNavMenu.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.msMainNavMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMainNavMenu.Size = new System.Drawing.Size(1381, 65);
            this.msMainNavMenu.TabIndex = 1;
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrivingLicenseServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestToolStripMenuItem});
            this.applicationsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.applicationsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 10);
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(140, 45);
            this.applicationsToolStripMenuItem.Text = "📋  Applications";
            // 
            // DrivingLicenseServicesToolStripMenuItem
            // 
            this.DrivingLicenseServicesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.DrivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewLicenseStripMenuItem,
            this.RenewtoolStripMenuItem,
            this.ReplacmenttoolStripMenuItem,
            this.ReleasetoolStripMenuItem,
            this.RetaketoolStripMenuItem});
            this.DrivingLicenseServicesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DrivingLicenseServicesToolStripMenuItem.Name = "DrivingLicenseServicesToolStripMenuItem";
            this.DrivingLicenseServicesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.DrivingLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.DrivingLicenseServicesToolStripMenuItem.Text = "  ›  Driving License Services";
            // 
            // NewLicenseStripMenuItem
            // 
            this.NewLicenseStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.NewLicenseStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLocalDrivingLicenseToolStripMenuItem,
            this.newInternationalDrivingLicenseToolStripMenuItem});
            this.NewLicenseStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.NewLicenseStripMenuItem.Name = "NewLicenseStripMenuItem";
            this.NewLicenseStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.NewLicenseStripMenuItem.Text = "New Driving License";
            // 
            // newLocalDrivingLicenseToolStripMenuItem
            // 
            this.newLocalDrivingLicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.newLocalDrivingLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newLocalDrivingLicenseToolStripMenuItem.Name = "newLocalDrivingLicenseToolStripMenuItem";
            this.newLocalDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.newLocalDrivingLicenseToolStripMenuItem.Text = "New Local Driving License";
            this.newLocalDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newLocalDrivingLicenseToolStripMenuItem_Click);
            // 
            // newInternationalDrivingLicenseToolStripMenuItem
            // 
            this.newInternationalDrivingLicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.newInternationalDrivingLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newInternationalDrivingLicenseToolStripMenuItem.Name = "newInternationalDrivingLicenseToolStripMenuItem";
            this.newInternationalDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.newInternationalDrivingLicenseToolStripMenuItem.Text = "New International Driving License";
            this.newInternationalDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newInternationalDrivingLicenseToolStripMenuItem_Click);
            // 
            // RenewtoolStripMenuItem
            // 
            this.RenewtoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.RenewtoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RenewtoolStripMenuItem.Name = "RenewtoolStripMenuItem";
            this.RenewtoolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.RenewtoolStripMenuItem.Text = "Renew Driving License";
            this.RenewtoolStripMenuItem.Click += new System.EventHandler(this.RenewtoolStripMenuItem_Click);
            // 
            // ReplacmenttoolStripMenuItem
            // 
            this.ReplacmenttoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.ReplacmenttoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ReplacmenttoolStripMenuItem.Name = "ReplacmenttoolStripMenuItem";
            this.ReplacmenttoolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.ReplacmenttoolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            this.ReplacmenttoolStripMenuItem.Click += new System.EventHandler(this.ReplacmenttoolStripMenuItem_Click);
            // 
            // ReleasetoolStripMenuItem
            // 
            this.ReleasetoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.ReleasetoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ReleasetoolStripMenuItem.Name = "ReleasetoolStripMenuItem";
            this.ReleasetoolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.ReleasetoolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // RetaketoolStripMenuItem
            // 
            this.RetaketoolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.RetaketoolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RetaketoolStripMenuItem.Name = "RetaketoolStripMenuItem";
            this.RetaketoolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.RetaketoolStripMenuItem.Text = "Retake Test";
            this.RetaketoolStripMenuItem.Click += new System.EventHandler(this.RetaketoolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem,
            this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.manageApplicationsToolStripMenuItem.Text = "  ›  Manage Applications";
            // 
            // manageLocalDrivingLIcenseApplicationsToolStripMenuItem
            // 
            this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem.Name = "manageLocalDrivingLIcenseApplicationsToolStripMenuItem";
            this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem.Text = "Manage Local Driving License Applications";
            this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageLocalDrivingLIcenseApplicationsToolStripMenuItem_Click);
            // 
            // manageInternationalDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem.Name = "manageInternationalDrivingLicenseApplicationsToolStripMenuItem";
            this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem.Text = "Manage International Driving License Applications";
            this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageInternationalDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicencesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.detainLicensesToolStripMenuItem.Text = "  ›  Detain Licenses";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.manageApplicationTypesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.manageApplicationTypesToolStripMenuItem.Text = "  ›  Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestToolStripMenuItem
            // 
            this.manageTestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.manageTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageTestToolStripMenuItem.Name = "manageTestToolStripMenuItem";
            this.manageTestToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.manageTestToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.manageTestToolStripMenuItem.Text = "  ›  Manage Test Types";
            this.manageTestToolStripMenuItem.Click += new System.EventHandler(this.manageTestToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.peopleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 10);
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(104, 45);
            this.peopleToolStripMenuItem.Text = "👤  People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.driverToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 10);
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(109, 45);
            this.driverToolStripMenuItem.Text = "🚗  Drivers";
            this.driverToolStripMenuItem.Click += new System.EventHandler(this.driverToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 10);
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(99, 45);
            this.usersToolStripMenuItem.Text = "🔑  Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.siToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.accountSettingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 5, 10);
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(172, 45);
            this.accountSettingsToolStripMenuItem.Text = "⚙  Account Settings";
            // 
            // changeUserInfoToolStripMenuItem
            // 
            this.changeUserInfoToolStripMenuItem.AutoSize = false;
            this.changeUserInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.changeUserInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeUserInfoToolStripMenuItem.Name = "changeUserInfoToolStripMenuItem";
            this.changeUserInfoToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.changeUserInfoToolStripMenuItem.Text = "  Change User Info";
            this.changeUserInfoToolStripMenuItem.Click += new System.EventHandler(this.changeUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.AutoSize = false;
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.changePasswordToolStripMenuItem.Text = "  Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // siToolStripMenuItem
            // 
            this.siToolStripMenuItem.AutoSize = false;
            this.siToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.siToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.siToolStripMenuItem.Name = "siToolStripMenuItem";
            this.siToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.siToolStripMenuItem.Text = "  Sign Out";
            this.siToolStripMenuItem.Click += new System.EventHandler(this.siToolStripMenuItem_Click);
            // 
            // manageDetainedLicencesToolStripMenuItem
            // 
            this.manageDetainedLicencesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.manageDetainedLicencesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageDetainedLicencesToolStripMenuItem.Name = "manageDetainedLicencesToolStripMenuItem";
            this.manageDetainedLicencesToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.manageDetainedLicencesToolStripMenuItem.Text = "Manage Detained Licences";
            this.manageDetainedLicencesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicencesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.detainLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.releaseDetainedLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Image = global::DVLD.Properties.Resources.ChatGPT_Image_Jun_7__2026__07_49_41_PM;
            this.pbImage.Location = new System.Drawing.Point(0, 65);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1381, 770);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1381, 835);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.msMainNavMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMainNavMenu.ResumeLayout(false);
            this.msMainNavMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainNavMenu;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DrivingLicenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ToolStripMenuItem changeUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLocalDrivingLIcenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInternationalDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewLicenseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenewtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplacmenttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReleasetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RetaketoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLocalDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInternationalDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}