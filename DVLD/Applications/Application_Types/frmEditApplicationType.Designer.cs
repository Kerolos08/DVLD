namespace DVLD.Applications.Application_Types
{
    partial class frmEditApplicationType
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
            this.lblApplicationIDTitle = new System.Windows.Forms.Label();
            this.lblApplicationIDValue = new System.Windows.Forms.Label();
            this.lblTitleT = new System.Windows.Forms.Label();
            this.txtApplicationTitle = new System.Windows.Forms.TextBox();
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
            this.lblTitle.Location = new System.Drawing.Point(133, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Update Application Types";
            // 
            // lblApplicationIDTitle
            // 
            this.lblApplicationIDTitle.AutoSize = true;
            this.lblApplicationIDTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationIDTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblApplicationIDTitle.Location = new System.Drawing.Point(64, 143);
            this.lblApplicationIDTitle.Name = "lblApplicationIDTitle";
            this.lblApplicationIDTitle.Size = new System.Drawing.Size(31, 21);
            this.lblApplicationIDTitle.TabIndex = 3;
            this.lblApplicationIDTitle.Text = "ID:";
            // 
            // lblApplicationIDValue
            // 
            this.lblApplicationIDValue.AutoSize = true;
            this.lblApplicationIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationIDValue.ForeColor = System.Drawing.Color.Silver;
            this.lblApplicationIDValue.Location = new System.Drawing.Point(135, 143);
            this.lblApplicationIDValue.Name = "lblApplicationIDValue";
            this.lblApplicationIDValue.Size = new System.Drawing.Size(43, 21);
            this.lblApplicationIDValue.TabIndex = 4;
            this.lblApplicationIDValue.Text = "[???]";
            // 
            // lblTitleT
            // 
            this.lblTitleT.AutoSize = true;
            this.lblTitleT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleT.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleT.Location = new System.Drawing.Point(64, 201);
            this.lblTitleT.Name = "lblTitleT";
            this.lblTitleT.Size = new System.Drawing.Size(48, 21);
            this.lblTitleT.TabIndex = 5;
            this.lblTitleT.Text = "Title:";
            // 
            // txtApplicationTitle
            // 
            this.txtApplicationTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtApplicationTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtApplicationTitle.Location = new System.Drawing.Point(139, 201);
            this.txtApplicationTitle.Name = "txtApplicationTitle";
            this.txtApplicationTitle.Size = new System.Drawing.Size(301, 20);
            this.txtApplicationTitle.TabIndex = 6;
            this.txtApplicationTitle.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lblFeesTitle
            // 
            this.lblFeesTitle.AutoSize = true;
            this.lblFeesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeesTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblFeesTitle.Location = new System.Drawing.Point(64, 259);
            this.lblFeesTitle.Name = "lblFeesTitle";
            this.lblFeesTitle.Size = new System.Drawing.Size(47, 21);
            this.lblFeesTitle.TabIndex = 7;
            this.lblFeesTitle.Text = "Fees:";
            // 
            // txtFeesValue
            // 
            this.txtFeesValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtFeesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFeesValue.Location = new System.Drawing.Point(139, 260);
            this.txtFeesValue.Name = "txtFeesValue";
            this.txtFeesValue.Size = new System.Drawing.Size(301, 20);
            this.txtFeesValue.TabIndex = 8;
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
            this.btnClose.Location = new System.Drawing.Point(242, 333);
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
            this.btnSave.Location = new System.Drawing.Point(400, 333);
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
            // frmEditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(562, 402);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFeesValue);
            this.Controls.Add(this.lblFeesTitle);
            this.Controls.Add(this.txtApplicationTitle);
            this.Controls.Add(this.lblTitleT);
            this.Controls.Add(this.lblApplicationIDValue);
            this.Controls.Add(this.lblApplicationIDTitle);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditApplicationType";
            this.Text = "Edit Application Type";
            this.Load += new System.EventHandler(this.frmEditApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblApplicationIDTitle;
        private System.Windows.Forms.Label lblApplicationIDValue;
        private System.Windows.Forms.Label lblTitleT;
        private System.Windows.Forms.TextBox txtApplicationTitle;
        private System.Windows.Forms.Label lblFeesTitle;
        private System.Windows.Forms.TextBox txtFeesValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epErrorProvider;
    }
}