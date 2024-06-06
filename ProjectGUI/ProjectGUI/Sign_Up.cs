using System;
using System.Text;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.OpenSsl;
using System.IO;
using System.Threading.Tasks; // Add this namespace for Task

namespace ProjectGUI
{
    public partial class Sign_Up : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "GdfCwWCBpxKuxjX1yZfEr3Tplc1VdaS1YsTIuLLR",
            BasePath = "https://crypto-project-2e5b1-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public Sign_Up()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private void tb_fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_fullName_Click(object sender, EventArgs e)
        {
            tb_Email.Text = string.Empty;
        }

        private void tb_username_Click(object sender, EventArgs e)
        {
            tb_username.Text = string.Empty;
        }

        private void tb_password_Click(object sender, EventArgs e)
        {
            tb_password.Text = string.Empty;
        }

        public static string GenerateRandomNumber()
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 9; i++)
            {
                stringBuilder.Append(random.Next(1, 10));
            }

            return stringBuilder.ToString();
        }

        private async void btn_register_Click(object sender, EventArgs e) // Mark method as async
        {
            GenerateECCKeys(out string privateKeyPem, out string publicKeyPem);

            var data = new User
            {
                UserName = tb_username.Text,
                PassWord = tb_password.Text,
                Email = tb_Email.Text,
                ECC_private_Key = privateKeyPem,
                ECC_public_Key = publicKeyPem
            };
            data.ID = GenerateRandomNumber();
            SetResponse res = await client.SetAsync("USER/" + data.ID, data); // Await the async method call
            User result = res.ResultAs<User>();
            MessageBox.Show("Create account successfully!");
            Sign_In sign_in = new Sign_In();
            sign_in.Show();
            this.Close();
        }

        private static void GenerateECCKeys(out string privateKeyPem, out string publicKeyPem)
        {
            var keyGen = new ECKeyPairGenerator();
            var secureRandom = new SecureRandom();
            var keyGenParam = new KeyGenerationParameters(secureRandom, 256);
            keyGen.Init(keyGenParam);

            AsymmetricCipherKeyPair keyPair = keyGen.GenerateKeyPair();
            AsymmetricKeyParameter privateKey = keyPair.Private;
            AsymmetricKeyParameter publicKey = keyPair.Public;

            privateKeyPem = ConvertKeyToPem(privateKey);
            publicKeyPem = ConvertKeyToPem(publicKey);
        }

        private static string ConvertKeyToPem(AsymmetricKeyParameter key)
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                PemWriter pemWriter = new PemWriter(stringWriter);
                pemWriter.WriteObject(key);
                pemWriter.Writer.Flush();
                return stringWriter.ToString();
            }
        }
    }
}