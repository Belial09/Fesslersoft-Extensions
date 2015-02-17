namespace Fesslersoft.Extensions
{
    public static class RandomExtensions
    {
        /// <summary>
        /// Flips a coin.
        /// </summary>
        /// <param name="rand">The rand.</param>
        /// <returns>Returns a Random Boolean Value</returns>
        public static bool FlipCoin(this System.Random rand)
        {
            return rand.Next(2) == 0;
        }
    }
}
