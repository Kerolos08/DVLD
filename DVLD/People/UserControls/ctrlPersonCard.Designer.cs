namespace DVLD.People.UserControls
{
    partial class ctrlPersonCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPersonIDTitle = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNationalNoTitle = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblGenderTitle = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDateOfBirthTitle = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountryTitle = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.llEditPersonInfo = new System.Windows.Forms.LinkLabel();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblPersonIDTitle);
            this.pnlMain.Controls.Add(this.lblPersonID);
            this.pnlMain.Controls.Add(this.lblNameTitle);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.lblNationalNoTitle);
            this.pnlMain.Controls.Add(this.lblNationalNo);
            this.pnlMain.Controls.Add(this.lblGenderTitle);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblEmailTitle);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblAddressTitle);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.lblDateOfBirthTitle);
            this.pnlMain.Controls.Add(this.lblDateOfBirth);
            this.pnlMain.Controls.Add(this.lblPhoneTitle);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.lblCountryTitle);
            this.pnlMain.Controls.Add(this.lblCountry);
            this.pnlMain.Controls.Add(this.llEditPersonInfo);
            this.pnlMain.Controls.Add(this.pbPersonImage);
            this.pnlMain.Location = new System.Drawing.Point(13, 17);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(789, 261);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Size = new System.Drawing.Size(218, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Person Information";
            // 
            // lblPersonIDTitle
            // 
            this.lblPersonIDTitle.AutoSize = true;
            this.lblPersonIDTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPersonIDTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblPersonIDTitle.Location = new System.Drawing.Point(26, 52);
            this.lblPersonIDTitle.Name = "lblPersonIDTitle";
            this.lblPersonIDTitle.Size = new System.Drawing.Size(77, 19);
            this.lblPersonIDTitle.TabIndex = 1;
            this.lblPersonIDTitle.Text = "Person ID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(137, 52);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(41, 19);
            this.lblPersonID.TabIndex = 2;
            this.lblPersonID.Text = "[????]";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNameTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblNameTitle.Location = new System.Drawing.Point(26, 82);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(53, 19);
            this.lblNameTitle.TabIndex = 3;
            this.lblNameTitle.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(137, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "[????]";
            // 
            // lblNationalNoTitle
            // 
            this.lblNationalNoTitle.AutoSize = true;
            this.lblNationalNoTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNationalNoTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblNationalNoTitle.Location = new System.Drawing.Point(26, 113);
            this.lblNationalNoTitle.Name = "lblNationalNoTitle";
            this.lblNationalNoTitle.Size = new System.Drawing.Size(94, 19);
            this.lblNationalNoTitle.TabIndex = 5;
            this.lblNationalNoTitle.Text = "National No:";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNationalNo.ForeColor = System.Drawing.Color.White;
            this.lblNationalNo.Location = new System.Drawing.Point(137, 113);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(41, 19);
            this.lblNationalNo.TabIndex = 6;
            this.lblNationalNo.Text = "[????]";
            // 
            // lblGenderTitle
            // 
            this.lblGenderTitle.AutoSize = true;
            this.lblGenderTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenderTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblGenderTitle.Location = new System.Drawing.Point(26, 143);
            this.lblGenderTitle.Name = "lblGenderTitle";
            this.lblGenderTitle.Size = new System.Drawing.Size(63, 19);
            this.lblGenderTitle.TabIndex = 7;
            this.lblGenderTitle.Text = "Gender:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(137, 143);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 19);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "[????]";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblEmailTitle.Location = new System.Drawing.Point(26, 173);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(49, 19);
            this.lblEmailTitle.TabIndex = 9;
            this.lblEmailTitle.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(137, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "[????]";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddressTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblAddressTitle.Location = new System.Drawing.Point(26, 204);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(67, 19);
            this.lblAddressTitle.TabIndex = 11;
            this.lblAddressTitle.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(137, 204);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 19);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "[????]";
            // 
            // lblDateOfBirthTitle
            // 
            this.lblDateOfBirthTitle.AutoSize = true;
            this.lblDateOfBirthTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirthTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblDateOfBirthTitle.Location = new System.Drawing.Point(378, 125);
            this.lblDateOfBirthTitle.Name = "lblDateOfBirthTitle";
            this.lblDateOfBirthTitle.Size = new System.Drawing.Size(100, 19);
            this.lblDateOfBirthTitle.TabIndex = 13;
            this.lblDateOfBirthTitle.Text = "Date Of Birth:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(498, 125);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(41, 19);
            this.lblDateOfBirth.TabIndex = 14;
            this.lblDateOfBirth.Text = "[????]";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblPhoneTitle.Location = new System.Drawing.Point(378, 156);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(55, 19);
            this.lblPhoneTitle.TabIndex = 15;
            this.lblPhoneTitle.Text = "Phone:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(498, 156);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 19);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "[????]";
            // 
            // lblCountryTitle
            // 
            this.lblCountryTitle.AutoSize = true;
            this.lblCountryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountryTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblCountryTitle.Location = new System.Drawing.Point(378, 186);
            this.lblCountryTitle.Name = "lblCountryTitle";
            this.lblCountryTitle.Size = new System.Drawing.Size(67, 19);
            this.lblCountryTitle.TabIndex = 17;
            this.lblCountryTitle.Text = "Country:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(498, 186);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(41, 19);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "[????]";
            // 
            // llEditPersonInfo
            // 
            this.llEditPersonInfo.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.llEditPersonInfo.AutoSize = true;
            this.llEditPersonInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.llEditPersonInfo.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.llEditPersonInfo.Location = new System.Drawing.Point(650, 222);
            this.llEditPersonInfo.Name = "llEditPersonInfo";
            this.llEditPersonInfo.Size = new System.Drawing.Size(105, 19);
            this.llEditPersonInfo.TabIndex = 19;
            this.llEditPersonInfo.TabStop = true;
            this.llEditPersonInfo.Text = "Edit Person Info";
            this.llEditPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEditPersonInfo_LinkClicked);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.man;
            this.pbPersonImage.Location = new System.Drawing.Point(609, 52);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(146, 148);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 20;
            this.pbPersonImage.TabStop = false;
            // 
            // ctrlPersonCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "ctrlPersonCard";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.Size = new System.Drawing.Size(815, 300);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblPersonIDTitle;
        private System.Windows.Forms.Label lblPersonID;

        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.Label lblNationalNoTitle;
        private System.Windows.Forms.Label lblNationalNo;

        private System.Windows.Forms.Label lblGenderTitle;
        private System.Windows.Forms.Label lblGender;

        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Label lblAddressTitle;
        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.Label lblDateOfBirthTitle;
        private System.Windows.Forms.Label lblDateOfBirth;

        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.Label lblCountryTitle;
        private System.Windows.Forms.Label lblCountry;

        private System.Windows.Forms.LinkLabel llEditPersonInfo;

        private System.Windows.Forms.PictureBox pbPersonImage;
    }
}