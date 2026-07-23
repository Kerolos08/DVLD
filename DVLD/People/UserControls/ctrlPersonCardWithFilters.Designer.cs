namespace DVLD.People.UserControls
{
    partial class ctrlPersonCardWithFilters
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.epErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new DVLD.People.UserControls.ctrlPersonCard();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlToolbar.Controls.Add(this.btnSearch);
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.lblFilterBy);
            this.pnlToolbar.Controls.Add(this.cmbFilterBy);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Location = new System.Drawing.Point(25, 24);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(789, 71);
            this.pnlToolbar.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(634, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "🔳";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(712, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "➕";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblFilterBy.Location = new System.Drawing.Point(25, 27);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(54, 19);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Find by";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterBy.ForeColor = System.Drawing.Color.White;
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.cmbFilterBy.Location = new System.Drawing.Point(96, 24);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(160, 25);
            this.cmbFilterBy.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(277, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // epErrorProvider
            // 
            this.epErrorProvider.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ctrlPersonCard1.Location = new System.Drawing.Point(13, 100);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Padding = new System.Windows.Forms.Padding(9);
            this.ctrlPersonCard1.Size = new System.Drawing.Size(815, 300);
            this.ctrlPersonCard1.TabIndex = 7;
            // 
            // ctrlPersonCardWithFilters
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "ctrlPersonCardWithFilters";
            this.Size = new System.Drawing.Size(840, 400);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ErrorProvider epErrorProvider;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
