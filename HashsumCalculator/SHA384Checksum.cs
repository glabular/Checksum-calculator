using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashsumCalculator
{
    internal static class SHA384Checksum
    {
        internal static string GetSHA384Checksum(string path)
        {
            try
            {
                using var mySHA384 = SHA384.Create();
                using FileStream fileStream = File.OpenRead(path);
                fileStream.Position = 0;
                var hashValue = mySHA384.ComputeHash(fileStream);

                return CommonMethods.ByteArrayToString(hashValue);
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA348", e.Message);
                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA348", e.Message);
                return $"Access Exception: {e.Message}";
            }
        }

        internal static string GetSHA384Checksum(byte[] buffer)
        {
            try
            {
                using var mySHA384 = SHA384.Create();
                var hashValue = mySHA384.ComputeHash(buffer);

                return CommonMethods.ByteArrayToString(hashValue);
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA348", e.Message);
                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать SHA348", e.Message);
                return $"Access Exception: {e.Message}";
            }
        }
    }
}
