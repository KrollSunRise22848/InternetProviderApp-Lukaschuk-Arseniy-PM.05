namespace InternetProviderApp.Forms
{
    partial class LoginAttemptsForm
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
            dgvAttempts = new DataGridView();
            DataGridView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttempts).BeginInit();
            SuspendLayout();
            // 
            // dgvAttempts
            // 
            dgvAttempts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttempts.Location = new Point(1, -1);
            dgvAttempts.Name = "dgvAttempts";
            dgvAttempts.Size = new Size(798, 380);
            dgvAttempts.TabIndex = 0;
            // 
            // DataGridView
            // 
            DataGridView.Location = new Point(307, 401);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(133, 37);
            DataGridView.TabIndex = 1;
            DataGridView.Text = "Обновить";
            DataGridView.UseVisualStyleBackColor = true;
            DataGridView.Click += btnRefresh_Click;
            // 
            // LoginAttemptsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView);
            Controls.Add(dgvAttempts);
            Name = "LoginAttemptsForm";
            Text = "LoginAttemptsForm";
            ((System.ComponentModel.ISupportInitialize)dgvAttempts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAttempts;
        private Button DataGridView;
    }
}