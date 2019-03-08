using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppEncrypted.Resources
{
    class TripleDESCrypt
    {
        static byte[] encrypted;
        public static string EncryptString(string key, string text)
        {
            string res = "";
            TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider();
            UTF8Encoding uTF = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            triple.Key = md5.ComputeHash(uTF.GetBytes(key));
            triple.Mode = CipherMode.ECB;
            triple.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = triple.CreateEncryptor();
            encrypted = trans.TransformFinalBlock(uTF.GetBytes(text), 0, text.Length);
            res = Convert.ToBase64String(encrypted);


            return res;
        }
        public static string DecryptString(string key,string text)
        {
            string res = "";
            TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider();
            UTF8Encoding uTF = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            triple.Key = md5.ComputeHash(uTF.GetBytes(key));
            triple.Mode = CipherMode.ECB;
            triple.Padding = PaddingMode.PKCS7;

            ICryptoTransform trans = triple.CreateDecryptor();
            try
            {
                byte[] texts = Convert.FromBase64String(text);
                byte[] decrypted = trans.TransformFinalBlock(texts, 0, texts.Length);
                res = uTF.GetString(decrypted);
            }
            catch (CryptographicException ce)
            {
                return ce.ToString();

            }
            catch (NullReferenceException e)
            {
                return "null";
            }



            return res;

        }
    }
}
