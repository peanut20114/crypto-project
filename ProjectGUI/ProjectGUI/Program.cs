using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///         
        public static string UserID;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sign_In());
        }
    }

    internal class User
    {
        public string ID { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string ECC_private_Key { get; set; }
        public string PassWord { get; set; }
    }
}
