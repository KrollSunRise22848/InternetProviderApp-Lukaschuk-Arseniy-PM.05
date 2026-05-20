namespace InternetProviderApp.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txtFullName = new TextBox();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            btnCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(143, 147);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(228, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(143, 196);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(228, 23);
            txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 243);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(143, 295);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(228, 23);
            txtConfirm.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ButtonShadow;
            btnCreate.BackgroundImage = (Image)resources.GetObject("btnCreate.BackgroundImage");
            btnCreate.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreate.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold);
            btnCreate.ForeColor = SystemColors.ControlText;
            btnCreate.Location = new Point(166, 396);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(142, 42);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 155);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 204);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 251);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 303);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 8;
            label4.Text = "Поддтвердите пароль:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(17, 9);
            label5.Name = "label5";
            label5.Size = new Size(425, 21);
            label5.TabIndex = 10;
            label5.Text = "РЕГИСТРАЦИЯ В ЛИЧНЫЙ КАБИНЕТ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(454, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(txtFullName);
            DoubleBuffered = true;
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Button btnCreate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}