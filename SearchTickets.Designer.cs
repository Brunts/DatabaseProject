namespace DatabaseProject
{
    partial class SearchTickets
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
            this.txtSearchBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtSubjectDrop = new System.Windows.Forms.ComboBox();
            this.casesGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.casesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.FormattingEnabled = true;
            this.txtSearchBox.Items.AddRange(new object[] {
            "OWNER",
            "SUBJECT",
            "CASE NUMBER"});
            this.txtSearchBox.Location = new System.Drawing.Point(251, 51);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(450, 45);
            this.txtSearchBox.TabIndex = 8;
            this.txtSearchBox.SelectedIndexChanged += new System.EventHandler(this.txtSearchBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(251, 133);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(210, 39);
            this.txtInput.TabIndex = 14;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtSubjectDrop
            // 
            this.txtSubjectDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectDrop.FormattingEnabled = true;
            this.txtSubjectDrop.Items.AddRange(new object[] {
            "SOFTWARE",
            "HARDWARE",
            "OTHER"});
            this.txtSubjectDrop.Location = new System.Drawing.Point(481, 130);
            this.txtSubjectDrop.Name = "txtSubjectDrop";
            this.txtSubjectDrop.Size = new System.Drawing.Size(220, 45);
            this.txtSubjectDrop.TabIndex = 15;
            this.txtSubjectDrop.SelectedIndexChanged += new System.EventHandler(this.txtSubjectDrop_SelectedIndexChanged);
            // 
            // casesGrid
            // 
            this.casesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casesGrid.Location = new System.Drawing.Point(12, 204);
            this.casesGrid.Name = "casesGrid";
            this.casesGrid.ReadOnly = true;
            this.casesGrid.RowHeadersWidth = 62;
            this.casesGrid.RowTemplate.Height = 28;
            this.casesGrid.Size = new System.Drawing.Size(765, 234);
            this.casesGrid.TabIndex = 16;
            this.casesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.casesGrid_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.casesGrid);
            this.Controls.Add(this.txtSubjectDrop);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearchBox);
            this.Name = "SearchTickets";
            this.Text = "SearchTickets";
            this.Load += new System.EventHandler(this.SearchTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtSearchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox txtSubjectDrop;
        private System.Windows.Forms.DataGridView casesGrid;
        private System.Windows.Forms.Button button2;
    }
}