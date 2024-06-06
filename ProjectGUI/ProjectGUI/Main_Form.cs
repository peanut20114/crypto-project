using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Firebase.Database;
using Firebase.Database.Query;

namespace ProjectGUI
{
    public partial class Main_Form : Form
    {
        private static string firebaseStorageBucket = "gs://crypto-project-2e5b1.appspot.com";
        private static string firebaseDatabaseUrl = "https://crypto-project-2e5b1.firebaseio.com/";

        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
        }
    }
}
