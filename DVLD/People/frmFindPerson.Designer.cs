namespace DVLD.People
{
    partial class frmFindPerson
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlpersonCardWithFilters1 = new DVLD.People.UserControls.ctrlPersonCardWithFilters();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(350, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Find Person";
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
            this.btnClose.Location = new System.Drawing.Point(697, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 40);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "✕  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlpersonCardWithFilters1
            // 
            this.ctrlpersonCardWithFilters1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlpersonCardWithFilters1.FilterEnabled = true;
            this.ctrlpersonCardWithFilters1.Location = new System.Drawing.Point(17, 70);
            this.ctrlpersonCardWithFilters1.Name = "ctrlpersonCardWithFilters1";
            this.ctrlpersonCardWithFilters1.ShowAddPerson = true;
            this.ctrlpersonCardWithFilters1.Size = new System.Drawing.Size(814, 397);
            this.ctrlpersonCardWithFilters1.TabIndex = 5;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(849, 568);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlpersonCardWithFilters1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFindPerson";
            this.Text = "frmFIndPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private UserControls.ctrlPersonCardWithFilters ctrlpersonCardWithFilters1;
        private System.Windows.Forms.Button btnClose;
    }
}