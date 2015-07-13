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

        /// <summary>
        /// Returns a substring containing a specified number of characters from a string.
        /// </summary>
        /// <param name="input">String expression from which characters are returned.</param>
        /// <param name="length">Numeric expression indicating how many characters to return. If 0, a zero-length string ("") is returned. If greater than or equal to the number of characters in string, the entire string is returned.</param>
        /// <returns>Returns a substring containing a specified number of characters from the beginning (left side) of a string.</returns>
        public static String Left(this string input, int length)
        {
            var result = "";
            if ((input.Length <= 0)) return result;
            if ((length > input.Length))
            {
                length = input.Length;
            }
            result = input.Substring(0, length);
            return result;
        }

        /// <summary>
        /// Returns a substring containing a specified number of characters from a string.
        /// </summary>
        /// <param name="input">String expression from which characters are returned.</param>
        /// <param name="length">Character position in string at which the part to be taken begins.</param>
        /// <returns>Returns a substring containing a specified number of characters from a string.</returns>
        public static String Mid(string input, int start, int length)
        {
            var result = "";
            if (((input.Length <= 0) || (start >= input.Length))) return result;
            if ((start + length > input.Length))
            {
                length = (input.Length - start);
            }
            result = input.Substring(start, length);
            return result;
        }

        /// <summary>
        /// Returns a substring containing a specified number of characters from the end (right side) of a string.
        /// </summary>
        /// <param name="input">String expression from which the rightmost characters are returned.</param>
        /// <param name="length">Numeric expression indicating how many characters to return. If 0, a zero-length string ("") is returned. If greater than or equal to the number of characters in string, the entire string is returned.</param>
        /// <returns>Returns a substring containing a specified number of characters from the end (right side) of a string.</returns>
        public static String Right(this string input, int length)
        {
            var result = "";
            if ((input.Length <= 0)) return result;
            if ((length > input.Length))
            {
                length = input.Length;
            }
            result = input.Substring((input.Length - length), length);
            return result;
        }
    }
}