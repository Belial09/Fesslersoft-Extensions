using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fesslersoft.Extensions
{
    public static class DateExtensions
    {
        /// <summary>
        /// Returns the Hour Difference of two Datetimes as Double Value.
        /// </summary>
        /// <param name="dateOne">The original date.</param>
        /// <param name="dateTwo">The Datei to be Checked against the Original Date.</param>
        /// <returns></returns>
        public static Double DifferenceInHours(this DateTime dateOne, DateTime dateTwo)
        {
            return (dateOne - dateTwo).TotalHours;
        }
    }
}
