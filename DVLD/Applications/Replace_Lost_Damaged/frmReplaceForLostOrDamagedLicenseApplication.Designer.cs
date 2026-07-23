namespace DVLD.Applications.Replace_Lost_Damaged
{
    partial class frmReplaceForLostOrDamagedLicenseApplication
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblReplacedLicenseIDValue = new System.Windows.Forms.Label();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppIDTitle = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblAppFeesTitle = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCreatedTitle = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lbShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.UserControls.ctrlDriverLicenseInfoWithFilter();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblOldLicenseIDValue);
            this.pnlMain.Controls.Add(this.lblOldLicenseID);
            this.pnlMain.Controls.Add(this.lblReplacedLicenseIDValue);
            this.pnlMain.Controls.Add(this.lblReplacedLicenseID);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblAppIDTitle);
            this.pnlMain.Controls.Add(this.lblAppID);
            this.pnlMain.Controls.Add(this.lblAppFeesTitle);
            this.pnlMain.Controls.Add(this.lblAppFees);
            this.pnlMain.Controls.Add(this.lblDateTitle);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.lblCreatedTitle);
            this.pnlMain.Controls.Add(this.lblCreatedBy);
            this.pnlMain.Location = new System.Drawing.Point(13, 617);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(789, 168);
            this.pnlMain.TabIndex = 5;
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
            // lblReplacedLicenseIDValue
            // 
            this.lblReplacedLicenseIDValue.AutoSize = true;
            this.lblReplacedLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReplacedLicenseIDValue.ForeColor = System.Drawing.Color.White;
            this.lblReplacedLicenseIDValue.Location = new System.Drawing.Point(591, 61);
            this.lblReplacedLicenseIDValue.Name = "lblReplacedLicenseIDValue";
            this.lblReplacedLicenseIDValue.Size = new System.Drawing.Size(41, 19);
            this.lblReplacedLicenseIDValue.TabIndex = 22;
            this.lblReplacedLicenseIDValue.Text = "[????]";
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReplacedLicenseID.ForeColor = System.Drawing.Color.Silver;
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(427, 61);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(145, 19);
            this.lblReplacedLicenseID.TabIndex = 21;
            this.lblReplacedLicenseID.Text = "Replaced License ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Size = new System.Drawing.Size(360, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "App. Info for licnese Replacement";
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
            this.lblAppFeesTitle.Location = new System.Drawing.Point(14, 129);
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
            this.lblAppFees.Location = new System.Drawing.Point(152, 127);
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
            this.lblDateTitle.Location = new System.Drawing.Point(93, 95);
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
            this.lblDate.Location = new System.Drawing.Point(152, 94);
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
            this.lblCreatedTitle.Location = new System.Drawing.Point(484, 127);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(591, 127);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(41, 19);
            this.lblCreatedBy.TabIndex = 18;
            this.lblCreatedBy.Text = "[????]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbLost);
            this.panel1.Controls.Add(this.rbDamaged);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 78);
            this.panel1.TabIndex = 6;
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLost.ForeColor = System.Drawing.Color.Silver;
            this.rbLost.Location = new System.Drawing.Point(550, 30);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(119, 23);
            this.rbLost.TabIndex = 3;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost License";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamaged.ForeColor = System.Drawing.Color.Silver;
            this.rbDamaged.Location = new System.Drawing.Point(266, 30);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(158, 23);
            this.rbDamaged.TabIndex = 2;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "Damaged License";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Size = new System.Drawing.Size(198, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replacement For:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Size = new System.Drawing.Size(435, 32);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Replace For Lost/Damaged Licenses";
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
            this.btnSave.Location = new System.Drawing.Point(680, 806);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "💾  Replace";
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
            this.btnClose.Location = new System.Drawing.Point(535, 806);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbShowNewLicenseInfo
            // 
            this.lbShowNewLicenseInfo.AutoSize = true;
            this.lbShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowNewLicenseInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.lbShowNewLicenseInfo.Location = new System.Drawing.Point(185, 797);
            this.lbShowNewLicenseInfo.Name = "lbShowNewLicenseInfo";
            this.lbShowNewLicenseInfo.Size = new System.Drawing.Size(144, 16);
            this.lbShowNewLicenseInfo.TabIndex = 31;
            this.lbShowNewLicenseInfo.TabStop = true;
            this.lbShowNewLicenseInfo.Text = "Show New License Info";
            this.lbShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowNewLicenseInfo_LinkClicked);
            // 
            // lbShowLicensesHistory
            // 
            this.lbShowLicensesHistory.AutoSize = true;
            this.lbShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicensesHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.lbShowLicensesHistory.Location = new System.Drawing.Point(15, 797);
            this.lbShowLicensesHistory.Name = "lbShowLicensesHistory";
            this.lbShowLicensesHistory.Size = new System.Drawing.Size(142, 16);
            this.lbShowLicensesHistory.TabIndex = 32;
            this.lbShowLicensesHistory.TabStop = true;
            this.lbShowLicensesHistory.Text = "Show Licenses History";
            this.lbShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicensesHistory_LinkClicked);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 55);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(814, 469);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            // 
            // frmReplaceForLostOrDamagedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(815, 870);
            this.Controls.Add(this.lbShowLicensesHistory);
            this.Controls.Add(this.lbShowNewLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReplaceForLostOrDamagedLicenseApplication";
            this.Text = "Replace Lost/Damaged";
            this.Load += new System.EventHandler(this.frmReplaceForLostOrDamagedLicenseApplication_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Local_Licenses.UserControls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblOldLicenseIDValue;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblReplacedLicenseIDValue;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppIDTitle;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label lblAppFeesTitle;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCreatedTitle;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lbShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel lbShowLicensesHistory;
    }
}