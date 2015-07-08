#region

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

#endregion

namespace Fesslersoft.Extensions
{
    public static class StringExtensions
    {

        /// <summary>
        /// Changes the encoding of a string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="sourceEncoding">The source encoding.</param>
        /// <param name="targetEncoding">The target encoding.</param>
        /// <returns>A new encoded String</returns>
        public static string ChangeEncoding(this string input, Encoding sourceEncoding, Encoding targetEncoding)
        {
            byte[] utfBytes = sourceEncoding.GetBytes(input);
            byte[] isoBytes = Encoding.Convert(sourceEncoding, targetEncoding, utfBytes);
            return targetEncoding.GetString(isoBytes);
        }

        /// <summary>
        ///     Checks if a String is not Null, not Empty and not Whitespace.
        /// </summary>
        /// <param name="input">The input string to test.</param>
        /// <returns>bool value wheter a String Is NotNullOrEmptyOrWhiteSpace or not</returns>
        public static bool IsNotNullOrEmptyOrWhiteSpace(this string input)
        {
            return !input.IsNullOrEmptyOrWhiteSpace();
        }

        /// <summary>
        ///     Checks if a String is Null, Empty or Whitespace.
        /// </summary>
        /// <param name="input">The input string to test.</param>
        /// <returns>bool value wheter a String Is IsNullOrEmptyOrWhiteSpace or not</returns>
        public static bool IsNullOrEmptyOrWhiteSpace(this string input)
        {
            return string.IsNullOrEmpty(input) || input.Trim() == string.Empty;
        }


        /// <summary>
        /// Converts a String into Securestring.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <returns>The input String as Securestring.</returns>
        public static SecureString ToSecureString(this string source)
        {
            if (source.IsNullOrEmptyOrWhiteSpace())
            {
                return null;
            }
            var result = new SecureString();
            foreach (var c in source)
            {
                result.AppendChar(c);
            }
            return result;
        }

        /// <summary>
        ///  Converts a Securestring into String.
        /// </summary>
        /// <param name="source">The source Securestring.</param>
        /// <returns>The input Securestring as String.</returns>
        public static string ToUnsecureString (this SecureString source)
        {
            var returnValue = IntPtr.Zero;
            try
            {
                returnValue = Marshal.SecureStringToGlobalAllocUnicode(source);
                return Marshal.PtrToStringUni(returnValue);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(returnValue);
            }
        }
    }
}