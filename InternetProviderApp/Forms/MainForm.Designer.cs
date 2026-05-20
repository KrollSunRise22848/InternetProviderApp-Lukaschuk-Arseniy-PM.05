namespace InternetProviderApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            абонентыToolStripMenuItem = new ToolStripMenuItem();
            тарифыToolStripMenuItem = new ToolStripMenuItem();
            заявкиToolStripMenuItem = new ToolStripMenuItem();
            usersMenuItem = new ToolStripMenuItem();
            loginAttemptsMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblWelcome = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            dateLabel = new ToolStripStatusLabel();
            userLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DodgerBlue;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { абонентыToolStripMenuItem, тарифыToolStripMenuItem, заявкиToolStripMenuItem, usersMenuItem, loginAttemptsMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(672, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // абонентыToolStripMenuItem
            // 
            абонентыToolStripMenuItem.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            абонентыToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            абонентыToolStripMenuItem.Name = "абонентыToolStripMenuItem";
            абонентыToolStripMenuItem.Size = new Size(100, 22);
            абонентыToolStripMenuItem.Text = "Абоненты ";
            абонентыToolStripMenuItem.Click += абонентыToolStripMenuItem_Click;
            // 
            // тарифыToolStripMenuItem
            // 
            тарифыToolStripMenuItem.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            тарифыToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            тарифыToolStripMenuItem.Name = "тарифыToolStripMenuItem";
            тарифыToolStripMenuItem.Size = new Size(86, 22);
            тарифыToolStripMenuItem.Text = "Тарифы ";
            тарифыToolStripMenuItem.Click += тарифыToolStripMenuItem_Click;
            // 
            // заявкиToolStripMenuItem
            // 
            заявкиToolStripMenuItem.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            заявкиToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            заявкиToolStripMenuItem.Size = new Size(79, 22);
            заявкиToolStripMenuItem.Text = "Заявки ";
            заявкиToolStripMenuItem.Click += заявкиToolStripMenuItem_Click;
            // 
            // usersMenuItem
            // 
            usersMenuItem.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            usersMenuItem.ForeColor = SystemColors.ControlLight;
            usersMenuItem.Name = "usersMenuItem";
            usersMenuItem.Size = new Size(132, 22);
            usersMenuItem.Text = "Пользователи ";
            usersMenuItem.Click += usersMenuItem_Click;
            // 
            // loginAttemptsMenuItem
            // 
            loginAttemptsMenuItem.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            loginAttemptsMenuItem.ForeColor = SystemColors.ControlLight;
            loginAttemptsMenuItem.Name = "loginAttemptsMenuItem";
            loginAttemptsMenuItem.Size = new Size(134, 22);
            loginAttemptsMenuItem.Text = "Журнал входов";
            loginAttemptsMenuItem.Click += loginAttemptsMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            выходToolStripMenuItem.ForeColor = SystemColors.ControlLight;
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(72, 22);
            выходToolStripMenuItem.Text = "Выход ";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 33);
            panel1.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(184, 16);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 18);
            lblWelcome.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel, dateLabel, userLabel });
            statusStrip1.Location = new Point(0, 518);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(672, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(38, 17);
            statusLabel.Text = "Готов";
            // 
            // dateLabel
            // 
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(35, 17);
            dateLabel.Text = "Дата:";
            // 
            // userLabel
            // 
            userLabel.Name = "userLabel";
            userLabel.RightToLeftAutoMirrorImage = true;
            userLabel.Size = new Size(87, 17);
            userLabel.Text = "Пользователь:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(672, 540);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem абонентыToolStripMenuItem;
        private ToolStripMenuItem тарифыToolStripMenuItem;
        private ToolStripMenuItem заявкиToolStripMenuItem;
        private ToolStripMenuItem loginAttemptsMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem usersMenuItem;
        private Panel panel1;
        private Label lblWelcome;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStripStatusLabel dateLabel;
        private ToolStripStatusLabel userLabel;
    }
}