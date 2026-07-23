namespace DVLD.Login
{
    partial class frmLoginScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.epErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Controls.Add(this.lblLoginTitle);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.chkRememberMe);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(452, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(445, 576);
            this.pnlRight.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::DVLD.Properties.Resources.closeBlack32;
            this.btnClose.Location = new System.Drawing.Point(384, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(80, 154);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(267, 32);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Login to your account";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblUsername.Location = new System.Drawing.Point(67, 249);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(147, 247);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 29);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblPassword.Location = new System.Drawing.Point(67, 306);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(147, 304);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(200, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.chkRememberMe.Location = new System.Drawing.Point(147, 352);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(104, 19);
            this.chkRememberMe.TabIndex = 5;
            this.chkRememberMe.Text = "Remember Me";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(215, 401);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 38);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "🔑  Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Controls.Add(this.picImage);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(452, 576);
            this.pnlLeft.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picImage.Image = global::DVLD.Properties.Resources.ChatGPT_Image_Jun_9__2026__04_35_32_AM;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(452, 576);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // epErrorProvider
            // 
            this.epErrorProvider.ContainerControl = this;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 576);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD - Login";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider epErrorProvider;
    }
}