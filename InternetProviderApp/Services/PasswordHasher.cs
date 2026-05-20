using System;
using System.Security.Cryptography;
using System.Text;

namespace InternetProviderApp.Services
{
    public static class PasswordHasher
    {
        public static string GenerateSalt()
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));
        }

        public static string HashPassword(string password, string salt)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            return Convert.ToBase64String(sha256.ComputeHash(bytes));
        }

        public static bool Verify(string password, string salt, string expectedHash)
        {
            return HashPassword(password, salt) == expectedHash;
        }
    }
}