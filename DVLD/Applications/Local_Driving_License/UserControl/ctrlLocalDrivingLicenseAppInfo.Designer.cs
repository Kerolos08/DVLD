namespace DVLD.Applications.Local_Driving_License.UserControl
{
    partial class ctrlLocalDrivingLicenseAppInfo
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDLAppIDTitle = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblLicenseClassValue = new System.Windows.Forms.Label();
            this.lblPassedTestLabel = new System.Windows.Forms.Label();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.llViewLicense = new System.Windows.Forms.LinkLabel();
            this.ctrlApplicationBasicInfo1 = new DVLD.Applications.UserControls.ctrlApplicationBasicInfo();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblDLAppIDTitle);
            this.pnlMain.Controls.Add(this.lblDLAppID);
            this.pnlMain.Controls.Add(this.lblLicenseClass);
            this.pnlMain.Controls.Add(this.lblLicenseClassValue);
            this.pnlMain.Controls.Add(this.lblPassedTestLabel);
            this.pnlMain.Controls.Add(this.lblPassedTests);
            this.pnlMain.Controls.Add(this.llViewLicense);
            this.pnlMain.Location = new System.Drawing.Point(13, 20);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(790, 156);
            this.pnlMain.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Local Driving License Application Info";
            // 
            // lblDLAppIDTitle
            // 
            this.lblDLAppIDTitle.AutoSize = true;
            this.lblDLAppIDTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDLAppIDTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblDLAppIDTitle.Location = new System.Drawing.Point(63, 73);
            this.lblDLAppIDTitle.Name = "lblDLAppIDTitle";
            this.lblDLAppIDTitle.Size = new System.Drawing.Size(80, 19);
            this.lblDLAppIDTitle.TabIndex = 1;
            this.lblDLAppIDTitle.Text = "DL App ID:";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDLAppID.ForeColor = System.Drawing.Color.White;
            this.lblDLAppID.Location = new System.Drawing.Point(152, 73);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(41, 19);
            this.lblDLAppID.TabIndex = 2;
            this.lblDLAppID.Text = "[????]";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseClass.ForeColor = System.Drawing.Color.Silver;
            this.lblLicenseClass.Location = new System.Drawing.Point(338, 73);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(144, 19);
            this.lblLicenseClass.TabIndex = 3;
            this.lblLicenseClass.Text = "Applied For License:";
            // 
            // lblLicenseClassValue
            // 
            this.lblLicenseClassValue.AutoSize = true;
            this.lblLicenseClassValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLicenseClassValue.ForeColor = System.Drawing.Color.White;
            this.lblLicenseClassValue.Location = new System.Drawing.Point(488, 73);
            this.lblLicenseClassValue.Name = "lblLicenseClassValue";
            this.lblLicenseClassValue.Size = new System.Drawing.Size(41, 19);
            this.lblLicenseClassValue.TabIndex = 4;
            this.lblLicenseClassValue.Text = "[????]";
            // 
            // lblPassedTestLabel
            // 
            this.lblPassedTestLabel.AutoSize = true;
            this.lblPassedTestLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassedTestLabel.ForeColor = System.Drawing.Color.Silver;
            this.lblPassedTestLabel.Location = new System.Drawing.Point(48, 117);
            this.lblPassedTestLabel.Name = "lblPassedTestLabel";
            this.lblPassedTestLabel.Size = new System.Drawing.Size(95, 19);
            this.lblPassedTestLabel.TabIndex = 5;
            this.lblPassedTestLabel.Text = "Passed Tests:";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassedTests.ForeColor = System.Drawing.Color.White;
            this.lblPassedTests.Location = new System.Drawing.Point(152, 117);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(41, 19);
            this.lblPassedTests.TabIndex = 6;
            this.lblPassedTests.Text = "[????]";
            // 
            // llViewLicense
            // 
            this.llViewLicense.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.llViewLicense.AutoSize = true;
            this.llViewLicense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.llViewLicense.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.llViewLicense.Location = new System.Drawing.Point(415, 117);
            this.llViewLicense.Name = "llViewLicense";
            this.llViewLicense.Size = new System.Drawing.Size(114, 19);
            this.llViewLicense.TabIndex = 19;
            this.llViewLicense.TabStop = true;
            this.llViewLicense.Text = "View License Info";
            this.llViewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llViewLicense_LinkClicked);
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(0, 180);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(815, 275);
            this.ctrlApplicationBasicInfo1.TabIndex = 3;
            // 
            // ctrlLocalDrivingLicenseAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Controls.Add(this.pnlMain);
            this.Name = "ctrlLocalDrivingLicenseAppInfo";
            this.Size = new System.Drawing.Size(815, 459);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDLAppIDTitle;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label lblLicenseClassValue;
        private System.Windows.Forms.Label lblPassedTestLabel;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.LinkLabel llViewLicense;
        private UserControls.ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
    }
}
