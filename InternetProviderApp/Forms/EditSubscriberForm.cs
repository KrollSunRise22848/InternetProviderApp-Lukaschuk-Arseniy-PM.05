using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InternetProviderApp.Data;
using InternetProviderApp.Models;

namespace InternetProviderApp.Forms
{
    public partial class EditSubscriberForm : Form
    {
        private Subscriber _sub;
        private SubscriberRepository _repo = new SubscriberRepository();
        private List<Tariff> _tariffs;

        public EditSubscriberForm(Subscriber? sub, List<Tariff> tariffs)
        {
            InitializeComponent();
            _tariffs = tariffs;
            comboBoxTariff.DataSource = _tariffs;
            comboBoxTariff.DisplayMember = "Name";
            comboBoxTariff.ValueMember = "Id";

            if (sub == null)
            {
                _sub = new Subscriber { IsActive = true };
                Text = "Добавление абонента";
            }
            else
            {
                _sub = sub;
                Text = "Редактирование абонента";
                txtFullName.Text = sub.FullName;
                txtPhone.Text = sub.Phone;
                txtAddress.Text = sub.Address;
                txtContract.Text = sub.ContractNumber;
                comboBoxTariff.SelectedValue = sub.TariffId;
                checkBoxActive.Checked = sub.IsActive;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _sub.FullName = txtFullName.Text.Trim();
            _sub.Phone = txtPhone.Text.Trim();
            _sub.Address = txtAddress.Text.Trim();
            _sub.ContractNumber = txtContract.Text.Trim();
            _sub.TariffId = (int)comboBoxTariff.SelectedValue;
            _sub.IsActive = checkBoxActive.Checked;

            if (string.IsNullOrWhiteSpace(_sub.FullName))
            { MessageBox.Show("Введите ФИО"); return; }
            if (string.IsNullOrWhiteSpace(_sub.ContractNumber))
            { MessageBox.Show("Введите номер договора"); return; }
            if (_repo.ContractNumberExists(_sub.ContractNumber, _sub.Id))
            { MessageBox.Show("Договор с таким номером уже существует!"); return; }

            if (_sub.Id == 0)
                _repo.Add(_sub);
            else
                _repo.Update(_sub);

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