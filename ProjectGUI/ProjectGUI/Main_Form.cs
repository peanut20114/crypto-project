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
using Firebase.Storage;
using Firebase.Database.Query;
using System.Collections.Generic;

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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files(*.mp4;*.avi;*.mov)|*.mp4;*.avi;*.mov";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string videoPath = ofd.FileName;
                string videoName = Path.GetFileName(videoPath);

                var stream = File.Open(videoPath, FileMode.Open);
                var task = new FirebaseStorage(firebaseStorageBucket)
                    .Child
            }
        }
    }
}
