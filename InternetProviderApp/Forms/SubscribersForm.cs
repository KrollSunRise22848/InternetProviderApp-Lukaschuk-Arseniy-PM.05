using System;
using System.Windows.Forms;
using InternetProviderApp.Data;
using InternetProviderApp.Models;

namespace InternetProviderApp.Forms
{
    public partial class SubscribersForm : Form
    {
        private SubscriberRepository _subRepo = new SubscriberRepository();
        private TariffRepository _tariffRepo = new TariffRepository();
        private User _currentUser;

        public SubscribersForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadData();
            if (_currentUser.RoleName == "user")
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void LoadData()
        {
            dgvSubscribers.DataSource = _subRepo.GetAll(txtSearch.Text);
            if (dgvSubscribers.Columns.Contains("Id"))
                dgvSubscribers.Columns["Id"].Visible = false;
            if (dgvSubscribers.Columns.Contains("TariffId"))
                dgvSubscribers.Columns["TariffId"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e) => EditSubscriber(null);

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSubscribers.CurrentRow == null) return;
            var sub = dgvSubscribers.CurrentRow.DataBoundItem as Subscriber;
            if (sub == null) return;
            EditSubscriber(sub);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubscribers.CurrentRow == null) return;
            var sub = dgvSubscribers.CurrentRow.DataBoundItem as Subscriber;
            if (sub == null) return;
            if (MessageBox.Show("Удалить абонента?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _subRepo.Delete(sub.Id);
                LoadData();
            }
        }

        private void EditSubscriber(Subscriber? sub)
        {
            var form = new EditSubscriberForm(sub, _tariffRepo.GetAll());
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }
    }
}