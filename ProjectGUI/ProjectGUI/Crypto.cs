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

        public void DecryptVideo(string videoName, string keyPath, string ivPath) { }
    }
}
