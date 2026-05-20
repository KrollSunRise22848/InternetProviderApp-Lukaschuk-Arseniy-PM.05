using Microsoft.Data.Sqlite;

namespace InternetProviderApp.Data
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();

            string systemTables = @"
                CREATE TABLE IF NOT EXISTS Roles (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL UNIQUE
                );
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Login TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    PasswordSalt TEXT NOT NULL,
                    FullName TEXT NOT NULL,
                    RoleId INTEGER NOT NULL,
                    IsActive INTEGER NOT NULL DEFAULT 1,
                    CreatedAt TEXT NOT NULL,
                    FOREIGN KEY (RoleId) REFERENCES Roles(Id)
                );
                CREATE TABLE IF NOT EXISTS LoginAttempts (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserLogin TEXT NOT NULL,
                    IsSuccess INTEGER NOT NULL,
                    Message TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL
                );
                CREATE TABLE IF NOT EXISTS Tariffs (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL UNIQUE,
                    Price REAL NOT NULL,
                    Speed INTEGER NOT NULL
                );
                CREATE TABLE IF NOT EXISTS Subscribers (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Phone TEXT NOT NULL,
                    Address TEXT NOT NULL,
                    ContractNumber TEXT NOT NULL UNIQUE,
                    TariffId INTEGER NOT NULL,
                    IsActive INTEGER NOT NULL DEFAULT 1,
                    FOREIGN KEY (TariffId) REFERENCES Tariffs(Id)
                );
                CREATE TABLE IF NOT EXISTS Requests (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubscriberId INTEGER NOT NULL,
                    TariffId INTEGER NOT NULL,
                    Date TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    FOREIGN KEY (SubscriberId) REFERENCES Subscribers(Id),
                    FOREIGN KEY (TariffId) REFERENCES Tariffs(Id)
                );
            ";
            Execute(connection, systemTables);

            Execute(connection, @"
                INSERT OR IGNORE INTO Roles (Id, Name) VALUES (1, 'admin');
                INSERT OR IGNORE INTO Roles (Id, Name) VALUES (2, 'operator');
                INSERT OR IGNORE INTO Roles (Id, Name) VALUES (3, 'user');
            ");

            Execute(connection, @"
                INSERT OR IGNORE INTO Tariffs (Id, Name, Price, Speed) VALUES (1, 'Старт', 300, 30);
                INSERT OR IGNORE INTO Tariffs (Id, Name, Price, Speed) VALUES (2, 'Оптима', 600, 100);
                INSERT OR IGNORE INTO Tariffs (Id, Name, Price, Speed) VALUES (3, 'Профи', 1200, 300);
            ");
        }

        private static void Execute(SqliteConnection connection, string sql)
        {
            using var cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }
}