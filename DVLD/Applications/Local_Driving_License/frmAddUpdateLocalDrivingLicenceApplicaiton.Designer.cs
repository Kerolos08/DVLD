namespace DVLD.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicenceApplicaiton
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcAppInfo = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilters1 = new DVLD.People.UserControls.ctrlPersonCardWithFilters();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.lblCreatedByUserValue = new System.Windows.Forms.Label();
            this.lblApplicationFeesValue = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblApplicationDateValue = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblDLApplicationValue = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.tcAppInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(934, 58);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(421, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "New Local Driving license Application";
            // 
            // tcAppInfo
            // 
            this.tcAppInfo.Controls.Add(this.tpPersonalInfo);
            this.tcAppInfo.Controls.Add(this.tpApplicationInfo);
            this.tcAppInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAppInfo.Location = new System.Drawing.Point(26, 79);
            this.tcAppInfo.Name = "tcAppInfo";
            this.tcAppInfo.SelectedIndex = 0;
            this.tcAppInfo.Size = new System.Drawing.Size(883, 503);
            this.tcAppInfo.TabIndex = 6;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilters1);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 26);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(875, 473);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnNext.Location = new System.Drawing.Point(735, 412);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilters1
            // 
            this.ctrlPersonCardWithFilters1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlPersonCardWithFilters1.FilterEnabled = true;
            this.ctrlPersonCardWithFilters1.Location = new System.Drawing.Point(19, 6);
            this.ctrlPersonCardWithFilters1.Name = "ctrlPersonCardWithFilters1";
            this.ctrlPersonCardWithFilters1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilters1.Size = new System.Drawing.Size(840, 400);
            this.ctrlPersonCardWithFilters1.TabIndex = 1;
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpApplicationInfo.Controls.Add(this.lblCreatedByUserValue);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationFeesValue);
            this.tpApplicationInfo.Controls.Add(this.cmbClass);
            this.tpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationDateValue);
            this.tpApplicationInfo.Controls.Add(this.btnBack);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.tpApplicationInfo.Controls.Add(this.lblLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.lblDLApplicationValue);
            this.tpApplicationInfo.Controls.Add(this.lblAppID);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 26);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(875, 473);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            // 
            // lblCreatedByUserValue
            // 
            this.lblCreatedByUserValue.AutoSize = true;
            this.lblCreatedByUserValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUserValue.ForeColor = System.Drawing.Color.White;
            this.lblCreatedByUserValue.Location = new System.Drawing.Point(246, 237);
            this.lblCreatedByUserValue.Name = "lblCreatedByUserValue";
            this.lblCreatedByUserValue.Size = new System.Drawing.Size(33, 17);
            this.lblCreatedByUserValue.TabIndex = 37;
            this.lblCreatedByUserValue.Text = "N/A";
            // 
            // lblApplicationFeesValue
            // 
            this.lblApplicationFeesValue.AutoSize = true;
            this.lblApplicationFeesValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesValue.ForeColor = System.Drawing.Color.White;
            this.lblApplicationFeesValue.Location = new System.Drawing.Point(246, 192);
            this.lblApplicationFeesValue.Name = "lblApplicationFeesValue";
            this.lblApplicationFeesValue.Size = new System.Drawing.Size(33, 17);
            this.lblApplicationFeesValue.TabIndex = 36;
            this.lblApplicationFeesValue.Text = "N/A";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbClass.Location = new System.Drawing.Point(246, 143);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(224, 25);
            this.cmbClass.TabIndex = 35;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.White;
            this.lblCreatedByUser.Location = new System.Drawing.Point(135, 237);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(78, 17);
            this.lblCreatedByUser.TabIndex = 34;
            this.lblCreatedByUser.Text = "Created By:";
            // 
            // lblApplicationDateValue
            // 
            this.lblApplicationDateValue.AutoSize = true;
            this.lblApplicationDateValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateValue.ForeColor = System.Drawing.Color.White;
            this.lblApplicationDateValue.Location = new System.Drawing.Point(246, 102);
            this.lblApplicationDateValue.Name = "lblApplicationDateValue";
            this.lblApplicationDateValue.Size = new System.Drawing.Size(33, 17);
            this.lblApplicationDateValue.TabIndex = 33;
            this.lblApplicationDateValue.Text = "N/A";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBack.Location = new System.Drawing.Point(735, 412);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.White;
            this.lblApplicationFees.Location = new System.Drawing.Point(99, 192);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(114, 17);
            this.lblApplicationFees.TabIndex = 4;
            this.lblApplicationFees.Text = "Application Fees:";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClass.ForeColor = System.Drawing.Color.White;
            this.lblLicenseClass.Location = new System.Drawing.Point(121, 147);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(92, 17);
            this.lblLicenseClass.TabIndex = 3;
            this.lblLicenseClass.Text = "License Class:";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.White;
            this.lblApplicationDate.Location = new System.Drawing.Point(97, 102);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(116, 17);
            this.lblApplicationDate.TabIndex = 2;
            this.lblApplicationDate.Text = "Application Date:";
            // 
            // lblDLApplicationValue
            // 
            this.lblDLApplicationValue.AutoSize = true;
            this.lblDLApplicationValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLApplicationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblDLApplicationValue.Location = new System.Drawing.Point(246, 55);
            this.lblDLApplicationValue.Name = "lblDLApplicationValue";
            this.lblDLApplicationValue.Size = new System.Drawing.Size(39, 20);
            this.lblDLApplicationValue.TabIndex = 1;
            this.lblDLApplicationValue.Text = "N/A";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.ForeColor = System.Drawing.Color.White;
            this.lblAppID.Location = new System.Drawing.Point(91, 57);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(122, 17);
            this.lblAppID.TabIndex = 0;
            this.lblAppID.Text = "DL Application ID:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.Location = new System.Drawing.Point(636, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "✕  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btnSave.Location = new System.Drawing.Point(779, 599);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "✔  Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateLocalDrivingLicenceApplicaiton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcAppInfo);
            this.Controls.Add(this.pnlHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateLocalDrivingLicenceApplicaiton";
            this.Text = "Add/Edit Application";
            this.Activated += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenceApplicaiton_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenceApplicaiton_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tcAppInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcAppInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.Button btnNext;
        private People.UserControls.ctrlPersonCardWithFilters ctrlPersonCardWithFilters1;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblDLApplicationValue;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblApplicationDateValue;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblCreatedByUserValue;
        private System.Windows.Forms.Label lblApplicationFeesValue;
        private System.Windows.Forms.ComboBox cmbClass;
    }
}