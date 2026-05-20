using System;
using System.Windows.Forms;
using InternetProviderApp.Data;
using InternetProviderApp.Models;

namespace InternetProviderApp.Forms
{
    public partial class RequestsForm : Form
    {
        private RequestRepository _repo = new RequestRepository();
        private User _currentUser;

        public RequestsForm(User user)
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
            dgvRequests.DataSource = _repo.GetAll();
            if (dgvRequests.Columns.Contains("Id"))
                dgvRequests.Columns["Id"].Visible = false;
            if (dgvRequests.Columns.Contains("SubscriberId"))
                dgvRequests.Columns["SubscriberId"].Visible = false;
            if (dgvRequests.Columns.Contains("TariffId"))
                dgvRequests.Columns["TariffId"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var all = _repo.GetAll();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                all = all.FindAll(r => r.SubscriberName.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                                        r.Status.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase));
            }
            dgvRequests.DataSource = all;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditRequest(null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null) return;
            var req = dgvRequests.CurrentRow.DataBoundItem as Request;
            if (req == null) return;
            EditRequest(req);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow == null) return;
            var req = dgvRequests.CurrentRow.DataBoundItem as Request;
            if (req == null) return;
            if (MessageBox.Show("Удалить заявку?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repo.Delete(req.Id);
                LoadData();
            }
        }

        private void EditRequest(Request? req)
        {
            var form = new EditRequestForm(req);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }
    }
}