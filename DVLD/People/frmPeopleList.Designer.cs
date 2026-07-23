namespace DVLD
{
    partial class frmPeopleList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cmsManagePeopleOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cmsManagePeopleOptions.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(85, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage People";
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
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Country",
            "Gender",
            "Phone",
            "Email"});
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
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.btnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddPerson.Location = new System.Drawing.Point(1235, 16);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(140, 38);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.ColumnHeadersHeight = 50;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeople.ContextMenuStrip = this.cmsManagePeopleOptions;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeople.EnableHeadersVisualStyles = false;
            this.dgvPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvPeople.Location = new System.Drawing.Point(30, 170);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowTemplate.Height = 45;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1345, 510);
            this.dgvPeople.TabIndex = 2;
            this.dgvPeople.DoubleClick += new System.EventHandler(this.dgvPeople_DoubleClick);
            // 
            // cmsManagePeopleOptions
            // 
            this.cmsManagePeopleOptions.BackColor = System.Drawing.Color.White;
            this.cmsManagePeopleOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.AddNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsManagePeopleOptions.Name = "cmsManagePeopleOptions";
            this.cmsManagePeopleOptions.Size = new System.Drawing.Size(163, 196);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.AutoSize = false;
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // AddNewToolStripMenuItem
            // 
            this.AddNewToolStripMenuItem.AutoSize = false;
            this.AddNewToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_add_24;
            this.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem";
            this.AddNewToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.AddNewToolStripMenuItem.Text = "Add New Perosn";
            this.AddNewToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.AutoSize = false;
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.AutoSize = false;
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.AutoSize = false;
            this.phoneCallToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblRecordCount.Location = new System.Drawing.Point(26, 705);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(72, 19);
            this.lblRecordCount.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(1245, 695);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.picIcon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1405, 80);
            this.pnlHeader.TabIndex = 5;
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
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlToolbar.Controls.Add(this.lblFilterBy);
            this.pnlToolbar.Controls.Add(this.cmbFilterBy);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnAddPerson);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 81);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1405, 70);
            this.pnlToolbar.TabIndex = 3;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider.Location = new System.Drawing.Point(0, 80);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1405, 1);
            this.pnlDivider.TabIndex = 4;
            // 
            // frmPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1405, 760);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPeopleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cmsManagePeopleOptions.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsManagePeopleOptions;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}