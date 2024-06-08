using Google.Apis.Http;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectGUI
{
    internal class Crypto
    {
        public void EncryptVideo(string videoName)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"python.exe";

            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);

            var script = Path.Combine(exeDir, @"..\..\..\..\crypto-project\AES.py");

            string choice = "encrypt";

            var error = "";
            var result = "";

            psi.Arguments = $"\"{script}\" \"{choice}\" \"{videoName}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            using (Process pro = Process.Start(psi))
            {
                error = pro.StandardOutput.ReadToEnd();
                result = pro.StandardError.ReadToEnd();
            }
        }
    }
}
