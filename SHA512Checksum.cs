using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashsumCalculator
{
    internal static class SHA512Checksum
    {
        internal static string GetSHA512Checksum(string path)
        {
            try
            {
                using var mySHA512 = SHA512.Create();
                using FileStream fileStream = File.OpenRead(path);
                fileStream.Position = 0;
                var hashValue = mySHA512.ComputeHash(fileStream);

                return CommonMethods.ByteArrayToString(hashValue);
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA512", e.Message);
                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                return $"Access Exception: {e.Message}";
            }
        }

        internal static string GetSHA512Checksum(byte[] buffer)
        {
            try
            {
                using var mySHA512 = SHA512.Create();
                var hashValue = mySHA512.ComputeHash(buffer);

                return CommonMethods.ByteArrayToString(hashValue);
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA512", e.Message);
                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                return $"Access Exception: {e.Message}";
            }
        }
    }
}
