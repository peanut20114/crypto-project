using Firebase.Auth;
using Firebase.Storage;
using Firebase.Database;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Security.Policy;
using System.Reflection;
using Firebase.Database.Query;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Linq;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.X509;
using System.Net.Http;

namespace ProjectGUI
{
    public partial class Main_Form : Form
    {
        private string userPubKey;

        public Main_Form(string username, string id, string publickey)
        {
            InitializeComponent();
            tb_username.Text = username;
            tb_id.Text = id;
            userPubKey = publickey;
        }
        private readonly string bucket = "crypto-project-2e5b1.appspot.com";
        private readonly string apiKey = "AIzaSyCzy--9BTNYjgbevL5mNC_HOUni4pswcJs";
        private readonly string email = "22520731@gm.uit.edu.vn";
        private readonly string password = "1061100235";
        private readonly string firebaseDatabaseUrl = "https://crypto-project-2e5b1-default-rtdb.asia-southeast1.firebasedatabase.app/";
        private string globalVideoPath;
        private FirebaseAuthLink auth;

        private async void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Video Files(*.mp4;*.avi;*.mov;*.wmv)|*.mp4;*.avi;*.mov;*.wmv"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string videoPath = dialog.FileName;
                    string videoName = Path.GetFileName(videoPath);
                    globalVideoPath = videoPath;
                    string vid = Path.GetFileNameWithoutExtension(videoPath);
                    Crypto crypto = new Crypto();
                    crypto.EncryptVideo(videoPath);

                    string exeFile = new Uri(Assembly.GetEntryAssembly().CodeBase).LocalPath;
                    string exeDir = Path.GetDirectoryName(exeFile);

                    // Construct the path: D:/[video_name]_temp/ciphertext.txt
                    string tempFolder = $@"D:\{vid}_temp";
                    Directory.CreateDirectory(tempFolder); // Ensure the directory exists
                    string outputName = vid + ".txt";
                    string encryptedVideoPath = Path.Combine(tempFolder, outputName);

                    // Authenticate with Firebase
                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
                    auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                    var cancellation = new CancellationTokenSource();

                    // Upload video
                    using (var stream = File.Open(encryptedVideoPath, FileMode.Open))
                    {
                        var task = new FirebaseStorage(
                            bucket,
                            new FirebaseStorageOptions
                            {
                                AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken),
                                ThrowOnCancel = true,
                            })
                            .Child("VIDEOS")
                            .Child(tb_id.Text) // Create folder with user ID
                            .Child(videoName)  // Video name
                            .PutAsync(stream, cancellation.Token);

                        string downloadUrl = await task;

                        // Save the video metadata to the Firebase Realtime Database
                        await SaveVideoMetadataToDatabase(videoName, downloadUrl);

