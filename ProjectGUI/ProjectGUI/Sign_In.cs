using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ProjectGUI
{
    public partial class Sign_In : Form
    {
        public string curUser_name;
        public string curUser_ID;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "GdfCwWCBpxKuxjX1yZfEr3Tplc1VdaS1YsTIuLLR",
            BasePath = "https://crypto-project-2e5b1-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public Sign_In()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private void lb_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
        }

        private void tb_username_Click(object sender, EventArgs e)
        {
            tb_username.Text = string.Empty;
        }

        private void tb_password_Click(object sender, EventArgs e)
        {
            tb_password.Text = string.Empty;
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("USER/");
            dynamic IDs = res.ResultAs<dynamic>();
            bool loginFlag = false;

            foreach (var id in IDs) 
            {
                string userID = id.Name;
                FirebaseResponse userRes = await client.GetAsync("USER/" + userID);
                User userData = userRes.ResultAs<User>();
                string userName = userData.UserName;
                string userEmail = userData.Email;
                string userPassword = userData.PassWord;

                if((userName == tb_username.Text) && userPassword == tb_password.Text)
                {
                    loginFlag = true;
                    Program.UserID = userID;
                    curUser_ID = userData.ID;
                    curUser_name = userData.UserName;
                    break;
                }
            }
            if (loginFlag)
            {
                this.Hide();
                Main_Form main_Form = new Main_Form(curUser_name, curUser_ID);
                main_Form.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect username or password, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
        }
    }
}
