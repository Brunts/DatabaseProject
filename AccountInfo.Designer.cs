namespace DatabaseProject
{
    partial class AccountInfo
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountryHome = new System.Windows.Forms.ComboBox();
            this.txtPasswordHome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailHome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameHome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackHome
            // 
            this.btnBackHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.Location = new System.Drawing.Point(12, 397);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(97, 41);
            this.btnBackHome.TabIndex = 20;
            this.btnBackHome.Text = "Logout";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(212, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(225, 71);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update My Account Info";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Country:";
            // 
            // txtCountryHome
            // 
            this.txtCountryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryHome.FormattingEnabled = true;
            this.txtCountryHome.Items.AddRange(new object[] {
            "India",
            "China",
            "USA",
            "Canada",
            "Mexico",
            "Iceland",
            "Germany",
            "Argentina"});
            this.txtCountryHome.Location = new System.Drawing.Point(167, 253);
            this.txtCountryHome.Name = "txtCountryHome";
            this.txtCountryHome.Size = new System.Drawing.Size(521, 45);
            this.txtCountryHome.TabIndex = 17;
            this.txtCountryHome.SelectedIndexChanged += new System.EventHandler(this.txtCountryHome_SelectedIndexChanged);
            // 
            // txtPasswordHome
            // 
            this.txtPasswordHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordHome.Location = new System.Drawing.Point(167, 177);
            this.txtPasswordHome.Name = "txtPasswordHome";
            this.txtPasswordHome.Size = new System.Drawing.Size(521, 39);
            this.txtPasswordHome.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // txtEmailHome
            // 
            this.txtEmailHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailHome.Location = new System.Drawing.Point(167, 115);
            this.txtEmailHome.Name = "txtEmailHome";
            this.txtEmailHome.Size = new System.Drawing.Size(521, 39);
            this.txtEmailHome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email:";
            // 
            // txtNameHome
            // 
            this.txtNameHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameHome.Location = new System.Drawing.Point(167, 60);
            this.txtNameHome.Name = "txtNameHome";
            this.txtNameHome.Size = new System.Drawing.Size(521, 39);
            this.txtNameHome.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name: ";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHome.Location = new System.Drawing.Point(163, 23);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(191, 20);
            this.lblHome.TabIndex = 21;
            this.lblHome.Text = "Change Account Settings";
            this.lblHome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(589, 346);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(199, 72);
            this.btnDeleteAccount.TabIndex = 22;
            this.btnDeleteAccount.Text = "Delete My Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(497, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 23;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountryHome);
            this.Controls.Add(this.txtPasswordHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameHome);
            this.Controls.Add(this.label2);
            this.Name = "AccountInfo";
            this.Text = "Account Information";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtCountryHome;
        private System.Windows.Forms.TextBox txtPasswordHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}