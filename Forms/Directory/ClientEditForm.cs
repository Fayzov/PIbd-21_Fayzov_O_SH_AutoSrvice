using System;
using System.Windows.Forms;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class ClientEditForm : Form
    {
        private readonly IClientRepository _clientRepository;

        public ClientEditForm(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var client = Client.Create(txtName.Text, txtSurname.Text, txtPhoneNumber.Text);

                _clientRepository.Add(client);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}