                        MessageBox.Show("Video uploaded and metadata saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Add the URL to the ListView
                        lv_listVideos.Items.Add(new ListViewItem(new[] { videoName, downloadUrl }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception details: " + ex.ToString());
            }
        }

        private async Task SaveVideoMetadataToDatabase(string videoName, string downloadUrl)
        {
            try

            {
                var firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
                await firebaseClient
                    .Child("VIDEOS/"+tb_id.Text) // User ID
                    .PostAsync(new { name = videoName, url = downloadUrl });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving video metadata to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadVideoUrls()
        {
            try
            {
                var firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
                var videos = await firebaseClient
                    .Child("VIDEOS/" + tb_id.Text) // User ID
                    .OnceAsync<VideoMetadata>();

                lv_listVideos.Items.Clear();

                foreach (var video in videos)
                {
                    lv_listVideos.Items.Add(new ListViewItem(new[] { video.Object.name, video.Object.url }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading video URLs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception details: " + ex.ToString());
            }
        }

        private class VideoMetadata
        {
            public string name { get; set; }
            public string url { get; set; }
        }


        private void btn_copyID_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_id.Text);
            label2.Visible = true;
        }

        private async void lv_listVideos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lv_listVideos.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lv_listVideos.SelectedItems[0];
                    string videoName = selectedItem.SubItems[0].Text; // Lấy tên video từ ListView
                    string videoUrl = selectedItem.SubItems[1].Text;  // Lấy URL video từ ListView

                    // Gán URL của video cho axWindowsMediaPlayer1 để phát
                    axWindowsMediaPlayer1.URL = videoUrl;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_download_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lv_listVideos.SelectedItems[0];
            string video_Name = selectedItem.SubItems[0].Text.Trim();
            string curUserID = tb_id.Text;


            var (AES_Key_Are_Null, aesKey, aesIV, sender_pub_key, ivKey) = await CheckIfVideoAESFieldsAreNull(video_Name, curUserID);
            MessageBox.Show($"{aesKey} {aesIV} {ivKey}");
            if (AES_Key_Are_Null)
            {
                try
                {
                    // Kiểm tra xem có mục nào được chọn không
                    if (lv_listVideos.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Please select a file to download.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        string url = selectedItem.SubItems[1].Text;
                        string videoName = Path.GetFileName(video_Name);

                        string videoNameWithoutExtension = Path.GetFileNameWithoutExtension(video_Name);
                        string folder = $@"D:\{videoNameWithoutExtension}_temp";
                        string encryptedVideoPath = Path.Combine(folder, videoNameWithoutExtension + ".mp4");
                        await DownloadFileFromFirebaseStorage(url, encryptedVideoPath);
                        string keyPath = Path.Combine(folder, "AESkey.txt");
                        string ivPath = Path.Combine(folder, "AESiv.txt");
                        Crypto crypto = new Crypto();
                        crypto.DecryptVideo(encryptedVideoPath, keyPath, ivPath);
                        MessageBox.Show("Files downloaded successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string url = selectedItem.SubItems[1].Text;
                string videoNameWithoutExtension = Path.GetFileNameWithoutExtension(video_Name);
                string folder = $@"D:\{videoNameWithoutExtension}_temp";
                string encryptedVideoPath = Path.Combine(folder, videoNameWithoutExtension + ".mp4");
                Directory.CreateDirectory(folder);
                string AESkey_path = Path.Combine(folder, "AESkey.txt");
                string AESiv_path = Path.Combine(folder, "AESiv.txt");
                string ivKey_path = Path.Combine(folder, "iv.txt");

                string senderPubKey_path = Path.Combine(folder, "sender_public_key.pem");
                File.WriteAllText(senderPubKey_path, sender_pub_key);
                await DownloadFileFromFirebaseStorage(aesIV, AESiv_path);
                await DownloadFileFromFirebaseStorage(aesKey, AESkey_path);
                await DownloadFileFromFirebaseStorage(ivKey, ivKey_path);
                await DownloadFileFromFirebaseStorage(url, encryptedVideoPath);
                string curUserName = tb_username.Text;
                string directoryPath = Path.Combine("D:\\", $"{curUserName}_Key");
                string privateKeyPath = Path.Combine(directoryPath, $"{curUserName}_private_key.pem");
                Crypto crypto = new Crypto();

                crypto.DecryptAESkey(AESkey_path, senderPubKey_path, privateKeyPath, folder);
                MessageBox.Show($"{encryptedVideoPath} {AESkey_path} {AESiv_path} ");

                crypto.DecryptVideo(encryptedVideoPath, AESkey_path, AESiv_path);

            }
        }

        static async Task DownloadFileFromFirebaseStorage(string fileUrl, string localPath)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(fileUrl);
                response.EnsureSuccessStatusCode();

                using (FileStream fs = new FileStream(localPath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    await response.Content.CopyToAsync(fs);
                }
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadVideoUrls();
        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            try
            {
                // Lặp qua tất cả các mục trong ListView và đặt Selected thành true
                foreach (ListViewItem item in lv_listVideos.Items)
                {
                    item.Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<(bool, string)> CheckIfUserExists(string userID)
        {
            try
            {
                var firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
                var user = await firebaseClient
                    .Child("USER")
                    .Child(userID)
                    .OnceSingleAsync<User>();

                // Check if user object is not null and has a ECC_public_Key
                if (user != null)
                {
                    return (true, user.ECC_public_Key);
                }
                else
                {
                    return (false, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking user existence: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, null);
            }
        }

        private void btn_share_Click(object sender, EventArgs e)
        {
            var selectedItem = lv_listVideos.SelectedItems[0];
            string videoName = selectedItem.SubItems[0].Text;
            string videoUrl = selectedItem.SubItems[1].Text;
            string userName = tb_username.Text;
            string userID = tb_id.Text;
            User_ID user_ID = new User_ID(videoName, videoUrl, userName, userID, userPubKey);
            user_ID.Show();


        }

        private async void btn_decrypt_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lv_listVideos.SelectedItems[0];
            string video_Name = selectedItem.SubItems[0].Text.Trim();
            string videoNameWithoutExtension = Path.GetFileNameWithoutExtension(video_Name);
            string folder = $@"D:\{videoNameWithoutExtension}_temp";
            string VideoPath = Path.Combine(folder, "recovered.mp4");
            axWindowsMediaPlayer1.URL = VideoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private async Task<(bool, string, string, string, string)> CheckIfVideoAESFieldsAreNull(string videoName, string userId)
        {
            try
            {
                var firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
                var videoMetadata = (await firebaseClient
                    .Child("VIDEOS")
                    .Child(userId)
                    .OrderBy("name")
                    .EqualTo(videoName)
                    .OnceAsync<dynamic>())
                    .FirstOrDefault()?.Object;

                if (videoMetadata != null && videoMetadata.Key != null )
                {
                    string aesKey = videoMetadata.Key;
                    string aesIV = videoMetadata.IV;
                    string senderPubKey = videoMetadata.sender_ECC_Pub_Key;
                    string ivKey = videoMetadata.IV_key;

                    
                    return (false, aesKey, aesIV,senderPubKey,ivKey); // Key and IV exist and are not null
                }
                return (true, null, null, null,null); // If no Key or IV found, assume AES fields are null
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking video AES fields: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (true, null, null, null, null); // On error, assume AES fields are null
            }
        }

    }
}
