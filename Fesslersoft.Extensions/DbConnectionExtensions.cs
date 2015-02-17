#region

using System.Data;
using System.Data.Common;

#endregion

namespace Fesslersoft.Extensions
{
    public static class DbConnectionExtensions
    {
        /// <summary>
        /// Opens the DbConnection if its State is closed.
        /// </summary>
        /// <param name="connection">The connection to open if State is closed.</param>
        public static void OpenIfClosed(this DbConnection connection)
        {
            if (connection != null && connection.ConnectionString != string.Empty && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}