using System;
using InternetProviderApp.Data;
using InternetProviderApp.Models;

namespace InternetProviderApp.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepo;
        private static int _failedAttempts = 0;
        private static DateTime? _blockedUntil = null;

        public AuthService(UserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public void RegisterFailedAttempt(string login, string reason)
        {
            _failedAttempts++;
            _userRepo.AddLoginAttempt(login, false, reason);

            if (_failedAttempts >= 3)
            {
                _blockedUntil = DateTime.Now.AddSeconds(30);
                _failedAttempts = 0;
            }
        }

        public User Login(string login, string password)
        {
            if (_blockedUntil.HasValue && DateTime.Now < _blockedUntil.Value)
            {
                var remaining = (int)(_blockedUntil.Value - DateTime.Now).TotalSeconds;
                throw new InvalidOperationException($"Вход временно заблокирован на {remaining} секунд.");
            }

            var user = _userRepo.FindByLogin(login);
            if (user == null || !PasswordHasher.Verify(password, user.PasswordSalt, user.PasswordHash) || !user.IsActive)
            {
                RegisterFailedAttempt(login, "Неверный логин или пароль");
                throw new InvalidOperationException("Неверный логин или пароль.");
            }

            _failedAttempts = 0;
            _blockedUntil = null;
            _userRepo.AddLoginAttempt(login, true, "Успешный вход");
            return user;
        }
    }
}