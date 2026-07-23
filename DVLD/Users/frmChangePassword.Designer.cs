namespace DVLD.Users
{
    partial class frmChangePassword
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPasswordTitle = new System.Windows.Forms.Label();
            this.lblConfirmPasswordTitle = new System.Windows.Forms.Label();
            this.lblNewPasswordTitle = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlUserCard1 = new DVLD.Users.UserControls.ctrlUserCard();
            this.epErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(255, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Size = new System.Drawing.Size(286, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Change User Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.White;
            this.txtCurrentPassword.Location = new System.Drawing.Point(195, 513);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(200, 22);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // lblCurrentPasswordTitle
            // 
            this.lblCurrentPasswordTitle.AutoSize = true;
            this.lblCurrentPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPasswordTitle.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPasswordTitle.Location = new System.Drawing.Point(47, 516);
            this.lblCurrentPasswordTitle.Name = "lblCurrentPasswordTitle";
            this.lblCurrentPasswordTitle.Size = new System.Drawing.Size(120, 17);
            this.lblCurrentPasswordTitle.TabIndex = 6;
            this.lblCurrentPasswordTitle.Text = "Current Password:";
            // 
            // lblConfirmPasswordTitle
            // 
            this.lblConfirmPasswordTitle.AutoSize = true;
            this.lblConfirmPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordTitle.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPasswordTitle.Location = new System.Drawing.Point(43, 618);
            this.lblConfirmPasswordTitle.Name = "lblConfirmPasswordTitle";
            this.lblConfirmPasswordTitle.Size = new System.Drawing.Size(124, 17);
            this.lblConfirmPasswordTitle.TabIndex = 8;
            this.lblConfirmPasswordTitle.Text = "Confirm Password:";
            // 
            // lblNewPasswordTitle
            // 
            this.lblNewPasswordTitle.AutoSize = true;
            this.lblNewPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordTitle.ForeColor = System.Drawing.Color.White;
            this.lblNewPasswordTitle.Location = new System.Drawing.Point(47, 567);
            this.lblNewPasswordTitle.Name = "lblNewPasswordTitle";
            this.lblNewPasswordTitle.Size = new System.Drawing.Size(101, 17);
            this.lblNewPasswordTitle.TabIndex = 9;
            this.lblNewPasswordTitle.Text = "New Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(195, 615);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 22);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtNewPassword.Location = new System.Drawing.Point(195, 564);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(200, 22);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
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
            this.btnSave.Location = new System.Drawing.Point(655, 664);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "✔  Save";
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
            this.btnClose.Location = new System.Drawing.Point(512, 664);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "✕  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlUserCard1.Location = new System.Drawing.Point(3, 70);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(815, 430);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // epErrorProvider
            // 
            this.epErrorProvider.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(819, 733);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblNewPasswordTitle);
            this.Controls.Add(this.lblConfirmPasswordTitle);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblCurrentPasswordTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlUserCard1);
            this.MaximizeBox = false;
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPasswordTitle;
        private System.Windows.Forms.Label lblConfirmPasswordTitle;
        private System.Windows.Forms.Label lblNewPasswordTitle;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider epErrorProvider;
    }
}