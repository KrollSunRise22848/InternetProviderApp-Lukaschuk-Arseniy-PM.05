using System;
using System.Windows.Forms;
using InternetProviderApp.Data;
using InternetProviderApp.Services;
using InternetProviderApp.Models;

namespace InternetProviderApp.Forms
{
    public partial class LoginForm : Form
    {
        private CaptchaService _captcha = new CaptchaService();
        private AuthService _auth;

        public LoginForm()
        {
            InitializeComponent();
            _auth = new AuthService(new UserRepository());
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblCaptcha.Text = _captcha.Generate() ?? "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    var dummy = _auth.Login("", "");
                }
                catch (InvalidOperationException ex) when (ex.Message.Contains("заблокирован"))
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                    return;
                }
                catch { } 

                if (!_captcha.Validate(txtCaptcha.Text))
                {
                    _auth.RegisterFailedAttempt(txtLogin.Text.Trim(), "Неверная CAPTCHA");
                    lblCaptcha.Text = _captcha.Generate();
                    txtCaptcha.Clear();
                    MessageBox.Show("CAPTCHA введена неверно.", "Ошибка");
                    return;
                }

                User user = _auth.Login(txtLogin.Text.Trim(), txtPassword.Text);
                MainForm main = new MainForm(user);
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                lblCaptcha.Text = _captcha.Generate();
                txtCaptcha.Clear();
                MessageBox.Show(ex.Message, "Ошибка входа");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }
    }
}