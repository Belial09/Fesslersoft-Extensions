using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fesslersoft.Extensions
{
    public static class SizeExtensions
    {
        /// <summary>
        /// Scales the specified size percentual.
        /// </summary>
        /// <param name="size">The original size.</param>
        /// <param name="scalePercent">Percentual Scale Value.</param>
        /// <returns></returns>
        public static Size Scale(this Size size, float scalePercent)
        {
            if (Math.Abs(scalePercent - 1) < float.Epsilon)
            {
                return size;
            }

            var height = (int)(size.Height * (scalePercent / 100));
            var width = (int)(size.Width * (scalePercent / 100));

            return new Size(width, height);
        }
    }
}
