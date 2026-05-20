using System;
using System.Windows.Forms;
using InternetProviderApp.Data;
using InternetProviderApp.Models;

namespace InternetProviderApp.Forms
{
    public partial class TariffsForm : Form
    {
        private TariffRepository _repo = new TariffRepository();
        private User _currentUser;

        public TariffsForm(User user)
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
            dgvTariffs.DataSource = _repo.GetAll();
            if (dgvTariffs.Columns.Contains("Id"))
                dgvTariffs.Columns["Id"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var all = _repo.GetAll();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                all = all.FindAll(t => t.Name.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase));
            dgvTariffs.DataSource = all;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EditTariffForm(null);
            if (form.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTariffs.CurrentRow == null) return;
            var tariff = dgvTariffs.CurrentRow.DataBoundItem as Tariff;
            if (tariff == null) return;
            var form = new EditTariffForm(tariff);
            if (form.ShowDialog() == DialogResult.OK) LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTariffs.CurrentRow == null) return;
            var tariff = dgvTariffs.CurrentRow.DataBoundItem as Tariff;
            if (tariff == null) return;
            if (MessageBox.Show("Удалить тариф?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repo.Delete(tariff.Id);
                LoadData();
            }
        }
    }
}