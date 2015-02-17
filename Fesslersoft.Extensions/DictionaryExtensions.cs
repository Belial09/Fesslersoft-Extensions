using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fesslersoft.Extensions
{
    public static class DictionaryExtensions
    {
        /// <summary>
        ///     If the dictionary does not contain an item keyed with <paramref name="key" />, the
        ///     value returned by the <paramref name="lookup" /> method is added to the dictionary --
        ///     even if it is null
        /// </summary>
        public static void AddIfNotExist<TOne, TTwo>(this Dictionary<TOne, TTwo> dictionary, TOne key, Func<TOne, TTwo> lookup)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, lookup(key));
            }
        }
    }
}
