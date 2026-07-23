namespace DVLD.Users
{
    partial class frmUsersList
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmsManageUsersOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.cmbActiveFilters = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsManageUsersOptions.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeight = 50;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.ContextMenuStrip = this.cmsManageUsersOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvUsers.Location = new System.Drawing.Point(30, 176);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 45;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(879, 346);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.DoubleClick += new System.EventHandler(this.dgvUsers_DoubleClick);
            // 
            // cmsManageUsersOptions
            // 
            this.cmsManageUsersOptions.BackColor = System.Drawing.Color.White;
            this.cmsManageUsersOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.AddNewToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.ChangePasswordToolStripMenuItem1,
            this.toolStripSeparator1,
            this.SendEmailToolStripMenuItem,
            this.PhoneCallToolStripMenuItem});
            this.cmsManageUsersOptions.Name = "cmsManagePeopleOptions";
            this.cmsManageUsersOptions.Size = new System.Drawing.Size(169, 226);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.AutoSize = false;
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // AddNewToolStripMenuItem
            // 
            this.AddNewToolStripMenuItem.AutoSize = false;
            this.AddNewToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_add_24;
            this.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            this.AddNewToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.AddNewToolStripMenuItem.Text = "Add New User";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.AutoSize = false;
            this.EditToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_edit_32;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.AutoSize = false;
            this.DeleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_delete_32;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ChangePasswordToolStripMenuItem1
            // 
            this.ChangePasswordToolStripMenuItem1.AutoSize = false;
            this.ChangePasswordToolStripMenuItem1.Image = global::DVLD.Properties.Resources.icons8_change_password_32;
            this.ChangePasswordToolStripMenuItem1.Name = "ChangePasswordToolStripMenuItem1";
            this.ChangePasswordToolStripMenuItem1.Size = new System.Drawing.Size(196, 30);
            this.ChangePasswordToolStripMenuItem1.Text = "Change Password";
            this.ChangePasswordToolStripMenuItem1.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // SendEmailToolStripMenuItem
            // 
            this.SendEmailToolStripMenuItem.AutoSize = false;
            this.SendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.send_email_32;
            this.SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem";
            this.SendEmailToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.SendEmailToolStripMenuItem.Text = "Send Email";
            this.SendEmailToolStripMenuItem.Click += new System.EventHandler(this.SendEmailToolStripMenuItem_Click);
            // 
            // PhoneCallToolStripMenuItem
            // 
            this.PhoneCallToolStripMenuItem.AutoSize = false;
            this.PhoneCallToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.PhoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.PhoneCallToolStripMenuItem.Name = "PhoneCallToolStripMenuItem";
            this.PhoneCallToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.PhoneCallToolStripMenuItem.Text = "Phone Call";
            this.PhoneCallToolStripMenuItem.Click += new System.EventHandler(this.PhoneCallToolStripMenuItem_Click);
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlToolbar.Controls.Add(this.cmbActiveFilters);
            this.pnlToolbar.Controls.Add(this.lblFilterBy);
            this.pnlToolbar.Controls.Add(this.cmbFilterBy);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnAddUser);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 81);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(939, 70);
            this.pnlToolbar.TabIndex = 6;
            // 
            // cmbActiveFilters
            // 
            this.cmbActiveFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmbActiveFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbActiveFilters.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbActiveFilters.ForeColor = System.Drawing.Color.White;
            this.cmbActiveFilters.FormattingEnabled = true;
            this.cmbActiveFilters.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbActiveFilters.Location = new System.Drawing.Point(270, 22);
            this.cmbActiveFilters.Name = "cmbActiveFilters";
            this.cmbActiveFilters.Size = new System.Drawing.Size(110, 25);
            this.cmbActiveFilters.TabIndex = 10;
            this.cmbActiveFilters.SelectedIndexChanged += new System.EventHandler(this.cmbActiveFilters_SelectedIndexChanged);
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
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
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
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(769, 15);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(140, 38);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider.Location = new System.Drawing.Point(0, 80);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(939, 1);
            this.pnlDivider.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(939, 80);
            this.pnlHeader.TabIndex = 7;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::DVLD.Properties.Resources.icons8_person_64;
            this.picIcon.Location = new System.Drawing.Point(30, 20);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(40, 40);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(85, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Users";
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
            this.btnClose.Location = new System.Drawing.Point(779, 553);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblRecordCount.Location = new System.Drawing.Point(26, 569);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(72, 19);
            this.lblRecordCount.TabIndex = 9;
            this.lblRecordCount.Text = "Records: 0";
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(939, 621);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvUsers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsersList";
            this.Text = "User List";
            this.Load += new System.EventHandler(this.frmUserListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsManageUsersOptions.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip cmsManageUsersOptions;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AddNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cmbActiveFilters;
    }
}