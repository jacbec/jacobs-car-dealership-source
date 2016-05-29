using System;
using System.Security.Cryptography;
using System.Text;

namespace JacobsCarDealership
{
    class Encrypt
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        //Method to change generateSHA256Hash to a hex string
        private static String byteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            return hex.ToString();
        }

        //Method to create the salt
        public static String createSalt()
        {
            byte[] buff = new byte[32];
            rngCsp.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        //Method to create SHA256 hash
        public static String generateSHA256Hash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);

            SHA256Managed hashString = new SHA256Managed();

            byte[] hash = hashString.ComputeHash(bytes);

            return byteArrayToHexString(hash);
        }
    }
}

