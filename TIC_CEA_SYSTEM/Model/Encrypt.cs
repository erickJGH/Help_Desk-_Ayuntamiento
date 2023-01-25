using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace TIC_CEA_SYSTEM.Model
{
    class Encrypt
    {
        public String Encryptions(string Pass)
        {
            string key = "jwey89e09ewhfo24";
            byte[] KeyArray;
            byte[] Encrypting = Encoding.UTF8.GetBytes(Pass);
            KeyArray = Encoding.UTF8.GetBytes(key);
            var tds = new TripleDESCryptoServiceProvider();
            tds.Key = KeyArray;
            tds.Mode = CipherMode.ECB;
            tds.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tds.CreateEncryptor();
            byte[] Result = cTransform.TransformFinalBlock(Encrypting, 0, Encrypting.Length);
            tds.Clear();
            return Convert.ToBase64String(Result, 0, Result.Length);
        }
    }
}
