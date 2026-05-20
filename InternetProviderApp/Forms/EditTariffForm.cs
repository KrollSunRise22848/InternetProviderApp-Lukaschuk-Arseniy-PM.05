using System;
using System.Windows.Forms;
using InternetProviderApp.Data;
using InternetProviderApp.Models;

namespace InternetProviderApp.Forms
{
    public partial class EditTariffForm : Form
    {
        private Tariff _tariff;
        private TariffRepository _repo = new TariffRepository();

        public EditTariffForm(Tariff? tariff)
        {
            InitializeComponent();
            if (tariff == null)
            {
                _tariff = new Tariff();
                Text = "Добавление тарифа";
            }
            else
            {
                _tariff = tariff;
                Text = "Редактирование тарифа";
                txtName.Text = tariff.Name;
                txtPrice.Text = tariff.Price.ToString();
                txtSpeed.Text = tariff.Speed.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { MessageBox.Show("Введите название"); return; }
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            { MessageBox.Show("Введите цену (число)"); return; }
            if (!int.TryParse(txtSpeed.Text, out int speed))
            { MessageBox.Show("Введите скорость (целое число)"); return; }

            _tariff.Name = txtName.Text.Trim();
            _tariff.Price = price;
            _tariff.Speed = speed;

            if (_tariff.Id == 0)
                _repo.Add(_tariff);
            else
                _repo.Update(_tariff);

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