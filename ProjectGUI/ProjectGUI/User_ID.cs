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
    public partial class User_ID : Form
    {
        public User_ID()
        {
            InitializeComponent();
        }

        private void tb_username_Click(object sender, EventArgs e)
        {
            tb_username.Text = string.Empty;
        }

        private void tb_ID_Click(object sender, EventArgs e)
        {
            tb_ID.Text = string.Empty;
        }
    }
}
