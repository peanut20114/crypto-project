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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void tb_fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_fullName_Click(object sender, EventArgs e)
        {
            tb_fullName.Text = string.Empty;
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
