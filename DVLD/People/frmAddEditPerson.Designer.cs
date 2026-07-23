namespace DVLD
{
    partial class frmAddEditPerson
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblPersonIDValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.picPersonImage = new System.Windows.Forms.PictureBox();
            this.epErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdSelectPersonImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(215, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(583, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Person";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblPersonID.Location = new System.Drawing.Point(40, 66);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(68, 17);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "Person ID";
            // 
            // lblPersonIDValue
            // 
            this.lblPersonIDValue.AutoSize = true;
            this.lblPersonIDValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonIDValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPersonIDValue.Location = new System.Drawing.Point(114, 68);
            this.lblPersonIDValue.Name = "lblPersonIDValue";
            this.lblPersonIDValue.Size = new System.Drawing.Size(29, 15);
            this.lblPersonIDValue.TabIndex = 2;
            this.lblPersonIDValue.Text = "N/A";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblName.Location = new System.Drawing.Point(52, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblFirst.Location = new System.Drawing.Point(195, 14);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(29, 15);
            this.lblFirst.TabIndex = 1;
            this.lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSecond.Location = new System.Drawing.Point(405, 14);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(46, 15);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "Second";
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblThird.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblThird.Location = new System.Drawing.Point(630, 14);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(34, 15);
            this.lblThird.TabIndex = 3;
            this.lblThird.Text = "Third";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblLast.Location = new System.Drawing.Point(852, 14);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(28, 15);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Last";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFirstName.Location = new System.Drawing.Point(114, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(191, 25);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtSecondName
            // 
            this.txtSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSecondName.Location = new System.Drawing.Point(333, 42);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(191, 25);
            this.txtSecondName.TabIndex = 6;
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtThirdName
            // 
            this.txtThirdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtThirdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThirdName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThirdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtThirdName.Location = new System.Drawing.Point(552, 42);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(191, 25);
            this.txtThirdName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtLastName.Location = new System.Drawing.Point(771, 42);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(191, 25);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblNationalNo.Location = new System.Drawing.Point(13, 100);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(83, 17);
            this.lblNationalNo.TabIndex = 9;
            this.lblNationalNo.Text = "National No";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNationalNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNationalNo.Location = new System.Drawing.Point(114, 100);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(224, 25);
            this.txtNationalNo.TabIndex = 10;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblDateOfBirth.Location = new System.Drawing.Point(394, 100);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(90, 17);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(501, 100);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2008, 12, 12, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1951, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(224, 25);
            this.dtpDateOfBirth.TabIndex = 12;
            this.dtpDateOfBirth.Value = new System.DateTime(2008, 12, 12, 0, 0, 0, 0);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblGender.Location = new System.Drawing.Point(44, 162);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 17);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbMale.Location = new System.Drawing.Point(114, 162);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(55, 21);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Tag = "0";
            this.rbMale.Text = "Male";
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rbFemale.Location = new System.Drawing.Point(271, 162);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(67, 21);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.Tag = "1";
            this.rbFemale.Text = "Female";
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblPhone.Location = new System.Drawing.Point(437, 158);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 17);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPhone.Location = new System.Drawing.Point(501, 158);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(224, 25);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblEmail.Location = new System.Drawing.Point(54, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmail.Location = new System.Drawing.Point(114, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 25);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblCountry.Location = new System.Drawing.Point(426, 216);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(58, 17);
            this.lblCountry.TabIndex = 20;
            this.lblCountry.Text = "Country";
            // 
            // cmbCountry
            // 
            this.cmbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCountry.Location = new System.Drawing.Point(501, 216);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(224, 25);
            this.cmbCountry.TabIndex = 21;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblAddress.Location = new System.Drawing.Point(39, 274);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 17);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtAddress.Location = new System.Drawing.Point(114, 274);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(611, 73);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // llSetImage
            // 
            this.llSetImage.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.llSetImage.Location = new System.Drawing.Point(903, 309);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(64, 15);
            this.llSetImage.TabIndex = 25;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
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
            this.btnSave.Location = new System.Drawing.Point(621, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "💾  Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(301, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "✕  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblPersonID);
            this.pnlHeader.Controls.Add(this.lblPersonIDValue);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1013, 101);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlMain.Controls.Add(this.llRemoveImage);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.lblFirst);
            this.pnlMain.Controls.Add(this.lblSecond);
            this.pnlMain.Controls.Add(this.lblThird);
            this.pnlMain.Controls.Add(this.lblLast);
            this.pnlMain.Controls.Add(this.txtFirstName);
            this.pnlMain.Controls.Add(this.txtSecondName);
            this.pnlMain.Controls.Add(this.txtThirdName);
            this.pnlMain.Controls.Add(this.txtLastName);
            this.pnlMain.Controls.Add(this.lblNationalNo);
            this.pnlMain.Controls.Add(this.txtNationalNo);
            this.pnlMain.Controls.Add(this.lblDateOfBirth);
            this.pnlMain.Controls.Add(this.dtpDateOfBirth);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.rbMale);
            this.pnlMain.Controls.Add(this.rbFemale);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.lblCountry);
            this.pnlMain.Controls.Add(this.cmbCountry);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Controls.Add(this.picPersonImage);
            this.pnlMain.Controls.Add(this.llSetImage);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 101);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(17, 13, 17, 13);
            this.pnlMain.Size = new System.Drawing.Size(1013, 455);
            this.pnlMain.TabIndex = 0;
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemoveImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.llRemoveImage.Location = new System.Drawing.Point(903, 332);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(54, 15);
            this.llRemoveImage.TabIndex = 28;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // picPersonImage
            // 
            this.picPersonImage.BackColor = System.Drawing.Color.Transparent;
            this.picPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPersonImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPersonImage.Image = global::DVLD.Properties.Resources.man;
            this.picPersonImage.InitialImage = null;
            this.picPersonImage.Location = new System.Drawing.Point(771, 89);
            this.picPersonImage.Name = "picPersonImage";
            this.picPersonImage.Size = new System.Drawing.Size(191, 206);
            this.picPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPersonImage.TabIndex = 24;
            this.picPersonImage.TabStop = false;
            // 
            // epErrorProvider
            // 
            this.epErrorProvider.ContainerControl = this;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1013, 556);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person Info.";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblPersonIDValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.PictureBox picPersonImage;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider epErrorProvider;
        private System.Windows.Forms.OpenFileDialog ofdSelectPersonImage;
        private System.Windows.Forms.LinkLabel llRemoveImage;
    }
}