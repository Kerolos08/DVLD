namespace DVLD.Tests.Test_Types
{
    partial class frmListTestTypes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTestTypes = new System.Windows.Forms.DataGridView();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).BeginInit();
            this.cmsTestTypes.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTestTypes
            // 
            this.dgvTestTypes.AllowUserToAddRows = false;
            this.dgvTestTypes.AllowUserToDeleteRows = false;
            this.dgvTestTypes.AllowUserToResizeRows = false;
            this.dgvTestTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvTestTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTestTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTestTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestTypes.ColumnHeadersHeight = 50;
            this.dgvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTestTypes.ContextMenuStrip = this.cmsTestTypes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTestTypes.EnableHeadersVisualStyles = false;
            this.dgvTestTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvTestTypes.Location = new System.Drawing.Point(30, 115);
            this.dgvTestTypes.MultiSelect = false;
            this.dgvTestTypes.Name = "dgvTestTypes";
            this.dgvTestTypes.ReadOnly = true;
            this.dgvTestTypes.RowHeadersVisible = false;
            this.dgvTestTypes.RowTemplate.Height = 45;
            this.dgvTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestTypes.Size = new System.Drawing.Size(707, 410);
            this.dgvTestTypes.TabIndex = 4;
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.cmsTestTypes.Name = "cmsTestTypes";
            this.cmsTestTypes.Size = new System.Drawing.Size(145, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.icons8_edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit Test Type";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(767, 100);
            this.pnlHeader.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Test Types";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider.Location = new System.Drawing.Point(0, 100);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(767, 1);
            this.pnlDivider.TabIndex = 11;
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
            this.btnClose.Location = new System.Drawing.Point(607, 558);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 9;
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
            this.lblRecordCount.Location = new System.Drawing.Point(26, 558);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(72, 19);
            this.lblRecordCount.TabIndex = 10;
            this.lblRecordCount.Text = "Records: 0";
            // 
            // frmListTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(767, 626);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTestTypes);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListTestTypes";
            this.Text = "Test Types";
            this.Load += new System.EventHandler(this.frmListTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypes)).EndInit();
            this.cmsTestTypes.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}