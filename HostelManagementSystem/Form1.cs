namespace HostelManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ALL_login loginForm = new ALL_login();
            loginForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}