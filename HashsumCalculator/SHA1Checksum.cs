using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashsumCalculator
{
    internal static class SHA1Checksum
    {
        public static string GetSHA1Checksum(string path)
        {
            try
            {
                using FileStream fs = File.OpenRead(path);
                using BufferedStream bs = new(fs);
                using SHA1 sha1 = SHA1.Create();
                var hash = sha1.ComputeHash(bs);
                var formatted = new StringBuilder(2 * hash.Length);

                foreach (byte b in hash)
                {
                    formatted.AppendFormat("{0:X2}", b);
                }

                return formatted.ToString();
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA1", e.Message);

                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA1", e.Message);
                return $"Access Exception: {e.Message}";
            }
        }

        public static string GetSHA1Checksum(byte[] buffer)
        {
            try
            {
                using SHA1 sha1 = SHA1.Create();
                var hash = sha1.ComputeHash(buffer);

                var formatted = new StringBuilder(2 * hash.Length);

                foreach (byte b in hash)
                {
                    formatted.AppendFormat("{0:X2}", b);
                }

                return formatted.ToString();
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA1", e.Message);

                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA1", e.Message);
                return $"Access Exception: {e.Message}";
            }
        }
    }
}
