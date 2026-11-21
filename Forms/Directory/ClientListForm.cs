using AutoService.Models;
using AutoService.Repositories.Interfaces;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Unity;

namespace AutoService
{
    public partial class ClientListForm : Form
    {
        private readonly IClientRepository _clientRepository;
        private readonly IUnityContainer _container;

        public ClientListForm(IClientRepository clientRepository, IUnityContainer container)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            _container = container;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadClients();
        }

        private void LoadClients()
        {
            dataGridViewClients.DataSource = null;
            dataGridViewClients.Rows.Clear();

            // Создаем НОВЫЙ список, чтобы DataGridView гарантированно обновился
            var clients = _clientRepository.GetAll();
            dataGridViewClients.DataSource = new List<Client>(clients);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = _container.Resolve<ClientEditForm>();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadClients();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow?.DataBoundItem is not Client selectedClient)
            {
                MessageBox.Show("Выберите клиента для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Пока не реализовано редактирование (форма ClientEditForm только для добавления),
            // но кнопка работает и проверяет выбор.
            MessageBox.Show($"Редактирование клиента {selectedClient.Name} {selectedClient.Surname} пока не реализовано.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow?.DataBoundItem is not Client selectedClient)
            {
                MessageBox.Show("Выберите клиента для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Удалить клиента {selectedClient.Name} {selectedClient.Surname}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _clientRepository.Delete(selectedClient.Id);
                LoadClients();
            }
        }
    }
}