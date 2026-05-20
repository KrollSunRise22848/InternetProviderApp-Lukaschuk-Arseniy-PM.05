using InternetProviderApp.Forms;
using InternetProviderApp.Data;
using System;
using System.Windows.Forms;

namespace InternetProviderApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseInitializer.Initialize();
            SeedAdmin();
            Application.Run(new LoginForm());
        }

        static void SeedAdmin()
        {
            var repo = new UserRepository();
            if (!repo.LoginExists("admin"))
                repo.CreateUser("admin", "admin123", "Администратор", 1);
            if (!repo.LoginExists("operator"))
                repo.CreateUser("operator", "oper123", "Оператор", 2);
            if (!repo.LoginExists("user"))
                repo.CreateUser("user", "user123", "Обычный пользователь", 3);
        }
    }
}