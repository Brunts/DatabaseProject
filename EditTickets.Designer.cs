namespace DatabaseProject
{
    partial class EditTickets
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
            this.btnBackHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCaseNum = new System.Windows.Forms.Label();
            this.caseOwner = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.caseNumInput = new System.Windows.Forms.TextBox();
            this.caseSub = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackHome
            // 
            this.btnBackHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.Location = new System.Drawing.Point(12, 397);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(97, 41);
            this.btnBackHome.TabIndex = 23;
            this.btnBackHome.Text = "Logout";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(115, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 41);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Case Number: ";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(482, 34);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(63, 20);
            this.lblOwner.TabIndex = 31;
            this.lblOwner.Text = "Owner: ";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(58, 98);
            this.lblSub.Name = "lblSub";
            this.lblSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSub.Size = new System.Drawing.Size(71, 20);
            this.lblSub.TabIndex = 32;
            this.lblSub.Text = "Subject: ";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(58, 179);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(93, 20);
            this.lblDesc.TabIndex = 33;
            this.lblDesc.Text = "Description:";
            // 
            // lblCaseNum
            // 
            this.lblCaseNum.AutoSize = true;
            this.lblCaseNum.Location = new System.Drawing.Point(178, 34);
            this.lblCaseNum.Name = "lblCaseNum";
            this.lblCaseNum.Size = new System.Drawing.Size(0, 20);
            this.lblCaseNum.TabIndex = 34;
            // 
            // caseOwner
            // 
            this.caseOwner.FormattingEnabled = true;
            this.caseOwner.Location = new System.Drawing.Point(551, 31);
            this.caseOwner.Name = "caseOwner";
            this.caseOwner.Size = new System.Drawing.Size(237, 28);
            this.caseOwner.TabIndex = 35;
            this.caseOwner.SelectedIndexChanged += new System.EventHandler(this.caseOwner_SelectedIndexChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(178, 179);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(538, 182);
            this.txtDesc.TabIndex = 37;
            this.txtDesc.Text = " ";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(18, 235);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(111, 79);
            this.btnSaveChanges.TabIndex = 38;
            this.btnSaveChanges.Text = "SAVE CHANGES";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // caseNumInput
            // 
            this.caseNumInput.Location = new System.Drawing.Point(178, 31);
            this.caseNumInput.Name = "caseNumInput";
            this.caseNumInput.Size = new System.Drawing.Size(183, 26);
            this.caseNumInput.TabIndex = 39;
            this.caseNumInput.TextChanged += new System.EventHandler(this.caseNumInput_TextChanged);
            // 
            // caseSub
            // 
            this.caseSub.FormattingEnabled = true;
            this.caseSub.Location = new System.Drawing.Point(178, 98);
            this.caseSub.Name = "caseSub";
            this.caseSub.Size = new System.Drawing.Size(237, 28);
            this.caseSub.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(659, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 58);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EditTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.caseSub);
            this.Controls.Add(this.caseNumInput);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.caseOwner);
            this.Controls.Add(this.lblCaseNum);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBackHome);
            this.Name = "EditTickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCaseNum;
        private System.Windows.Forms.ComboBox caseOwner;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox caseNumInput;
        private System.Windows.Forms.ComboBox caseSub;
        private System.Windows.Forms.Button btnDelete;
    }
}