namespace InternetProviderApp.Forms
{
    partial class EditRequestForm
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
            cmbSubscriber = new ComboBox();
            cmbTariff = new ComboBox();
            dtpDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbSubscriber
            // 
            cmbSubscriber.FormattingEnabled = true;
            cmbSubscriber.Location = new Point(12, 42);
            cmbSubscriber.Name = "cmbSubscriber";
            cmbSubscriber.Size = new Size(121, 23);
            cmbSubscriber.TabIndex = 0;
            cmbSubscriber.Text = "выбор абонента";
            // 
            // cmbTariff
            // 
            cmbTariff.FormattingEnabled = true;
            cmbTariff.Location = new Point(149, 42);
            cmbTariff.Name = "cmbTariff";
            cmbTariff.Size = new Size(121, 23);
            cmbTariff.TabIndex = 1;
            cmbTariff.Text = "выбор тарифа";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(294, 42);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(512, 42);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 3;
            cmbStatus.Text = "статус";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(14, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(141, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(dtpDate);
            Controls.Add(cmbTariff);
            Controls.Add(cmbSubscriber);
            Name = "EditRequestForm";
            Text = "EditRequestForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSubscriber;
        private ComboBox cmbTariff;
        private DateTimePicker dtpDate;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}