namespace InternetProviderApp.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            lblCaptcha = new Label();
            txtCaptcha = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(169, 89);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(100, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(169, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            // 
            // lblCaptcha
            // 
            lblCaptcha.AutoSize = true;
            lblCaptcha.BackColor = SystemColors.ControlLightLight;
            lblCaptcha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCaptcha.Location = new Point(190, 202);
            lblCaptcha.Name = "lblCaptcha";
            lblCaptcha.Size = new Size(57, 21);
            lblCaptcha.TabIndex = 2;
            lblCaptcha.Text = "label1";
            // 
            // txtCaptcha
            // 
            txtCaptcha.Location = new Point(169, 226);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(100, 23);
            txtCaptcha.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Location = new Point(160, 367);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(313, 388);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 24);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(119, 97);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(119, 142);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(75, 234);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 8;
            label3.Text = "Введите капчу:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(7, 9);
            label4.Name = "label4";
            label4.Size = new Size(408, 27);
            label4.TabIndex = 9;
            label4.Text = "ВХОД В ЛИЧНЫЙ КАБИНЕТ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(427, 424);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtCaptcha);
            Controls.Add(lblCaptcha);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label lblCaptcha;
        private TextBox txtCaptcha;
        private Button btnLogin;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}