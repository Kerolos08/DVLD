namespace DVLD.Tests.Test_Types
{
    partial class frmEditTestType
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTestTypeIDTitle = new System.Windows.Forms.Label();
            this.lblTestTypeIDValue = new System.Windows.Forms.Label();
            this.lblTitleT = new System.Windows.Forms.Label();
            this.txtTestTypeTitle = new System.Windows.Forms.TextBox();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblFeesTitle = new System.Windows.Forms.Label();
            this.txtFeesValue = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(166, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Update Test Type";
            // 
            // lblTestTypeIDTitle
            // 
            this.lblTestTypeIDTitle.AutoSize = true;
            this.lblTestTypeIDTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTestTypeIDTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTestTypeIDTitle.Location = new System.Drawing.Point(110, 113);
            this.lblTestTypeIDTitle.Name = "lblTestTypeIDTitle";
            this.lblTestTypeIDTitle.Size = new System.Drawing.Size(31, 21);
            this.lblTestTypeIDTitle.TabIndex = 3;
            this.lblTestTypeIDTitle.Text = "ID:";
            // 
            // lblTestTypeIDValue
            // 
            this.lblTestTypeIDValue.AutoSize = true;
            this.lblTestTypeIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTestTypeIDValue.ForeColor = System.Drawing.Color.Silver;
            this.lblTestTypeIDValue.Location = new System.Drawing.Point(168, 113);
            this.lblTestTypeIDValue.Name = "lblTestTypeIDValue";
            this.lblTestTypeIDValue.Size = new System.Drawing.Size(43, 21);
            this.lblTestTypeIDValue.TabIndex = 4;
            this.lblTestTypeIDValue.Text = "[???]";
            // 
            // lblTitleT
            // 
            this.lblTitleT.AutoSize = true;
            this.lblTitleT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleT.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleT.Location = new System.Drawing.Point(93, 163);
            this.lblTitleT.Name = "lblTitleT";
            this.lblTitleT.Size = new System.Drawing.Size(48, 21);
            this.lblTitleT.TabIndex = 5;
            this.lblTitleT.Text = "Title:";
            // 
            // txtTestTypeTitle
            // 
            this.txtTestTypeTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTestTypeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTestTypeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTestTypeTitle.Location = new System.Drawing.Point(172, 163);
            this.txtTestTypeTitle.Name = "txtTestTypeTitle";
            this.txtTestTypeTitle.Size = new System.Drawing.Size(301, 20);
            this.txtTestTypeTitle.TabIndex = 6;
            this.txtTestTypeTitle.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescriptionTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblDescriptionTitle.Location = new System.Drawing.Point(39, 213);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(102, 21);
            this.lblDescriptionTitle.TabIndex = 7;
            this.lblDescriptionTitle.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDescription.Location = new System.Drawing.Point(172, 213);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(301, 84);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblFeesTitle
            // 
            this.lblFeesTitle.AutoSize = true;
            this.lblFeesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFeesTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblFeesTitle.Location = new System.Drawing.Point(93, 327);
            this.lblFeesTitle.Name = "lblFeesTitle";
            this.lblFeesTitle.Size = new System.Drawing.Size(47, 21);
            this.lblFeesTitle.TabIndex = 9;
            this.lblFeesTitle.Text = "Fees:";
            // 
            // txtFeesValue
            // 
            this.txtFeesValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFeesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFeesValue.Location = new System.Drawing.Point(171, 327);
            this.txtFeesValue.Name = "txtFeesValue";
            this.txtFeesValue.Size = new System.Drawing.Size(301, 20);
            this.txtFeesValue.TabIndex = 10;
            this.txtFeesValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFeesValue_Validating);
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
            this.btnClose.Location = new System.Drawing.Point(260, 375);
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
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btnSave.Location = new System.Drawing.Point(410, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 40);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "✔  Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epErrorProvider
            // 
            this.epErrorProvider.ContainerControl = this;
            // 
            // frmEditTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(562, 440);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFeesValue);
            this.Controls.Add(this.lblFeesTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescriptionTitle);
            this.Controls.Add(this.txtTestTypeTitle);
            this.Controls.Add(this.lblTitleT);
            this.Controls.Add(this.lblTestTypeIDValue);
            this.Controls.Add(this.lblTestTypeIDTitle);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditTestType";
            this.Text = "Edit Test Type";
            this.Load += new System.EventHandler(this.frmEditTestType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTestTypeIDTitle;
        private System.Windows.Forms.Label lblTestTypeIDValue;
        private System.Windows.Forms.Label lblTitleT;
        private System.Windows.Forms.TextBox txtTestTypeTitle;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblFeesTitle;
        private System.Windows.Forms.TextBox txtFeesValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epErrorProvider;
    }
}