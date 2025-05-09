namespace LibSqewl
{
    public interface IDatabaseQueryExecutor
    {
        Task<List<string>> CreateSqlReader_ThenExecuteAndReturnAllRowsAsync(string connectionString, string query);
        Task<string> ExecuteNonQueryAsync(string connectionString, string query);
    }
}