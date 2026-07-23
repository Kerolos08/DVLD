namespace DVLD.Applications.Renew_Local_Driving_License
{
    partial class frmRenewLocalDrivingLicenseApplication
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
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.UserControls.ctrlDriverLicenseInfoWithFilter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblExpDateValue = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblRenewedLicenseIDValue = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.lblLicenseFeesValue = new System.Windows.Forms.Label();
            this.lblLicenseFeesTitle = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblIssueDateTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppIDTitle = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblAppFeesTitle = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCreatedTitle = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lbShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lbShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-1, 62);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(814, 469);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Renew License Application";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblNotes);
            this.pnlMain.Controls.Add(this.txtNotes);
            this.pnlMain.Controls.Add(this.lblTotalFeesValue);
            this.pnlMain.Controls.Add(this.lblTotalFees);
            this.pnlMain.Controls.Add(this.lblExpDateValue);
            this.pnlMain.Controls.Add(this.lblExpDate);
            this.pnlMain.Controls.Add(this.lblOldLicenseIDValue);
            this.pnlMain.Controls.Add(this.lblOldLicenseID);
            this.pnlMain.Controls.Add(this.lblRenewedLicenseIDValue);
            this.pnlMain.Controls.Add(this.lblRenewedLicenseID);
            this.pnlMain.Controls.Add(this.lblLicenseFeesValue);
            this.pnlMain.Controls.Add(this.lblLicenseFeesTitle);
            this.pnlMain.Controls.Add(this.lblIssueDate);
            this.pnlMain.Controls.Add(this.lblIssueDateTitle);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblAppIDTitle);
            this.pnlMain.Controls.Add(this.lblAppID);
            this.pnlMain.Controls.Add(this.lblAppFeesTitle);
            this.pnlMain.Controls.Add(this.lblAppFees);
            this.pnlMain.Controls.Add(this.lblDateTitle);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.lblCreatedTitle);
            this.pnlMain.Controls.Add(this.lblCreatedBy);
            this.pnlMain.Location = new System.Drawing.Point(13, 537);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(789, 332);
            this.pnlMain.TabIndex = 4;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.Silver;
            this.lblNotes.Location = new System.Drawing.Point(85, 235);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(52, 19);
            this.lblNotes.TabIndex = 31;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.ForeColor = System.Drawing.Color.Silver;
            this.txtNotes.Location = new System.Drawing.Point(156, 235);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(585, 74);
            this.txtNotes.TabIndex = 30;
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalFeesValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalFeesValue.Location = new System.Drawing.Point(591, 193);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(41, 19);
            this.lblTotalFeesValue.TabIndex = 28;
            this.lblTotalFeesValue.Text = "[????]";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.ForeColor = System.Drawing.Color.Silver;
            this.lblTotalFees.Location = new System.Drawing.Point(492, 193);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(79, 19);
            this.lblTotalFees.TabIndex = 29;
            this.lblTotalFees.Text = "Total Fees:";
            // 
            // lblExpDateValue
            // 
            this.lblExpDateValue.AutoSize = true;
            this.lblExpDateValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblExpDateValue.ForeColor = System.Drawing.Color.White;
            this.lblExpDateValue.Location = new System.Drawing.Point(591, 127);
            this.lblExpDateValue.Name = "lblExpDateValue";
            this.lblExpDateValue.Size = new System.Drawing.Size(41, 19);
            this.lblExpDateValue.TabIndex = 27;
            this.lblExpDateValue.Text = "[????]";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpDate.ForeColor = System.Drawing.Color.Silver;
            this.lblExpDate.Location = new System.Drawing.Point(455, 127);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(116, 19);
            this.lblExpDate.TabIndex = 26;
            this.lblExpDate.Text = "Expiration Date:";
            // 
            // lblOldLicenseIDValue
            // 
            this.lblOldLicenseIDValue.AutoSize = true;
            this.lblOldLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOldLicenseIDValue.ForeColor = System.Drawing.Color.White;
            this.lblOldLicenseIDValue.Location = new System.Drawing.Point(591, 94);
            this.lblOldLicenseIDValue.Name = "lblOldLicenseIDValue";
            this.lblOldLicenseIDValue.Size = new System.Drawing.Size(41, 19);
            this.lblOldLicenseIDValue.TabIndex = 24;
            this.lblOldLicenseIDValue.Text = "[????]";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.Silver;
            this.lblOldLicenseID.Location = new System.Drawing.Point(464, 94);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(107, 19);
            this.lblOldLicenseID.TabIndex = 23;
            this.lblOldLicenseID.Text = "Old License ID:";
            // 
            // lblRenewedLicenseIDValue
            // 
            this.lblRenewedLicenseIDValue.AutoSize = true;
            this.lblRenewedLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRenewedLicenseIDValue.ForeColor = System.Drawing.Color.White;
            this.lblRenewedLicenseIDValue.Location = new System.Drawing.Point(591, 61);
            this.lblRenewedLicenseIDValue.Name = "lblRenewedLicenseIDValue";
            this.lblRenewedLicenseIDValue.Size = new System.Drawing.Size(41, 19);
            this.lblRenewedLicenseIDValue.TabIndex = 22;
            this.lblRenewedLicenseIDValue.Text = "[????]";
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRenewedLicenseID.ForeColor = System.Drawing.Color.Silver;
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(427, 61);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(144, 19);
            this.lblRenewedLicenseID.TabIndex = 21;
            this.lblRenewedLicenseID.Text = "Renewed License ID:";
            // 
            // lblLicenseFeesValue
            // 
            this.lblLicenseFeesValue.AutoSize = true;
            this.lblLicenseFeesValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLicenseFeesValue.ForeColor = System.Drawing.Color.White;
            this.lblLicenseFeesValue.Location = new System.Drawing.Point(152, 196);
            this.lblLicenseFeesValue.Name = "lblLicenseFeesValue";
            this.lblLicenseFeesValue.Size = new System.Drawing.Size(41, 19);
            this.lblLicenseFeesValue.TabIndex = 7;
            this.lblLicenseFeesValue.Text = "[????]";
            // 
            // lblLicenseFeesTitle
            // 
            this.lblLicenseFeesTitle.AutoSize = true;
            this.lblLicenseFeesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenseFeesTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblLicenseFeesTitle.Location = new System.Drawing.Point(43, 193);
            this.lblLicenseFeesTitle.Name = "lblLicenseFeesTitle";
            this.lblLicenseFeesTitle.Size = new System.Drawing.Size(94, 19);
            this.lblLicenseFeesTitle.TabIndex = 21;
            this.lblLicenseFeesTitle.Text = "License Fees:";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIssueDate.ForeColor = System.Drawing.Color.White;
            this.lblIssueDate.Location = new System.Drawing.Point(152, 127);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(41, 19);
            this.lblIssueDate.TabIndex = 20;
            this.lblIssueDate.Text = "[????]";
            // 
            // lblIssueDateTitle
            // 
            this.lblIssueDateTitle.AutoSize = true;
            this.lblIssueDateTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssueDateTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblIssueDateTitle.Location = new System.Drawing.Point(57, 127);
            this.lblIssueDateTitle.Name = "lblIssueDateTitle";
            this.lblIssueDateTitle.Size = new System.Drawing.Size(80, 19);
            this.lblIssueDateTitle.TabIndex = 14;
            this.lblIssueDateTitle.Text = "Issue Date:";
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
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Licence App. Info";
            // 
            // lblAppIDTitle
            // 
            this.lblAppIDTitle.AutoSize = true;
            this.lblAppIDTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppIDTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblAppIDTitle.Location = new System.Drawing.Point(78, 61);
            this.lblAppIDTitle.Name = "lblAppIDTitle";
            this.lblAppIDTitle.Size = new System.Drawing.Size(59, 19);
            this.lblAppIDTitle.TabIndex = 1;
            this.lblAppIDTitle.Text = "App ID:";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppID.ForeColor = System.Drawing.Color.White;
            this.lblAppID.Location = new System.Drawing.Point(152, 61);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(41, 19);
            this.lblAppID.TabIndex = 2;
            this.lblAppID.Text = "[????]";
            // 
            // lblAppFeesTitle
            // 
            this.lblAppFeesTitle.AutoSize = true;
            this.lblAppFeesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppFeesTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblAppFeesTitle.Location = new System.Drawing.Point(14, 160);
            this.lblAppFeesTitle.Name = "lblAppFeesTitle";
            this.lblAppFeesTitle.Size = new System.Drawing.Size(123, 19);
            this.lblAppFeesTitle.TabIndex = 5;
            this.lblAppFeesTitle.Text = "Application Fees:";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppFees.ForeColor = System.Drawing.Color.White;
            this.lblAppFees.Location = new System.Drawing.Point(152, 158);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(41, 19);
            this.lblAppFees.TabIndex = 6;
            this.lblAppFees.Text = "[????]";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblDateTitle.Location = new System.Drawing.Point(93, 94);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(44, 19);
            this.lblDateTitle.TabIndex = 13;
            this.lblDateTitle.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(152, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "[????]";
            // 
            // lblCreatedTitle
            // 
            this.lblCreatedTitle.AutoSize = true;
            this.lblCreatedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblCreatedTitle.Location = new System.Drawing.Point(484, 160);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(591, 160);
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
            this.lbShowLicensesHistory.Location = new System.Drawing.Point(15, 882);
            this.lbShowLicensesHistory.Name = "lbShowLicensesHistory";
            this.lbShowLicensesHistory.Size = new System.Drawing.Size(142, 16);
            this.lbShowLicensesHistory.TabIndex = 5;
            this.lbShowLicensesHistory.TabStop = true;
            this.lbShowLicensesHistory.Text = "Show Licenses History";
            this.lbShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicensesHistory_LinkClicked);
            // 
            // lbShowNewLicenseInfo
            // 
            this.lbShowNewLicenseInfo.AutoSize = true;
            this.lbShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowNewLicenseInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.lbShowNewLicenseInfo.Location = new System.Drawing.Point(177, 882);
            this.lbShowNewLicenseInfo.Name = "lbShowNewLicenseInfo";
            this.lbShowNewLicenseInfo.Size = new System.Drawing.Size(144, 16);
            this.lbShowNewLicenseInfo.TabIndex = 6;
            this.lbShowNewLicenseInfo.TabStop = true;
            this.lbShowNewLicenseInfo.Text = "Show New License Info";
            this.lbShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowNewLicenseInfo_LinkClicked);
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
            this.btnSave.Location = new System.Drawing.Point(680, 895);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "💾  Renew";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(524, 895);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRenewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(814, 958);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbShowNewLicenseInfo);
            this.Controls.Add(this.lbShowLicensesHistory);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.MinimizeBox = false;
            this.Name = "frmRenewLocalDrivingLicenseApplication";
            this.ShowIcon = false;
            this.Text = "Renew License Application";
            this.Load += new System.EventHandler(this.frmRenewLocalDrivingLicenseApplication_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Local_Licenses.UserControls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppIDTitle;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label lblAppFeesTitle;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCreatedTitle;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblIssueDateTitle;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblLicenseFeesValue;
        private System.Windows.Forms.Label lblLicenseFeesTitle;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label lblRenewedLicenseIDValue;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblOldLicenseIDValue;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblExpDateValue;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.LinkLabel lbShowLicensesHistory;
        private System.Windows.Forms.LinkLabel lbShowNewLicenseInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}