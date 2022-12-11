using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashsumCalculator
{
    internal class SHA256Checksum
    {
        public static string GetSHA256Checksum(string path)
        {
            try
            {
                using SHA256 mySHA256 = SHA256.Create();
                using FileStream fileStream = File.OpenRead(path);
                fileStream.Position = 0;
                var hashValue = mySHA256.ComputeHash(fileStream);

                return CommonMethods.ByteArrayToString(hashValue);
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA256", e.Message);
                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA256", e.Message);
                return $"Access Exception: {e.Message}";
            }
        }

        public static string GetSHA256Checksum(byte[] buffer)
        {
            try
            {
                using SHA256 mySHA256 = SHA256.Create();
                var hashValue = mySHA256.ComputeHash(buffer);

                return CommonMethods.ByteArrayToString(hashValue);
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA256", e.Message);
                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA256", e.Message);
                return $"Access Exception: {e.Message}";
            }
        }
    }
}
