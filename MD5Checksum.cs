using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashsumCalculator
{
    internal static class MD5Checksum
    {
        internal static string GetMD5Checksum(byte[] buffer)
        {
            try
            {
                using MD5 md5 = MD5.Create();
                var checkSum = md5.ComputeHash(buffer);

                return BitConverter.ToString(checkSum).Replace("-", string.Empty);
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать MD5", e.Message);
                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать MD5", e.Message);
                return $"Access Exception: {e.Message}";
            }
        }

        internal static string GetMD5Checksum(string path)
        {
            try
            {
                using FileStream fs = File.OpenRead(path);
                using MD5 md5 = MD5.Create();
                var checkSum = md5.ComputeHash(fs);

                return BitConverter.ToString(checkSum).Replace("-", string.Empty);
            }
            catch (IOException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать MD5", e.Message);
                return $"I/O Exception: {e.Message}";
            }
            catch (UnauthorizedAccessException e)
            {
                CommonMethods.ShowPopupErrorMessagebox("Невозможно посчитать MD5", e.Message);
                return $"Access Exception: {e.Message}";
            }
        }
    }
}
