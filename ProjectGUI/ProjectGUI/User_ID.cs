using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Storage;

namespace ProjectGUI
{
    public partial class User_ID : Form
    {
        private string videoname, videourl, username, userid;
        public User_ID(string videoName, string videoUrl, string userName, string userID)
        {
            InitializeComponent();
            videoname = videoName;
            videourl = videoUrl;
            username = userName;
            userid = userID;
        }


        private void tb_ID_Click(object sender, EventArgs e)
        {
            tb_ID.Text = string.Empty;
        }

        private readonly string bucket = "crypto-project-2e5b1.appspot.com";
        private readonly string apiKey = "AIzaSyCzy--9BTNYjgbevL5mNC_HOUni4pswcJs";
        private readonly string email = "22520731@gm.uit.edu.vn";
        private readonly string password = "1061100235";
        private readonly string firebaseDatabaseUrl = "https://crypto-project-2e5b1-default-rtdb.asia-southeast1.firebasedatabase.app/";
        private FirebaseAuthLink auth;

        private async void btn_send_Click(object sender, EventArgs e)
        {
            string receiverID = tb_ID.Text;
            try
            {
                if (!string.IsNullOrEmpty(receiverID))
                {
                    var (userExists, user_ECC_PubKey, recvName) = await CheckIfUserExists(receiverID);
                    if (userExists)
                    {
                        string videoNameWithoutExtension = Path.GetFileNameWithoutExtension(videoname);

                        // Save receiver's ECC Public Key
                        string tempFolder = $@"D:\{videoNameWithoutExtension}_temp";
                        string receiver_ECC_PublicKey_Path = Path.Combine(tempFolder, $"{recvName}_public_key.pem");
                        File.WriteAllText(receiver_ECC_PublicKey_Path, user_ECC_PubKey);

                        // Define sender private key
                        string private_key_path = $@"D:\{username}_Key\{username}_private_key.pem";

                        // Define AES key and iv
                        string AESkey_path = $@"D:\{videoNameWithoutExtension}_temp\AESkey.txt";
                        string AESiv_path = $@"D:\{videoNameWithoutExtension}_temp\AESiv.txt";

                        Crypto crypto = new Crypto();
                        crypto.EncryptAESkey(AESkey_path, receiver_ECC_PublicKey_Path, private_key_path, tempFolder);

                        await ShareVideoToUser(receiverID, videoname, videourl, AESkey_path, AESiv_path);
                        MessageBox.Show("Video shared successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User ID is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Exception details: " + ex.ToString());
            }
        }

        private async Task ShareVideoToUser(string receiverID, string vidName, string vidUrl, string aesKey, string aesIV)
        {
            try
            {
                // Authenticate with Firebase
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
                auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                var cancellation = new CancellationTokenSource();

                // Download the video from the existing URL
                using (var client = new HttpClient())
                {
                    var videoData = await client.GetByteArrayAsync(vidUrl);
                    using (var stream = new MemoryStream(videoData))
                    {
                        // Upload video to receiver's folder in Firebase Storage
                        var task = new FirebaseStorage(
                            bucket,
                            new FirebaseStorageOptions
                            {
                                AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken),
                                ThrowOnCancel = true,
                            })
                            .Child("VIDEOS")
                            .Child(receiverID) // Create folder with receiver's user ID
                            .Child(vidName)  // Video name
                            .PutAsync(stream, cancellation.Token);

                        string newDownloadUrl = await task;

                        // Save the video metadata to the Firebase Realtime Database for the receiver
                        await SaveVideoMetadataToDatabase(receiverID, vidName, newDownloadUrl, aesKey, aesIV);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sharing video to user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SaveVideoMetadataToDatabase(string userId, string videoName, string downloadUrl, string aesKey, string aesIV)
        {
            try
            {
                string aeskey = File.ReadAllText(aesKey);
                string iv = File.ReadAllText(aesIV);
                var firebaseClient = new FirebaseClient(firebaseDatabaseUrl);
                await firebaseClient
                    .Child("VIDEOS/" + userId) // Receiver's user ID
                    .PostAsync(new { name = videoName, url = downloadUrl, Key = aeskey, IV = iv });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving video metadata to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<(bool, string, string)> CheckIfUserExists(string userID)
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
                    return (true, user.ECC_public_Key, user.UserName);
                }
                else
                {
                    return (false, null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking user existence: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, null, null);
            }
        }
    }
}
