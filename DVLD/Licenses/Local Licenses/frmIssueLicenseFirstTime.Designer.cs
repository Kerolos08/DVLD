namespace DVLD.Licenses.Local_Licenses
{
    partial class frmIssueLicenseFirstTime
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
            this.ctrlLocalDrivingLicenseAppInfo1 = new DVLD.Applications.Local_Driving_License.UserControl.ctrlLocalDrivingLicenseAppInfo();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseAppInfo1
            // 
            this.ctrlLocalDrivingLicenseAppInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlLocalDrivingLicenseAppInfo1.Location = new System.Drawing.Point(0, 61);
            this.ctrlLocalDrivingLicenseAppInfo1.Name = "ctrlLocalDrivingLicenseAppInfo1";
            this.ctrlLocalDrivingLicenseAppInfo1.Size = new System.Drawing.Size(815, 459);
            this.ctrlLocalDrivingLicenseAppInfo1.TabIndex = 0;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.ForeColor = System.Drawing.Color.Silver;
            this.txtNotes.Location = new System.Drawing.Point(130, 535);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(661, 151);
            this.txtNotes.TabIndex = 17;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.Silver;
            this.lblNotes.Location = new System.Drawing.Point(72, 535);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(52, 19);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes:";
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
            this.btnSave.Location = new System.Drawing.Point(669, 711);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "💾  Issue";
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
            this.btnClose.Location = new System.Drawing.Point(516, 711);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "✕  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(214, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 32);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Issue License For The First Time";
            // 
            // frmIssueLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(815, 768);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.ctrlLocalDrivingLicenseAppInfo1);
            this.Name = "frmIssueLicenseFirstTime";
            this.Text = "Issue License First Time";
            this.Load += new System.EventHandler(this.frmIssueLicenseFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Local_Driving_License.UserControl.ctrlLocalDrivingLicenseAppInfo ctrlLocalDrivingLicenseAppInfo1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}