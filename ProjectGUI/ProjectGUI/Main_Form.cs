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
        private readonly string bucket = "crypto-project-2e5b1.appspot.com";
        private readonly string apiKey = "AIzaSyCzy--9BTNYjgbevL5mNC_HOUni4pswcJs";
        private readonly string email = "22520731@gm.uit.edu.vn";
        private readonly string password = "1061100235";
        private readonly string firebaseDatabaseUrl = "https://crypto-project-2e5b1-default-rtdb.asia-southeast1.firebasedatabase.app/";
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

                    Crypto crypto = new Crypto();
                    crypto.EncryptVideo(videoName);

                    string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
                    string exeDir = Path.GetDirectoryName(exeFile);
                    string encryptedVideoPath = Path.Combine(exeDir, @"..\..\..\..\..\crypto-project\temp\ciphertext.txt");

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
            try
            {
                // Kiểm tra xem có mục nào được chọn không
                if (lv_listVideos.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a file to download.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Hiển thị hộp thoại chọn thư mục để lưu tập tin đã tải xuống
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFolder = folderDialog.SelectedPath;

                    // Lặp qua tất cả các mục được chọn trong ListView
                    foreach (ListViewItem selectedItem in lv_listVideos.SelectedItems)
                    {
                        // Lấy URL của video từ mục được chọn trong ListView
                        string url = selectedItem.SubItems[1].Text; // Giả sử URL được lưu tại cột thứ hai trong ListView

                        // Lấy tên tệp từ URL
                        string fileName = Path.GetFileName(new Uri(url).LocalPath);

                        // Tạo đường dẫn đầy đủ của tệp
                        string filePath = Path.Combine(destinationFolder, fileName);

                        // Thực hiện tải xuống và lưu vào thư mục đích
                        using (var client = new System.Net.WebClient())
                        {
                            await client.DownloadFileTaskAsync(url, filePath);
                        }
                    }

                    MessageBox.Show("Files downloaded successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
