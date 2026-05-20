using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using InternetProviderApp.Data;

namespace InternetProviderApp.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT u.Id, u.Login, u.FullName, r.Name AS Role, 
                       CASE WHEN u.IsActive = 1 THEN 'Да' ELSE 'Нет' END AS Active
                FROM Users u
                JOIN Roles r ON r.Id = u.RoleId
                ORDER BY u.Id
            ";
            var table = new System.Data.DataTable();
            using var reader = cmd.ExecuteReader();
            table.Load(reader);
            dgvUsers.DataSource = table;
            dgvUsers.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}