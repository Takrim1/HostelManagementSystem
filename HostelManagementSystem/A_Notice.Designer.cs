namespace HostelManagementSystem
{
    partial class A_Notice
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblwritenotice = new Label();
            txtrtnotice = new RichTextBox();
            dataGridView1 = new DataGridView();
            btnsavenotice = new Button();
            btndeletenotice = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblwritenotice
            // 
            lblwritenotice.AutoSize = true;
            lblwritenotice.Location = new Point(65, 51);
            lblwritenotice.Name = "lblwritenotice";
            lblwritenotice.Size = new Size(73, 15);
            lblwritenotice.TabIndex = 0;
            lblwritenotice.Text = "Write Notice";
            lblwritenotice.Click += lblwritenotice_Click;
            // 
            // txtrtnotice
            // 
            txtrtnotice.Location = new Point(141, 31);
            txtrtnotice.Name = "txtrtnotice";
            txtrtnotice.Size = new Size(539, 118);
            txtrtnotice.TabIndex = 1;
            txtrtnotice.Text = "";
            txtrtnotice.TextChanged += txtrtnotice_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(44, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(797, 275);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnsavenotice
            // 
            btnsavenotice.Location = new Point(733, 50);
            btnsavenotice.Name = "btnsavenotice";
            btnsavenotice.Size = new Size(108, 53);
            btnsavenotice.TabIndex = 3;
            btnsavenotice.Text = "Save Notice";
            btnsavenotice.UseVisualStyleBackColor = true;
            btnsavenotice.Click += btnsavenotice_Click;
            // 
            // btndeletenotice
            // 
            btndeletenotice.Location = new Point(678, 201);
            btndeletenotice.Name = "btndeletenotice";
            btndeletenotice.Size = new Size(163, 42);
            btndeletenotice.TabIndex = 4;
            btndeletenotice.Text = "Delete Notice";
            btndeletenotice.UseVisualStyleBackColor = true;
            btndeletenotice.Click += btndeletenotice_Click;
            // 
            // A_Notice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btndeletenotice);
            Controls.Add(btnsavenotice);
            Controls.Add(dataGridView1);
            Controls.Add(txtrtnotice);
            Controls.Add(lblwritenotice);
            Name = "A_Notice";
            Size = new Size(908, 565);
            Load += A_Notice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwritenotice;
        private RichTextBox txtrtnotice;
        private DataGridView dataGridView1;
        private Button btnsavenotice;
        private Button btndeletenotice;
    }
}
