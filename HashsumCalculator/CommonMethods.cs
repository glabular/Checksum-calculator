using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashsumCalculator
{
    internal static class CommonMethods
    {
        internal static void ShowPopupErrorMessagebox(string caption, string text)
        {
            MessageBox.Show(text, caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
        }

        internal static string ByteArrayToString(byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append($"{array[i]:X2}");
            }

            return sb.ToString();
        }
    }
}
