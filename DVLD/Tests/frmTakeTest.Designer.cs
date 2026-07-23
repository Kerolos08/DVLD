namespace DVLD.Tests
{
    partial class frmTakeTest
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
            this.ctrlSecheduledTest1 = new DVLD.Tests.UserControls.ctrlSecheduledTest();
            this.lblResult = new System.Windows.Forms.Label();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSecheduledTest1
            // 
            this.ctrlSecheduledTest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlSecheduledTest1.Location = new System.Drawing.Point(2, 12);
            this.ctrlSecheduledTest1.Name = "ctrlSecheduledTest1";
            this.ctrlSecheduledTest1.Size = new System.Drawing.Size(537, 500);
            this.ctrlSecheduledTest1.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Silver;
            this.lblResult.Location = new System.Drawing.Point(51, 518);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 19);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "Result:";
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rbPass.ForeColor = System.Drawing.Color.Silver;
            this.rbPass.Location = new System.Drawing.Point(135, 515);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(56, 23);
            this.rbPass.TabIndex = 14;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rbFail.ForeColor = System.Drawing.Color.Silver;
            this.rbFail.Location = new System.Drawing.Point(241, 515);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(50, 23);
            this.rbFail.TabIndex = 15;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.ForeColor = System.Drawing.Color.Silver;
            this.txtNotes.Location = new System.Drawing.Point(111, 567);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(407, 110);
            this.txtNotes.TabIndex = 16;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.Color.Silver;
            this.lblNotes.Location = new System.Drawing.Point(51, 567);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(52, 19);
            this.lblNotes.TabIndex = 17;
            this.lblNotes.Text = "Notes:";
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
            this.btnClose.Location = new System.Drawing.Point(239, 708);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 18;
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
            this.btnSave.Location = new System.Drawing.Point(396, 708);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "💾  Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(540, 769);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.ctrlSecheduledTest1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTakeTest";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ctrlSecheduledTest ctrlSecheduledTest1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}