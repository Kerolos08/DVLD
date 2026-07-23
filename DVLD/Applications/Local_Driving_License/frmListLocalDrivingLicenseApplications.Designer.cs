namespace DVLD.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicenseApplications
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelApplicationtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTeststoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueLicensetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowLicensetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonLicenseHistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1405, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(381, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Local Driving License Applications";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider.Location = new System.Drawing.Point(0, 80);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1405, 1);
            this.pnlDivider.TabIndex = 1;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlToolbar.Controls.Add(this.lblFilterBy);
            this.pnlToolbar.Controls.Add(this.cmbFilterBy);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnAddNew);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 81);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1405, 70);
            this.pnlToolbar.TabIndex = 2;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblFilterBy.Location = new System.Drawing.Point(26, 25);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(58, 19);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Filter by";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterBy.ForeColor = System.Drawing.Color.White;
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None",
            "LDL.App ID",
            "National No.",
            "Full Name",
            "Status"});
            this.cmbFilterBy.Location = new System.Drawing.Point(95, 22);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(160, 25);
            this.cmbFilterBy.TabIndex = 1;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(270, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(1235, 16);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(140, 38);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add Application";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.AllowUserToResizeRows = false;
            this.dgvApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplications.ColumnHeadersHeight = 50;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApplications.ContextMenuStrip = this.cmsOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplications.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplications.EnableHeadersVisualStyles = false;
            this.dgvApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvApplications.Location = new System.Drawing.Point(30, 170);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.RowTemplate.Height = 45;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1345, 515);
            this.dgvApplications.TabIndex = 3;
            // 
            // cmsOptions
            // 
            this.cmsOptions.BackColor = System.Drawing.Color.White;
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.EditApplicationToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.CancelApplicationtoolStripMenuItem,
            this.toolStripSeparator3,
            this.ScheduleTeststoolStripMenuItem,
            this.toolStripSeparator4,
            this.IssueLicensetoolStripMenuItem,
            this.toolStripSeparator5,
            this.ShowLicensetoolStripMenuItem,
            this.PersonLicenseHistorytoolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(226, 234);
            this.cmsOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsOptions_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.AutoSize = false;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // EditApplicationToolStripMenuItem
            // 
            this.EditApplicationToolStripMenuItem.AutoSize = false;
            this.EditApplicationToolStripMenuItem.Name = "EditApplicationToolStripMenuItem";
            this.EditApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.EditApplicationToolStripMenuItem.Text = "Edit Application";
            this.EditApplicationToolStripMenuItem.Click += new System.EventHandler(this.EditApplicationToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.AutoSize = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // CancelApplicationtoolStripMenuItem
            // 
            this.CancelApplicationtoolStripMenuItem.Name = "CancelApplicationtoolStripMenuItem";
            this.CancelApplicationtoolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.CancelApplicationtoolStripMenuItem.Text = "Cancel Application";
            this.CancelApplicationtoolStripMenuItem.Click += new System.EventHandler(this.CancelApplicationtoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // ScheduleTeststoolStripMenuItem
            // 
            this.ScheduleTeststoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writenTestToolStripMenuItem,
            this.streetTestToolStripMenuItem});
            this.ScheduleTeststoolStripMenuItem.Name = "ScheduleTeststoolStripMenuItem";
            this.ScheduleTeststoolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ScheduleTeststoolStripMenuItem.Text = "Schedule Tests";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writenTestToolStripMenuItem
            // 
            this.writenTestToolStripMenuItem.Name = "writenTestToolStripMenuItem";
            this.writenTestToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.writenTestToolStripMenuItem.Text = "Writen Test";
            this.writenTestToolStripMenuItem.Click += new System.EventHandler(this.writenTestToolStripMenuItem_Click);
            // 
            // streetTestToolStripMenuItem
            // 
            this.streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
            this.streetTestToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.streetTestToolStripMenuItem.Text = "Street Test";
            this.streetTestToolStripMenuItem.Click += new System.EventHandler(this.streetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(222, 6);
            // 
            // IssueLicensetoolStripMenuItem
            // 
            this.IssueLicensetoolStripMenuItem.Name = "IssueLicensetoolStripMenuItem";
            this.IssueLicensetoolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.IssueLicensetoolStripMenuItem.Text = "Issue License (First Time)";
            this.IssueLicensetoolStripMenuItem.Click += new System.EventHandler(this.IssueLicensetoolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(222, 6);
            // 
            // ShowLicensetoolStripMenuItem
            // 
            this.ShowLicensetoolStripMenuItem.Name = "ShowLicensetoolStripMenuItem";
            this.ShowLicensetoolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ShowLicensetoolStripMenuItem.Text = "Show License";
            this.ShowLicensetoolStripMenuItem.Click += new System.EventHandler(this.ShowLicensetoolStripMenuItem_Click);
            // 
            // PersonLicenseHistorytoolStripMenuItem
            // 
            this.PersonLicenseHistorytoolStripMenuItem.Name = "PersonLicenseHistorytoolStripMenuItem";
            this.PersonLicenseHistorytoolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.PersonLicenseHistorytoolStripMenuItem.Text = "Show Person License History";
            this.PersonLicenseHistorytoolStripMenuItem.Click += new System.EventHandler(this.PersonLicenseHistorytoolStripMenuItem_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblRecordCount.Location = new System.Drawing.Point(26, 715);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(72, 19);
            this.lblRecordCount.TabIndex = 4;
            this.lblRecordCount.Text = "Records: 0";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1245, 705);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmListLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1405, 760);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplications_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CancelApplicationtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTeststoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem IssueLicensetoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ShowLicensetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonLicenseHistorytoolStripMenuItem;
    }
}