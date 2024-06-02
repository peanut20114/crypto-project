namespace crypto_project
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
        }
    }
}
