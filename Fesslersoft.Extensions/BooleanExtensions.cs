using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fesslersoft.Extensions
{
    public static class BooleanExtensions
    {
        /// <summary>
        ///     Converts the value of this instance to its equivalent JSON string representation (either "true" or "false").
        /// </summary>
        /// <param name="boolean"></param>
        /// <returns>string</returns>
        public static string ToJson(this bool boolean)
        {
            return boolean ? "true" : "false";
        }
    }
}
