namespace HostelManagementSystem
{
    partial class Stud_Complaint
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
            lblcomplaint = new Label();
            txtcomplaintbox = new TextBox();
            btnsave = new Button();
            SuspendLayout();
            // 
            // lblcomplaint
            // 
            lblcomplaint.AutoSize = true;
            lblcomplaint.Location = new Point(137, 70);
            lblcomplaint.Name = "lblcomplaint";
            lblcomplaint.Size = new Size(85, 15);
            lblcomplaint.TabIndex = 0;
            lblcomplaint.Text = "Complaint Box";
            lblcomplaint.Click += lblcomplaint_Click;
            // 
            // txtcomplaintbox
            // 
            txtcomplaintbox.Location = new Point(259, 69);
            txtcomplaintbox.Multiline = true;
            txtcomplaintbox.Name = "txtcomplaintbox";
            txtcomplaintbox.Size = new Size(501, 191);
            txtcomplaintbox.TabIndex = 1;
            txtcomplaintbox.TextChanged += txtcomplaintbox_TextChanged;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(363, 313);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(152, 52);
            btnsave.TabIndex = 2;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // Stud_Complaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnsave);
            Controls.Add(txtcomplaintbox);
            Controls.Add(lblcomplaint);
            Name = "Stud_Complaint";
            Size = new Size(1015, 538);
            Load += Stud_Complaint_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcomplaint;
        private TextBox txtcomplaintbox;
        private Button btnsave;
    }
}
