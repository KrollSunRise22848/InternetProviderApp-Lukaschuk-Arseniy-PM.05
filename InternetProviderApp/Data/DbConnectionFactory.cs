using Microsoft.Data.Sqlite;

namespace InternetProviderApp.Data
{
    public static class DbConnectionFactory
    {
        private const string ConnectionString = "Data Source=internet_provider.db";
        public static SqliteConnection Create() => new SqliteConnection(ConnectionString);
    }
}