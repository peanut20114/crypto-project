using Google.Apis.Http;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGUI
{
    internal class Crypto
    {
        public void EncryptVideo(string videoName)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            string exeFile = new Uri(Assembly.GetEntryAssembly().CodeBase).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            var script = Path.Combine(exeDir, @"..\..\..\..\AES.py");
            string choice = "encrypt";

            psi.Arguments = $"\"{script}\" \"{choice}\" \"{videoName}\"";

            string error = "";
            string result = "";

            using (Process pro = Process.Start(psi))
            {
                if (pro != null)
                {
                    result = pro.StandardOutput.ReadToEnd();
                    error = pro.StandardError.ReadToEnd();
                    pro.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Error: Fail to run python script");
                }
            }

            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Output: " + result);
            }

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Error: " + error);
            }
        }

        public void DecryptVideo(string videoName, string keyPath, string ivPath) 
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            string exeFile = new Uri(Assembly.GetEntryAssembly().CodeBase).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            var script = Path.Combine(exeDir, @"..\..\..\..\AES.py");
            string choice = "decrypt";

            psi.Arguments = $"\"{script}\" \"{choice}\" \"{videoName}\" --key_path \"{keyPath}\" --iv_path \"{ivPath}\"";

            string error = "";
            string result = "";

            using (Process pro = Process.Start(psi))
            {
                if (pro != null)
                {
                    result = pro.StandardOutput.ReadToEnd();
                    error = pro.StandardError.ReadToEnd();
                    pro.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Error: Fail to run python script");
                }
            }

            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Output: " + result);
            }

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Error: " + error);
            }
        }

        public void EncryptAESkey(string keyPath, string receiver_pub_path, string sender_pri_path, string output_dir)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            string exeFile = new Uri(Assembly.GetEntryAssembly().CodeBase).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            var script = Path.Combine(exeDir, @"..\..\..\..\AES.py");
            string choice = "encryptAESkey";
            psi.Arguments = $"\"{script}\" \"{choice}\" \"{keyPath}\" --public_key \"{receiver_pub_path}\" --private_key \"{sender_pri_path}\" --output_dir \"{output_dir}\"";

            string error = "";
            string result = "";

            using (Process pro = Process.Start(psi))
            {
                if (pro != null)
                {
                    result = pro.StandardOutput.ReadToEnd();
                    error = pro.StandardError.ReadToEnd();
                    pro.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Error: Fail to run python script");
                }
            }

            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Output: " + result);
            }

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Error: " + error);
            }
        }

        public void DecryptAESkey(string keyPath, string sender_pub_path, string receiver_pri_path, string output_dir)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            string exeFile = new Uri(Assembly.GetEntryAssembly().CodeBase).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            var script = Path.Combine(exeDir, @"..\..\..\..\AES.py");
            string choice = "decryptAESkey";
            psi.Arguments = $"\"{script}\" \"{choice}\" \"{keyPath}\" --public_key \"{sender_pub_path}\" --private_key \"{receiver_pri_path}\" --output_dir \"{output_dir}\"";

            string error = "";
            string result = "";

            using (Process pro = Process.Start(psi))
            {
                if (pro != null)
                {
                    result = pro.StandardOutput.ReadToEnd();
                    error = pro.StandardError.ReadToEnd();
                    pro.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Error: Fail to run python script");
                }
            }

            if (!string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Output: " + result);
            }

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
