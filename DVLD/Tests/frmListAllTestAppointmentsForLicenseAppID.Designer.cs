namespace DVLD.Tests
{
    partial class frmListAllTestAppointmentsForLicenseAppID
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.cmsAppointmentOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlLocalDrivingLicenseAppInfo1 = new DVLD.Applications.Local_Driving_License.UserControl.ctrlLocalDrivingLicenseAppInfo();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointmentOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Transparent;
            this.picImage.Image = global::DVLD.Properties.Resources.Vision_Test;
            this.picImage.Location = new System.Drawing.Point(320, -2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(160, 119);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(265, 114);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Size = new System.Drawing.Size(279, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblLabel.Location = new System.Drawing.Point(12, 596);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLabel.Size = new System.Drawing.Size(124, 20);
            this.lblLabel.TabIndex = 4;
            this.lblLabel.Text = "Appointments";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.ColumnHeadersHeight = 50;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointments.ContextMenuStrip = this.cmsAppointmentOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgvAppointments.Location = new System.Drawing.Point(16, 634);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 45;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(785, 182);
            this.dgvAppointments.TabIndex = 10;
            // 
            // cmsAppointmentOptions
            // 
            this.cmsAppointmentOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsAppointmentOptions.Name = "cmsAppointmentOptions";
            this.cmsAppointmentOptions.Size = new System.Drawing.Size(121, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblRecordCount.Location = new System.Drawing.Point(12, 832);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(72, 19);
            this.lblRecordCount.TabIndex = 6;
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
            this.btnClose.Location = new System.Drawing.Point(678, 838);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalDrivingLicenseAppInfo1
            // 
            this.ctrlLocalDrivingLicenseAppInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlLocalDrivingLicenseAppInfo1.Location = new System.Drawing.Point(3, 134);
            this.ctrlLocalDrivingLicenseAppInfo1.Name = "ctrlLocalDrivingLicenseAppInfo1";
            this.ctrlLocalDrivingLicenseAppInfo1.Size = new System.Drawing.Size(815, 494);
            this.ctrlLocalDrivingLicenseAppInfo1.TabIndex = 8;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnAddAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAddAppointment.Location = new System.Drawing.Point(729, 582);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(72, 41);
            this.btnAddAppointment.TabIndex = 9;
            this.btnAddAppointment.Text = "ADD +";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // frmListAllTestAppointmentsForLicenseAppID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(820, 888);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.ctrlLocalDrivingLicenseAppInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListAllTestAppointmentsForLicenseAppID";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "List Test Appointments";
            this.Load += new System.EventHandler(this.clsListAllTestAppointmentsForLicenseAppID_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointmentOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnClose;
        private Applications.Local_Driving_License.UserControl.ctrlLocalDrivingLicenseAppInfo ctrlLocalDrivingLicenseAppInfo1;
        private System.Windows.Forms.ContextMenuStrip cmsAppointmentOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Button btnAddAppointment;
    }
}