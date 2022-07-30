using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace pandacrypt
{
    public class RsaEncryption
    {
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public RsaEncryption()
        {
            _privateKey = rsa.ExportParameters(true);
            _publicKey = rsa.ExportParameters(false);


        }

        public string GetPublicKey()
        {
           return  rsa.ToXmlString(false);

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
            return cypher.ToString();
        }

        


    }
}
