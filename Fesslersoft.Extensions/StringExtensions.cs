using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fesslersoft.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if a String is not Null, not Empty and not Whitespace.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns></returns>
        public static bool IsNotNullOrEmptyOrWhiteSpace(this string input)
        {
            return !input.IsNullOrEmptyOrWhiteSpace();
        }

        /// <summary>
        /// Checks if a String is Null, Empty or Whitespace.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns></returns>
        public static bool IsNullOrEmptyOrWhiteSpace(this string input)
        {
            return string.IsNullOrEmpty(input) || input.Trim() == string.Empty;
        }


        /// <summary>
        /// Changes the encoding of a string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="encoding">The new Encoding.</param>
        /// <returns>A new encoded String</returns>
        public static string ChangeEncoding(this string input, Encoding encoding)
        {
            var bytes = encoding.GetBytes(input);
            return encoding.GetString(bytes);
        }
    }
}
