namespace InternetProviderApp.Forms
{
    partial class EditSubscriberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSubscriberForm));
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtContract = new TextBox();
            comboBoxTariff = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            checkBoxActive = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 284);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(214, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(256, 284);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(126, 23);
            txtPhone.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(416, 284);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(129, 23);
            txtAddress.TabIndex = 2;
            // 
            // txtContract
            // 
            txtContract.Location = new Point(600, 284);
            txtContract.Name = "txtContract";
            txtContract.Size = new Size(115, 23);
            txtContract.TabIndex = 3;
            // 
            // comboBoxTariff
            // 
            comboBoxTariff.FormattingEnabled = true;
            comboBoxTariff.Location = new Point(12, 108);
            comboBoxTariff.Name = "comboBoxTariff";
            comboBoxTariff.Size = new Size(121, 23);
            comboBoxTariff.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(284, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(381, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(175, 112);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(71, 19);
            checkBoxActive.TabIndex = 8;
            checkBoxActive.Text = "Активен";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 90);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 9;
            label1.Text = "Пользователь:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 266);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 10;
            label2.Text = "ФИО:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 266);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 11;
            label3.Text = "Номер телефона:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 266);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 12;
            label4.Text = "Адресс:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(600, 266);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 13;
            label5.Text = "Номер договора:";
            // 
            // EditSubscriberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(725, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxActive);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(comboBoxTariff);
            Controls.Add(txtContract);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            DoubleBuffered = true;
            Name = "EditSubscriberForm";
            Text = "EditSubscriberForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtContract;
        private ComboBox comboBoxTariff;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox checkBoxActive;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}