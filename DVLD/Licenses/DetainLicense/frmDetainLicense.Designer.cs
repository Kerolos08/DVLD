namespace DVLD.Licenses.DetainLicense
{
    partial class frmDetainLicense
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLicenseIDValue = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblIDetainDateTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetainIDTitle = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblCreatedTitle = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lbShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.Licenses.Local_Licenses.UserControls.ctrlDriverLicenseInfoWithFilter();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.lblFineFeesTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.txtFineFees);
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
            this.pnlMain.Size = new System.Drawing.Size(789, 184);
            this.pnlMain.TabIndex = 6;
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
            this.lblDetainDate.Location = new System.Drawing.Point(170, 99);
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
            this.lblIDetainDateTitle.Location = new System.Drawing.Point(53, 99);
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
            this.lblDetainIDTitle.Location = new System.Drawing.Point(70, 63);
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
            // lblCreatedTitle
            // 
            this.lblCreatedTitle.AutoSize = true;
            this.lblCreatedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreatedTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblCreatedTitle.Location = new System.Drawing.Point(454, 99);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(561, 99);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(41, 19);
            this.lblCreatedBy.TabIndex = 18;
            this.lblCreatedBy.Text = "[????]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 32);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Detain License";
            // 
            // lbShowLicensesHistory
            // 
            this.lbShowLicensesHistory.AutoSize = true;
            this.lbShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicensesHistory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.lbShowLicensesHistory.Location = new System.Drawing.Point(15, 743);
            this.lbShowLicensesHistory.Name = "lbShowLicensesHistory";
            this.lbShowLicensesHistory.Size = new System.Drawing.Size(142, 16);
            this.lbShowLicensesHistory.TabIndex = 34;
            this.lbShowLicensesHistory.TabStop = true;
            this.lbShowLicensesHistory.Text = "Show Licenses History";
            this.lbShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbShowLicensesHistory_LinkClicked);
            // 
            // lbShowLicenseInfo
            // 
            this.lbShowLicenseInfo.AutoSize = true;
            this.lbShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowLicenseInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.lbShowLicenseInfo.Location = new System.Drawing.Point(166, 743);
            this.lbShowLicenseInfo.Name = "lbShowLicenseInfo";
            this.lbShowLicenseInfo.Size = new System.Drawing.Size(114, 16);
            this.lbShowLicenseInfo.TabIndex = 35;
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
            this.btnClose.Location = new System.Drawing.Point(523, 761);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 36;
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
            this.btnSave.Location = new System.Drawing.Point(679, 761);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "💾  Detain";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epErrorProvider
            // 
            this.epErrorProvider.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 63);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(814, 469);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            // 
            // txtFineFees
            // 
            this.txtFineFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFineFees.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFineFees.ForeColor = System.Drawing.Color.Silver;
            this.txtFineFees.Location = new System.Drawing.Point(156, 135);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(100, 26);
            this.txtFineFees.TabIndex = 25;
            this.txtFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineFees_Validating);
            // 
            // lblFineFeesTitle
            // 
            this.lblFineFeesTitle.AutoSize = true;
            this.lblFineFeesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFineFeesTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblFineFeesTitle.Location = new System.Drawing.Point(71, 139);
            this.lblFineFeesTitle.Name = "lblFineFeesTitle";
            this.lblFineFeesTitle.Size = new System.Drawing.Size(73, 19);
            this.lblFineFeesTitle.TabIndex = 5;
            this.lblFineFeesTitle.Text = "Fine Fees:";
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(813, 829);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbShowLicenseInfo);
            this.Controls.Add(this.lbShowLicensesHistory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainLicense";
            this.Text = "Detain A License";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLicenseIDValue;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblIDetainDateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetainIDTitle;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblCreatedTitle;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lbShowLicensesHistory;
        private System.Windows.Forms.LinkLabel lbShowLicenseInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epErrorProvider;
        private Local_Licenses.UserControls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.Label lblFineFeesTitle;
    }
}