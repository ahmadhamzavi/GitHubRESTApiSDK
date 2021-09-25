using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace GitHubRESTApiSDK
{
    public static class StringExtensions
    {
        public static bool IsNotNullOrWhiteSpace(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            return false;
        }
        public static bool IsNullOrWhiteSpace(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            return false;
        }
        public static string ToBase64(this string str)
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes(str));
        }
        public static bool IsBase64(this string base64String)
        {
            // Credit: oybek https://stackoverflow.com/users/794764/oybek
            if (string.IsNullOrEmpty(base64String) || base64String.Length % 4 != 0
               || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
                return false;

            try
            {
                Convert.FromBase64String(base64String);
                return true;
            }
            catch { }
            return false;
        }
    }
}
