namespace LibSqewl
{
    public interface ISqlUtils
    {
        Task<bool> CheckSqlServer(string connectionString);
        string GenerateConnectionString(string serverName);
        string ParseSqlServerToRealName(string serverName);
    }
}