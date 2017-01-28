namespace FailOverTips
{
    using System.Data.Common;

    /// <summary>
    /// User of the failOver component should reference this abstract interface in order to
    /// avoid a hard dependency with concreta class
    /// </summary>
    public interface IConnectionManager
    {
        DbConnection GetConnection(DbEnum targetDB);
    }
}
