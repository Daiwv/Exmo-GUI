using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Exmo
{
    public partial class Form2 : Form
    {

        public static string Username = "";
        public static string ApiKey = "";
        public static string ApiSec = "";

        public Form2()
        {
            InitializeComponent();
        }


        static byte[] Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytesToBeDecrypted = Convert.FromBase64String(File.ReadAllText("exmo.dat"));
            byte[] passwordBytes = Encoding.UTF8.GetBytes(textBox1.Text);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            try {
                byte[] bytesDecrypted = Decrypt(bytesToBeDecrypted, passwordBytes);
                string output = Encoding.UTF8.GetString(bytesDecrypted);
                string[] output2 = output.Split(',');

                if (output2.Length == 4)
                {
                    Username = output2[0].ToString();
                    ApiKey = output2[1].ToString();
                    ApiSec = output2[2].ToString();

                    this.Hide();
                    Form4 client = new Form4();
                    client.ShowDialog();
                    this.Close();

                }

            }
            catch {
                MessageBox.Show("Bad password!");
            }
        }
    }
}
