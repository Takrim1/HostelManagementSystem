namespace HostelManagementSystem
{
    partial class Staff_Complaint
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
            btnsave = new Button();
            txtcomplaintbox = new TextBox();
            lblcomplaint = new Label();
            SuspendLayout();
            // 
            // btnsave
            // 
            btnsave.Location = new Point(354, 303);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(152, 52);
            btnsave.TabIndex = 5;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // txtcomplaintbox
            // 
            txtcomplaintbox.Location = new Point(250, 59);
            txtcomplaintbox.Multiline = true;
            txtcomplaintbox.Name = "txtcomplaintbox";
            txtcomplaintbox.Size = new Size(501, 191);
            txtcomplaintbox.TabIndex = 4;
            txtcomplaintbox.TextChanged += txtcomplaintbox_TextChanged;
            // 
            // lblcomplaint
            // 
            lblcomplaint.AutoSize = true;
            lblcomplaint.Location = new Point(128, 60);
            lblcomplaint.Name = "lblcomplaint";
            lblcomplaint.Size = new Size(85, 15);
            lblcomplaint.TabIndex = 3;
            lblcomplaint.Text = "Complaint Box";
            lblcomplaint.Click += lblcomplaint_Click;
            // 
            // Staff_Complaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnsave);
            Controls.Add(txtcomplaintbox);
            Controls.Add(lblcomplaint);
            Name = "Staff_Complaint";
            Size = new Size(956, 626);
            Load += Staff_Complaint_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsave;
        private TextBox txtcomplaintbox;
        private Label lblcomplaint;
    }
}
