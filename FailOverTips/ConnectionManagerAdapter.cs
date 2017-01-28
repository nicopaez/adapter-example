namespace FailOverTips
{
    using System.Data.Common;
    
    /// <summary>
    /// This class is the adapter between the abstract interface and the concrete statis class
    /// </summary>
    public class ConnectionManagerAdapter : IConnectionManager
    {
        public DbConnection GetConnection(DbEnum targetDB)
        {
            return ConnetionManager.GetConnection(targetDB);
        }
    }
}
