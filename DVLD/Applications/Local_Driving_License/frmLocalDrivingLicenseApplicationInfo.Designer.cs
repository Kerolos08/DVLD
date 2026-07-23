namespace DVLD.Applications.Local_Driving_License
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            this.ctrlLocalDrivingLicenseAppInfo1 = new DVLD.Applications.Local_Driving_License.UserControl.ctrlLocalDrivingLicenseAppInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseAppInfo1
            // 
            this.ctrlLocalDrivingLicenseAppInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlLocalDrivingLicenseAppInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLocalDrivingLicenseAppInfo1.Name = "ctrlLocalDrivingLicenseAppInfo1";
            this.ctrlLocalDrivingLicenseAppInfo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctrlLocalDrivingLicenseAppInfo1.Size = new System.Drawing.Size(815, 459);
            this.ctrlLocalDrivingLicenseAppInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.Location = new System.Drawing.Point(671, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(813, 526);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlLocalDrivingLicenseAppInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocalDrivingLicenseApplicationInfo";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Application Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.ctrlLocalDrivingLicenseAppInfo ctrlLocalDrivingLicenseAppInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}