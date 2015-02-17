using System.Globalization;

namespace Fesslersoft.Extensions
{
    public static  class CharacterExtensions
    {
        /// <summary>
        /// Determines whether the specified input character is a vowel.
        /// </summary>
        /// <param name="inputChar">The input character.</param>
        /// <returns>returns true / false</returns>
        public static bool IsVowel(this char inputChar)
        {
            var checkStr = inputChar.ToString(CultureInfo.InvariantCulture).ToUpper();
            return (checkStr == "A" || checkStr == "E" || checkStr == "I" || checkStr == "O" || checkStr == "U");
        }
    }
}
