using Firebase.Auth;
using Firebase.Storage;
using Firebase.Database;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGUI
{
    public partial class Main_Form : Form
    {
        public Main_Form(string username, string id)
        {
            InitializeComponent();
            tb_username.Text = username;
            tb_id.Text = id;
        }

        private static string firebaseDatabaseUrl = "https://crypto-project-2e5b1.firebaseio.com/";

        private async void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Video Files(*.mp4;*.avi;*.mov;*.wmv)|*.mp4;*.avi;*.mov;*.wmv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string videoPath = dialog.FileName;
                    string videoName = Path.GetFileName(videoPath);

                    string bucket = "crypto-project-2e5b1.appspot.com";
                    string apiKey = "AIzaSyCzy--9BTNYjgbevL5mNC_HOUni4pswcJs";
                    string email = "22520731@gm.uit.edu.vn";
                    string password = "1061100235";

                    // Authenticate with Firebase
                    var auth = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
                    var a = await auth.SignInWithEmailAndPasswordAsync(email, password);
                    var cancellation = new CancellationTokenSource();

                    // Upload video
                    using (var stream = File.Open(videoPath, FileMode.Open))
                    {
                        var task = new FirebaseStorage(
                            bucket,
                            new FirebaseStorageOptions
                            {
                                AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                                ThrowOnCancel = true,
                            })
                            .Child(tb_id.Text)
                            .Child(videoName)
                            .PutAsync(stream, cancellation.Token);

                        string downloadUrl = await task;

                        await SaveVideoUrlToDatabase(downloadUrl);

                        MessageBox.Show("Video uploaded successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task SaveVideoUrlToDatabase(string downloadUrl)
        {
            var firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
            await firebaseClient
                .Child(tb_id.Text)
                .PostAsync(new { url = downloadUrl });
        }

        private void btn_copyID_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_id.Text);
            label2.Visible = true;
        }
    }
}
