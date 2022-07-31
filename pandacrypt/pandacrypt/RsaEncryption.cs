using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace pandacrypt
{
    public class RsaEncryption
    {
        public static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
       
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public RsaEncryption()
        {
            _privateKey = rsa.ExportParameters(true);
            _publicKey = rsa.ExportParameters(false);
            

        }


        public void exportPriv(StreamWriter path)
        {
            rsa.ImportParameters(_privateKey);
            exportPrivKey.ExportPrivateKey(rsa, path);
            

        }
        public void KeySize()
        {
            Console.WriteLine(rsa.KeySize);
        }

        public static string GetPublicKey()
        {
      
            return rsa.ToXmlString(false);
        }
        public string GetPrivateKey()
        {
            return rsa.ToXmlString(true);
        }

        public string Encrypt(string plainText)
        {
            rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(_publicKey);
            var data = Encoding.UTF8.GetBytes(plainText);
            var cypher = rsa.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }
        public string Decrypt(string cypher)
        {
            var dataBytes = Convert.FromBase64String(cypher);
            rsa.ImportParameters(_privateKey);
            var decrypted = rsa.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(decrypted);
        }

        


    }
}
