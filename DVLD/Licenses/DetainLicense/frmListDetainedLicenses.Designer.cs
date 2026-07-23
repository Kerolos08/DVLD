namespace DVLD.Licenses.DetainLicense
{
    partial class frmListDetainedLicenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.cmbReleasedFilters = new System.Windows.Forms.ComboBox();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReleaseLicense = new System.Windows.Forms.Button();
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasedDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.cmsApplications.SuspendLayout();
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
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Detained Licenses";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider.Location = new System.Drawing.Point(0, 80);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1405, 1);
            this.pnlDivider.TabIndex = 2;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlToolbar.Controls.Add(this.cmbReleasedFilters);
            this.pnlToolbar.Controls.Add(this.btnDetainLicense);
            this.pnlToolbar.Controls.Add(this.lblFilterBy);
            this.pnlToolbar.Controls.Add(this.cmbFilterBy);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnReleaseLicense);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 81);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1405, 70);
            this.pnlToolbar.TabIndex = 3;
            // 
            // cmbReleasedFilters
            // 
            this.cmbReleasedFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmbReleasedFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReleasedFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReleasedFilters.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbReleasedFilters.ForeColor = System.Drawing.Color.White;
            this.cmbReleasedFilters.FormattingEnabled = true;
            this.cmbReleasedFilters.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbReleasedFilters.Location = new System.Drawing.Point(270, 22);
            this.cmbReleasedFilters.Name = "cmbReleasedFilters";
            this.cmbReleasedFilters.Size = new System.Drawing.Size(110, 25);
            this.cmbReleasedFilters.TabIndex = 11;
            this.cmbReleasedFilters.SelectedIndexChanged += new System.EventHandler(this.cmbActiveFilters_SelectedIndexChanged);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetainLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnDetainLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetainLicense.FlatAppearance.BorderSize = 0;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDetainLicense.ForeColor = System.Drawing.Color.White;
            this.btnDetainLicense.Location = new System.Drawing.Point(1067, 16);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(140, 38);
            this.btnDetainLicense.TabIndex = 4;
            this.btnDetainLicense.Text = "Detain License";
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
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
            "Detain ID",
            "Is Released",
            "National No.",
            "Full Name",
            "Release Application ID"});
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
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReleaseLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnReleaseLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReleaseLicense.FlatAppearance.BorderSize = 0;
            this.btnReleaseLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReleaseLicense.ForeColor = System.Drawing.Color.White;
            this.btnReleaseLicense.Location = new System.Drawing.Point(1235, 16);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.Size = new System.Drawing.Size(140, 38);
            this.btnReleaseLicense.TabIndex = 3;
            this.btnReleaseLicense.Text = "Release License";
            this.btnReleaseLicense.UseVisualStyleBackColor = false;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AllowUserToResizeRows = false;
            this.dgvDetainedLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvDetainedLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetainedLicenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetainedLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicenses.ColumnHeadersHeight = 50;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetainedLicenses.ContextMenuStrip = this.cmsApplications;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicenses.EnableHeadersVisualStyles = false;
            this.dgvDetainedLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(30, 170);
            this.dgvDetainedLicenses.MultiSelect = false;
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.RowHeadersVisible = false;
            this.dgvDetainedLicenses.RowTemplate.Height = 45;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1345, 515);
            this.dgvDetainedLicenses.TabIndex = 4;
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
            this.lblRecordCount.TabIndex = 5;
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
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicensesHistoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.releasedDetainedLicenseToolStripMenuItem});
            this.cmsApplications.Name = "cmsApplications";
            this.cmsApplications.Size = new System.Drawing.Size(231, 120);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicensesHistoryToolStripMenuItem
            // 
            this.showPersonLicensesHistoryToolStripMenuItem.Name = "showPersonLicensesHistoryToolStripMenuItem";
            this.showPersonLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.showPersonLicensesHistoryToolStripMenuItem.Text = "Show Person Licenses History";
            this.showPersonLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicensesHistoryToolStripMenuItem_Click);
            // 
            // releasedDetainedLicenseToolStripMenuItem
            // 
            this.releasedDetainedLicenseToolStripMenuItem.Name = "releasedDetainedLicenseToolStripMenuItem";
            this.releasedDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.releasedDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releasedDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releasedDetainedLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // frmListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1405, 760);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmListDetainedLicenses";
            this.Text = "frmListDetainedLicenses";
            this.Load += new System.EventHandler(this.frmListDetainedLicenses_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnReleaseLicense;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.ComboBox cmbReleasedFilters;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem releasedDetainedLicenseToolStripMenuItem;
    }
}