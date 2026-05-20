using Microsoft.Data.Sqlite;
using InternetProviderApp.Models;
using System;

namespace InternetProviderApp.Data
{
    public class UserRepository
    {
        public User? FindByLogin(string login)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT u.Id, u.Login, u.PasswordHash, u.PasswordSalt, u.FullName, u.IsActive, r.Name AS RoleName
                FROM Users u
                JOIN Roles r ON r.Id = u.RoleId
                WHERE u.Login = $login
            ";
            cmd.Parameters.AddWithValue("$login", login);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Id = reader.GetInt32(0),
                    Login = reader.GetString(1),
                    PasswordHash = reader.GetString(2),
                    PasswordSalt = reader.GetString(3),
                    FullName = reader.GetString(4),
                    IsActive = reader.GetInt32(5) == 1,
                    RoleName = reader.GetString(6)
                };
            }
            return null;
        }

        public bool LoginExists(string login)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Login = $login";
            cmd.Parameters.AddWithValue("$login", login);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public void CreateUser(string login, string password, string fullName, int roleId)
        {
            string salt = Services.PasswordHasher.GenerateSalt();
            string hash = Services.PasswordHasher.HashPassword(password, salt);
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Users (Login, PasswordHash, PasswordSalt, FullName, RoleId, IsActive, CreatedAt)
                VALUES ($login, $hash, $salt, $fullName, $roleId, 1, $createdAt)
            ";
            cmd.Parameters.AddWithValue("$login", login);
            cmd.Parameters.AddWithValue("$hash", hash);
            cmd.Parameters.AddWithValue("$salt", salt);
            cmd.Parameters.AddWithValue("$fullName", fullName);
            cmd.Parameters.AddWithValue("$roleId", roleId);
            cmd.Parameters.AddWithValue("$createdAt", DateTime.Now.ToString("s"));
            cmd.ExecuteNonQuery();
        }

        public void AddLoginAttempt(string login, bool success, string message)
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO LoginAttempts (UserLogin, IsSuccess, Message, CreatedAt)
                VALUES ($login, $success, $message, $createdAt)
            ";
            cmd.Parameters.AddWithValue("$login", login);
            cmd.Parameters.AddWithValue("$success", success ? 1 : 0);
            cmd.Parameters.AddWithValue("$message", message);
            cmd.Parameters.AddWithValue("$createdAt", DateTime.Now.ToString("s"));
            cmd.ExecuteNonQuery();
        }
    }
}