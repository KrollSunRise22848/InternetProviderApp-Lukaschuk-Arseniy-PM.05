using System;
using System.Linq;
using System.Windows.Forms;
using InternetProviderApp.Data;
using InternetProviderApp.Models;

namespace InternetProviderApp.Forms
{
    public partial class EditRequestForm : Form
    {
        private Request _request;
        private RequestRepository _repo = new RequestRepository();
        private SubscriberRepository _subRepo = new SubscriberRepository();
        private TariffRepository _tariffRepo = new TariffRepository();

        public EditRequestForm(Request? request)
        {
            InitializeComponent();
            LoadComboBoxes();

            if (request == null)
            {
                _request = new Request { Date = DateTime.Now, Status = "новая" };
                Text = "Добавление заявки";
            }
            else
            {
                _request = request;
                Text = "Редактирование заявки";
                cmbSubscriber.SelectedValue = request.SubscriberId;
                cmbTariff.SelectedValue = request.TariffId;
                dtpDate.Value = request.Date;
                cmbStatus.Text = request.Status;
            }
        }

        private void LoadComboBoxes()
        {
            var subscribers = _subRepo.GetAll();
            cmbSubscriber.DataSource = subscribers;
            cmbSubscriber.DisplayMember = "FullName";
            cmbSubscriber.ValueMember = "Id";

            var tariffs = _tariffRepo.GetAll();
            cmbTariff.DataSource = tariffs;
            cmbTariff.DisplayMember = "Name";
            cmbTariff.ValueMember = "Id";

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "новая", "выполнена", "отменена" });
            cmbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSubscriber.SelectedValue == null || (int)cmbSubscriber.SelectedValue == 0)
            { MessageBox.Show("Выберите абонента"); return; }
            if (cmbTariff.SelectedValue == null || (int)cmbTariff.SelectedValue == 0)
            { MessageBox.Show("Выберите тариф"); return; }

            _request.SubscriberId = (int)cmbSubscriber.SelectedValue;
            _request.TariffId = (int)cmbTariff.SelectedValue;
            _request.Date = dtpDate.Value;
            _request.Status = cmbStatus.Text;

            if (_request.Id == 0)
                _repo.Add(_request);
            else
                _repo.Update(_request);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}