namespace DVLD.Licenses
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbLicenses = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.cmsLocalLicensesOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LicenseInfotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInternational = new System.Windows.Forms.TabPage();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.cmsInternationalLicensesOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InternationalLicenseInfotoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLicenses.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.cmsLocalLicensesOptions.SuspendLayout();
            this.tbInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.cmsInternationalLicensesOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLicenses
            // 
            this.tbLicenses.Controls.Add(this.tabPage1);
            this.tbLicenses.Controls.Add(this.tbInternational);
            this.tbLicenses.Location = new System.Drawing.Point(18, 57);
            this.tbLicenses.Name = "tbLicenses";
            this.tbLicenses.SelectedIndex = 0;
            this.tbLicenses.Size = new System.Drawing.Size(778, 259);
            this.tbLicenses.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvLocal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            // 
            // dgvLocal
            // 
            this.dgvLocal.AllowUserToAddRows = false;
            this.dgvLocal.AllowUserToDeleteRows = false;
            this.dgvLocal.AllowUserToResizeRows = false;
            this.dgvLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLocal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocal.ColumnHeadersHeight = 50;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLocal.ContextMenuStrip = this.cmsLocalLicensesOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocal.EnableHeadersVisualStyles = false;
            this.dgvLocal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvLocal.Location = new System.Drawing.Point(10, 35);
            this.dgvLocal.MultiSelect = false;
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.ReadOnly = true;
            this.dgvLocal.RowHeadersVisible = false;
            this.dgvLocal.RowTemplate.Height = 45;
            this.dgvLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocal.Size = new System.Drawing.Size(741, 183);
            this.dgvLocal.TabIndex = 10;
            // 
            // cmsLocalLicensesOptions
            // 
            this.cmsLocalLicensesOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LicenseInfotoolStripMenuItem});
            this.cmsLocalLicensesOptions.Name = "cmsLocalLicensesOptions";
            this.cmsLocalLicensesOptions.Size = new System.Drawing.Size(167, 26);
            // 
            // LicenseInfotoolStripMenuItem
            // 
            this.LicenseInfotoolStripMenuItem.Name = "LicenseInfotoolStripMenuItem";
            this.LicenseInfotoolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.LicenseInfotoolStripMenuItem.Text = "Show license Info";
            this.LicenseInfotoolStripMenuItem.Click += new System.EventHandler(this.LicenseInfotoolStripMenuItem_Click);
            // 
            // tbInternational
            // 
            this.tbInternational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbInternational.Controls.Add(this.label1);
            this.tbInternational.Controls.Add(this.dgvInternational);
            this.tbInternational.Location = new System.Drawing.Point(4, 22);
            this.tbInternational.Name = "tbInternational";
            this.tbInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tbInternational.Size = new System.Drawing.Size(770, 233);
            this.tbInternational.TabIndex = 1;
            this.tbInternational.Text = "International";
            // 
            // dgvInternational
            // 
            this.dgvInternational.AllowUserToAddRows = false;
            this.dgvInternational.AllowUserToDeleteRows = false;
            this.dgvInternational.AllowUserToResizeRows = false;
            this.dgvInternational.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInternational.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternational.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvInternational.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInternational.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInternational.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternational.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternational.ColumnHeadersHeight = 50;
            this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInternational.ContextMenuStrip = this.cmsInternationalLicensesOption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternational.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInternational.EnableHeadersVisualStyles = false;
            this.dgvInternational.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvInternational.Location = new System.Drawing.Point(10, 35);
            this.dgvInternational.MultiSelect = false;
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            this.dgvInternational.RowHeadersVisible = false;
            this.dgvInternational.RowTemplate.Height = 45;
            this.dgvInternational.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternational.Size = new System.Drawing.Size(741, 183);
            this.dgvInternational.TabIndex = 11;
            // 
            // cmsInternationalLicensesOption
            // 
            this.cmsInternationalLicensesOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InternationalLicenseInfotoolStripMenuItem1});
            this.cmsInternationalLicensesOption.Name = "cmsLocalLicensesOptions";
            this.cmsInternationalLicensesOption.Size = new System.Drawing.Size(167, 26);
            // 
            // InternationalLicenseInfotoolStripMenuItem1
            // 
            this.InternationalLicenseInfotoolStripMenuItem1.Name = "InternationalLicenseInfotoolStripMenuItem1";
            this.InternationalLicenseInfotoolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.InternationalLicenseInfotoolStripMenuItem1.Text = "Show license Info";
            this.InternationalLicenseInfotoolStripMenuItem1.Click += new System.EventHandler(this.InternationalLicenseInfotoolStripMenuItem1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Driver Licenses";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblRecordCount.Location = new System.Drawing.Point(28, 337);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(72, 19);
            this.lblRecordCount.TabIndex = 8;
            this.lblRecordCount.Text = "Records: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "International Licenses History: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Local Licenses History: ";
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbLicenses);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(815, 368);
            this.tbLicenses.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.cmsLocalLicensesOptions.ResumeLayout(false);
            this.tbInternational.ResumeLayout(false);
            this.tbInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.cmsInternationalLicensesOption.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbLicenses;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbInternational;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.DataGridView dgvInternational;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicensesOptions;
        private System.Windows.Forms.ToolStripMenuItem LicenseInfotoolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicensesOption;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicenseInfotoolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
