namespace HostelManagementSystem
{
    partial class Staff_Notice
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
            lblnotice = new Label();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(797, 275);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblnotice
            // 
            lblnotice.AutoSize = true;
            lblnotice.Location = new Point(70, 81);
            lblnotice.Name = "lblnotice";
            lblnotice.Size = new Size(42, 15);
            lblnotice.TabIndex = 4;
            lblnotice.Text = "Notice";
            lblnotice.Click += lblnotice_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(697, 73);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 5;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // Staff_Notice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btndelete);
            Controls.Add(lblnotice);
            Controls.Add(dataGridView1);
            Name = "Staff_Notice";
            Size = new Size(937, 552);
            Load += Staff_Notice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblnotice;
        private Button btndelete;
    }
}
