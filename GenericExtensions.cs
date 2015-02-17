#region

using System;

#endregion

namespace Fesslersoft.Extensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Determines whether if a numeric value is larger than the other.
        /// </summary>
        /// <typeparam name="TOne">The type of the Numeric Value to check.</typeparam>
        /// <typeparam name="TTwo">The type of the Numeric Value to check.</typeparam>
        /// <param name="input">The input value.</param>
        /// <param name="numberToCheck">The number to check.</param>
        /// <returns></returns>
        public static bool IsLargerThan<TOne, TTwo>(this TOne input, TTwo numberToCheck) where TOne : struct,IComparable,IComparable<TOne>,IConvertible,IEquatable<TOne>,IFormattable
                                                                                         where TTwo : struct,IComparable,IComparable<TTwo>,IConvertible,IEquatable<TTwo>,IFormattable
        {
            return Convert.ToDouble(input) > Convert.ToDouble(numberToCheck);
        }

        /// <summary>
        /// Determines whether if a numeric value is smaller than the other.
        /// </summary>
        /// <typeparam name="TOne">The type of the Numeric Value to check.</typeparam>
        /// <typeparam name="TTwo">The type of the Numeric Value to check.</typeparam>
        /// <param name="input">The input value.</param>
        /// <param name="numberToCheck">The number to check.</param>
        /// <returns></returns>
        public static bool IsSmallerThan<TOne, TTwo>(this TOne input, TTwo numberToCheck)
            where TOne : struct,IComparable, IComparable<TOne>, IConvertible, IEquatable<TOne>, IFormattable
            where TTwo : struct,IComparable, IComparable<TTwo>, IConvertible, IEquatable<TTwo>, IFormattable
        {
            return Convert.ToDouble(input) < Convert.ToDouble(numberToCheck);
        }
    }
}    