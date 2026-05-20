using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using InternetProviderApp.Data;

namespace InternetProviderApp.Forms
{
    public partial class LoginAttemptsForm : Form
    {
        public LoginAttemptsForm()
        {
            InitializeComponent();
            LoadAttempts();
        }

        private void LoadAttempts()
        {
            using var connection = DbConnectionFactory.Create();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, UserLogin, 
                       CASE WHEN IsSuccess = 1 THEN 'Успех' ELSE 'Ошибка' END AS Result,
                       Message, CreatedAt
                FROM LoginAttempts
                ORDER BY CreatedAt DESC
            ";
            var table = new System.Data.DataTable();
            using var reader = cmd.ExecuteReader();
            table.Load(reader);
            dgvAttempts.DataSource = table;
            dgvAttempts.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAttempts();
        }
    }
}