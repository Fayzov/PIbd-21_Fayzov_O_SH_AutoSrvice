using AutoService.Models;
using AutoService.Repositories.Interfaces;
using System;
using System.Net;
using System.Windows.Forms;

namespace AutoService
{
    public partial class CarEditForm : Form
    {
        private readonly ICarRepository _carRepository;
        private readonly IClientRepository _clientRepository;
        private Car _editingCar;

        public CarEditForm(ICarRepository carRepository, IClientRepository clientRepository)
        {
            InitializeComponent();
            _carRepository = carRepository;
            _clientRepository = clientRepository;

            // Загружаем клиентов в ComboBox
            cmbClient.DataSource = _clientRepository.GetAll();
            cmbClient.DisplayMember = "Surname"; // Что показывать пользователю
            cmbClient.ValueMember = "Id";       // Что будет храниться как значение
        }

        public void SetCar(Car car)
        {
            _editingCar = car;
            cmbClient.SelectedValue = car.ClientId;
            txtBrand.Text = car.Brand;
            txtModel.Text = car.Model;
            txtCarNumbers.Text = car.CarNumbers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClient.SelectedValue == null)
                {
                    throw new ArgumentException("Не выбран клиент.");
                }

                int clientId = (int)cmbClient.SelectedValue;

                if (_editingCar == null)
                {
                    var car = Car.Create(clientId, txtBrand.Text, txtModel.Text, txtCarNumbers.Text);
                    _carRepository.Add(car);
                }
                else
                {
                    var car = Car.Create(clientId, txtBrand.Text, txtModel.Text, txtCarNumbers.Text);
                    car.SetId(_editingCar.Id);
                    _carRepository.Update(car);
                }

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