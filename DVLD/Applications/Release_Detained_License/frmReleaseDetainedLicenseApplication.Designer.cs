namespace DVLD.Applications.Release_Detained_License
{
    partial class frmReleaseDetainedLicenseApplication
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.UserControls.ctrlDriverLicenseInfoWithFilter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLicenseIDValue = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblIDetainDateTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetainIDTitle = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblFineFeesTitle = new System.Windows.Forms.Label();
            this.lblCreatedTitle = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lbShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lbShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAppFeesTitle = new System.Windows.Forms.Label();
            this.lblTotalFeesTitle = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblAppIDTitle = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 32);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Release Detained License";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 63);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(814, 469);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 35;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblFineFees);
            this.pnlMain.Controls.Add(this.lblAppID);
            this.pnlMain.Controls.Add(this.lblAppIDTitle);
            this.pnlMain.Controls.Add(this.lblTotalFees);
            this.pnlMain.Controls.Add(this.lblAppFees);
            this.pnlMain.Controls.Add(this.lblTotalFeesTitle);
            this.pnlMain.Controls.Add(this.lblAppFeesTitle);
            this.pnlMain.Controls.Add(this.lblLicenseIDValue);
            this.pnlMain.Controls.Add(this.lblLicenseID);
            this.pnlMain.Controls.Add(this.lblDetainDate);
            this.pnlMain.Controls.Add(this.lblIDetainDateTitle);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblDetainIDTitle);
            this.pnlMain.Controls.Add(this.lblDetainID);
            this.pnlMain.Controls.Add(this.lblFineFeesTitle);
            this.pnlMain.Controls.Add(this.lblCreatedTitle);
            this.pnlMain.Controls.Add(this.lblCreatedBy);
            this.pnlMain.Location = new System.Drawing.Point(12, 538);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(789, 200);
            this.pnlMain.TabIndex = 36;
            // 
            // lblLicenseIDValue
            // 
            this.lblLicenseIDValue.AutoSize = true;
            this.lblLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLicenseIDValue.ForeColor = System.Drawing.Color.White;
            this.lblLicenseIDValue.Location = new System.Drawing.Point(561, 63);
            this.lblLicenseIDValue.Name = "lblLicenseIDValue";
            this.lblLicenseIDValue.Size = new System.Drawing.Size(41, 19);
            this.lblLicenseIDValue.TabIndex = 24;
            this.lblLicenseIDValue.Text = "[????]";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseID.ForeColor = System.Drawing.Color.Silver;
            this.lblLicenseID.Location = new System.Drawing.Point(462, 63);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(79, 19);
            this.lblLicenseID.TabIndex = 23;
            this.lblLicenseID.Text = "License ID:";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetainDate.ForeColor = System.Drawing.Color.White;
            this.lblDetainDate.Location = new System.Drawing.Point(170, 96);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(41, 19);
            this.lblDetainDate.TabIndex = 20;
            this.lblDetainDate.Text = "[????]";
            // 
            // lblIDetainDateTitle
            // 
            this.lblIDetainDateTitle.AutoSize = true;
            this.lblIDetainDateTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIDetainDateTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblIDetainDateTitle.Location = new System.Drawing.Point(60, 96);
            this.lblIDetainDateTitle.Name = "lblIDetainDateTitle";
            this.lblIDetainDateTitle.Size = new System.Drawing.Size(91, 19);
            this.lblIDetainDateTitle.TabIndex = 14;
            this.lblIDetainDateTitle.Text = "Detain Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain Info";
            // 
            // lblDetainIDTitle
            // 
            this.lblDetainIDTitle.AutoSize = true;
            this.lblDetainIDTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetainIDTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblDetainIDTitle.Location = new System.Drawing.Point(77, 63);
            this.lblDetainIDTitle.Name = "lblDetainIDTitle";
            this.lblDetainIDTitle.Size = new System.Drawing.Size(74, 19);
            this.lblDetainIDTitle.TabIndex = 1;
            this.lblDetainIDTitle.Text = "Detain ID:";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetainID.ForeColor = System.Drawing.Color.White;
            this.lblDetainID.Location = new System.Drawing.Point(170, 63);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(41, 19);
            this.lblDetainID.TabIndex = 2;
            this.lblDetainID.Text = "[????]";
            // 
            // lblFineFeesTitle
            // 
            this.lblFineFeesTitle.AutoSize = true;
            this.lblFineFeesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFineFeesTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblFineFeesTitle.Location = new System.Drawing.Point(468, 129);
            this.lblFineFeesTitle.Name = "lblFineFeesTitle";
            this.lblFineFeesTitle.Size = new System.Drawing.Size(73, 19);
            this.lblFineFeesTitle.TabIndex = 5;
            this.lblFineFeesTitle.Text = "Fine Fees:";
            // 
            // lblCreatedTitle
            // 
            this.lblCreatedTitle.AutoSize = true;
            this.lblCreatedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblCreatedTitle.Location = new System.Drawing.Point(454, 96);
            this.lblCreatedTitle.Name = "lblCreatedTitle";
            this.lblCreatedTitle.Size = new System.Drawing.Size(87, 19);
            this.lblCreatedTitle.TabIndex = 17;
            this.lblCreatedTitle.Text = "Created By:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.White;
            this.lblCreatedBy.Location = new System.Drawing.Point(561, 96);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(41, 19);
            this.lblCreatedBy.TabIndex = 18;
            this.lblCreatedBy.Text = "[????]";
            // 
            // lbShowLicensesHistory
            // 
            this.lbShowLicensesHistory.AutoSize = true;
            this.lbShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicensesHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.lbShowLicensesHistory.Location = new System.Drawing.Point(15, 752);
            this.lbShowLicensesHistory.Name = "lbShowLicensesHistory";
            this.lbShowLicensesHistory.Size = new System.Drawing.Size(142, 16);
            this.lbShowLicensesHistory.TabIndex = 35;
            this.lbShowLicensesHistory.TabStop = true;
            this.lbShowLicensesHistory.Text = "Show Licenses History";
            this.lbShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicensesHistory_LinkClicked);
            // 
            // lbShowLicenseInfo
            // 
            this.lbShowLicenseInfo.AutoSize = true;
            this.lbShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicenseInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.lbShowLicenseInfo.Location = new System.Drawing.Point(163, 752);
            this.lbShowLicenseInfo.Name = "lbShowLicenseInfo";
            this.lbShowLicenseInfo.Size = new System.Drawing.Size(114, 16);
            this.lbShowLicenseInfo.TabIndex = 37;
            this.lbShowLicenseInfo.TabStop = true;
            this.lbShowLicenseInfo.Text = "Show License Info";
            this.lbShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicenseInfo_LinkClicked);
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
            this.btnClose.Location = new System.Drawing.Point(523, 784);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btnSave.Location = new System.Drawing.Point(679, 784);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "💾  Release";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAppFeesTitle
            // 
            this.lblAppFeesTitle.AutoSize = true;
            this.lblAppFeesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppFeesTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblAppFeesTitle.Location = new System.Drawing.Point(28, 129);
            this.lblAppFeesTitle.Name = "lblAppFeesTitle";
            this.lblAppFeesTitle.Size = new System.Drawing.Size(123, 19);
            this.lblAppFeesTitle.TabIndex = 40;
            this.lblAppFeesTitle.Text = "Application Fees:";
            // 
            // lblTotalFeesTitle
            // 
            this.lblTotalFeesTitle.AutoSize = true;
            this.lblTotalFeesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFeesTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTotalFeesTitle.Location = new System.Drawing.Point(72, 162);
            this.lblTotalFeesTitle.Name = "lblTotalFeesTitle";
            this.lblTotalFeesTitle.Size = new System.Drawing.Size(79, 19);
            this.lblTotalFeesTitle.TabIndex = 41;
            this.lblTotalFeesTitle.Text = "Total Fees:";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppFees.ForeColor = System.Drawing.Color.White;
            this.lblAppFees.Location = new System.Drawing.Point(170, 129);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(41, 19);
            this.lblAppFees.TabIndex = 42;
            this.lblAppFees.Text = "[????]";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalFees.ForeColor = System.Drawing.Color.White;
            this.lblTotalFees.Location = new System.Drawing.Point(170, 162);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(41, 19);
            this.lblTotalFees.TabIndex = 43;
            this.lblTotalFees.Text = "[????]";
            // 
            // lblAppIDTitle
            // 
            this.lblAppIDTitle.AutoSize = true;
            this.lblAppIDTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppIDTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblAppIDTitle.Location = new System.Drawing.Point(433, 162);
            this.lblAppIDTitle.Name = "lblAppIDTitle";
            this.lblAppIDTitle.Size = new System.Drawing.Size(108, 19);
            this.lblAppIDTitle.TabIndex = 44;
            this.lblAppIDTitle.Text = "Application ID:";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppID.ForeColor = System.Drawing.Color.White;
            this.lblAppID.Location = new System.Drawing.Point(561, 162);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(41, 19);
            this.lblAppID.TabIndex = 45;
            this.lblAppID.Text = "[????]";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFineFees.ForeColor = System.Drawing.Color.White;
            this.lblFineFees.Location = new System.Drawing.Point(561, 129);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(41, 19);
            this.lblFineFees.TabIndex = 46;
            this.lblFineFees.Text = "[????]";
            // 
            // frmReleaseDetainedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(813, 852);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbShowLicenseInfo);
            this.Controls.Add(this.lbShowLicensesHistory);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReleaseDetainedLicenseApplication";
            this.Text = "Release Detained License Application";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicenseApplication_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Licenses.Local_Licenses.UserControls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLicenseIDValue;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblIDetainDateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetainIDTitle;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblFineFeesTitle;
        private System.Windows.Forms.Label lblCreatedTitle;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.LinkLabel lbShowLicensesHistory;
        private System.Windows.Forms.LinkLabel lbShowLicenseInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalFeesTitle;
        private System.Windows.Forms.Label lblAppFeesTitle;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblAppIDTitle;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblAppID;
    }
}