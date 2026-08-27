namespace HostelManagementSystem
{
    partial class A_ComplaintForm
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
            dataGridView1 = new DataGridView();
            btndelete = new Button();
            lblcomplain = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(809, 335);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(668, 50);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 4;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // lblcomplain
            // 
            lblcomplain.AutoSize = true;
            lblcomplain.Location = new Point(198, 37);
            lblcomplain.Name = "lblcomplain";
            lblcomplain.Size = new Size(59, 15);
            lblcomplain.TabIndex = 3;
            lblcomplain.Text = "Complain";
            lblcomplain.Click += lblcomplain_Click;
            // 
            // A_ComplaintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btndelete);
            Controls.Add(lblcomplain);
            Name = "A_ComplaintForm";
            Size = new Size(1055, 659);
            Load += A_ComplaintForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btndelete;
        private Label lblcomplain;
    }
}
