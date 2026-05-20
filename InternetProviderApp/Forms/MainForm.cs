using System;
using System.Windows.Forms;
using InternetProviderApp.Models;

namespace InternetProviderApp.Forms
{
    public partial class MainForm : Form
    {
        private User _currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            ApplyRolePermissions();
            this.FormClosed += (s, e) => Application.Exit();

            dateLabel.Text = $"Дата: {DateTime.Now.ToLongDateString()}";
            userLabel.Text = $"Пользователь: {_currentUser.Login}";
            statusLabel.Text = "Готово";
            lblWelcome.Text = $"Добро пожаловать, {_currentUser.FullName}!";
        }

        private void ApplyRolePermissions()
        {
            bool isAdmin = _currentUser.RoleName == "admin";
            usersMenuItem.Visible = isAdmin;
            loginAttemptsMenuItem.Visible = isAdmin;
        }

        private void абонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SubscribersForm(_currentUser);
            form.ShowDialog();
        }

        private void тарифыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TariffsForm(_currentUser);
            form.ShowDialog();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RequestsForm(_currentUser);
            form.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void usersMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UsersForm();
            form.ShowDialog();
        }

        private void loginAttemptsMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LoginAttemptsForm();
            form.ShowDialog();
        }
    }
}