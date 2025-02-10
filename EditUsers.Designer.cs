namespace DatabaseProject
{
    partial class EditUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.performOperationbtn = new System.Windows.Forms.Button();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(864, 514);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // performOperationbtn
            // 
            this.performOperationbtn.Location = new System.Drawing.Point(186, 435);
            this.performOperationbtn.Name = "performOperationbtn";
            this.performOperationbtn.Size = new System.Drawing.Size(498, 67);
            this.performOperationbtn.TabIndex = 1;
            this.performOperationbtn.Text = "Perform Operation";
            this.performOperationbtn.UseVisualStyleBackColor = true;
            this.performOperationbtn.Click += new System.EventHandler(this.performOperationbtn_Click);
            // 
            // btnBackHome
            // 
            this.btnBackHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.Location = new System.Drawing.Point(12, 460);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(97, 41);
            this.btnBackHome.TabIndex = 21;
            this.btnBackHome.Text = "Logout";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CommandBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.performOperationbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CommandBuilderForm";
            this.Text = "User Databse";
            this.Load += new System.EventHandler(this.CommandBuilderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button performOperationbtn;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Button button1;
    }
}