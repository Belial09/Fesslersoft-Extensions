using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fesslersoft.Extensions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Determines if the source object is of Type T.
        /// </summary>
        /// <typeparam name="T">The expected Type of the Object.</typeparam>
        /// <param name="input">The input object.</param>
        /// <returns></returns>
        public static bool IsOfType<T>(this object input)
        {
            return input.IsOfType(typeof(T));
        }

        /// <summary>
        /// Determines if the source object is of Type T.
        /// </summary>
        /// <typeparam name="T">The Type to check</typeparam>
        /// <param name="input">The input object.</param>
        /// <param name="type">The expected Type of the Object.</param>
        /// <returns></returns>
        public static bool IsOfType(this object input, Type type)
        {
            return (input.GetType() == type);
        }

        public static bool IsNull(this object source)
        {
            return source == null;
        }
    }
}
