namespace DVLD.Applications.ApplicationTypes
{
    partial class frmListApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.cmsApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EdittoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            this.cmsApplicationTypes.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTypes
            // 
            this.dgvTypes.AllowUserToAddRows = false;
            this.dgvTypes.AllowUserToDeleteRows = false;
            this.dgvTypes.AllowUserToResizeRows = false;
            this.dgvTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTypes.ColumnHeadersHeight = 50;
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTypes.ContextMenuStrip = this.cmsApplicationTypes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTypes.EnableHeadersVisualStyles = false;
            this.dgvTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvTypes.Location = new System.Drawing.Point(30, 115);
            this.dgvTypes.MultiSelect = false;
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.ReadOnly = true;
            this.dgvTypes.RowHeadersVisible = false;
            this.dgvTypes.RowTemplate.Height = 35;
            this.dgvTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypes.Size = new System.Drawing.Size(555, 410);
            this.dgvTypes.TabIndex = 4;
            // 
            // cmsApplicationTypes
            // 
            this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EdittoolStripMenuItem1});
            this.cmsApplicationTypes.Name = "cmsApplicationTypes";
            this.cmsApplicationTypes.Size = new System.Drawing.Size(159, 26);
            // 
            // EdittoolStripMenuItem1
            // 
            this.EdittoolStripMenuItem1.Image = global::DVLD.Properties.Resources.icons8_edit_32;
            this.EdittoolStripMenuItem1.Name = "EdittoolStripMenuItem1";
            this.EdittoolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.EdittoolStripMenuItem1.Text = "Edit Application";
            this.EdittoolStripMenuItem1.Click += new System.EventHandler(this.EdittoolStripMenuItem1_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(615, 100);
            this.pnlHeader.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Application Types";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider.Location = new System.Drawing.Point(0, 100);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(615, 1);
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
            this.btnClose.Location = new System.Drawing.Point(455, 558);
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
            // frmListApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(615, 626);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTypes);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.pnlHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListApplicationTypes";
            this.Text = "Application Types";
            this.Load += new System.EventHandler(this.frmListApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            this.cmsApplicationTypes.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem EdittoolStripMenuItem1;
    }
}