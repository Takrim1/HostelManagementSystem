namespace HostelManagementSystem
{
    partial class Stud_Notice
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
            lblnotice = new Label();
            btndelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblnotice
            // 
            lblnotice.AutoSize = true;
            lblnotice.Location = new Point(207, 31);
            lblnotice.Name = "lblnotice";
            lblnotice.Size = new Size(42, 15);
            lblnotice.TabIndex = 0;
            lblnotice.Text = "Notice";
            lblnotice.Click += lblnotice_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(677, 44);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 1;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(809, 335);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Stud_Notice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btndelete);
            Controls.Add(lblnotice);
            Name = "Stud_Notice";
            Size = new Size(1014, 607);
            Load += Stud_Notice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnotice;
        private Button btndelete;
        private DataGridView dataGridView1;
    }
}
