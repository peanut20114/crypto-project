using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGUI
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void lb_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.ShowDialog();
        }

        private void tb_username_Click(object sender, EventArgs e)
        {
            tb_username.Text = string.Empty;
        }

        private void tb_password_Click(object sender, EventArgs e)
        {
            tb_password.Text = string.Empty;
        }
    }
}
