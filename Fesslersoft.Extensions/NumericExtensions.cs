using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fesslersoft.Extensions
{
    public static class NumericExtensions
    {
        public static bool IsPowerOfTwo(this ulong input)
        {
            return (input != 0) && ((input & (input - 1)) == 0);
        }
    }
}
