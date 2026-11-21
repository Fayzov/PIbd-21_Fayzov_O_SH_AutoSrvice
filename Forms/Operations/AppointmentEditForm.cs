using System;
using System.Windows.Forms;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class AppointmentEditForm : Form
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly ICarRepository _carRepository;
        private readonly IMechanicRepository _mechanicRepository;

        public AppointmentEditForm(
     IAppointmentRepository appointmentRepository,
     ICarRepository carRepository,
     IMechanicRepository mechanicRepository)
        {
            InitializeComponent();
            _appointmentRepository = appointmentRepository;
            _carRepository = carRepository;
            _mechanicRepository = mechanicRepository;

            // Загружаем машины в ComboBox (склеиваем марку, модель и номер)
            var cars = _carRepository.GetAll().Select(c => new
            {
                Id = c.Id,
                Display = $"{c.Brand} {c.Model} ({c.CarNumbers})"
            }).ToList();
            cmbCar.DataSource = cars;
            cmbCar.DisplayMember = "Display";
            cmbCar.ValueMember = "Id";

            // Загружаем механиков в ComboBox (Фамилия Имя)
            var mechanics = _mechanicRepository.GetAll().Select(m => new
            {
                Id = m.Id,
                Display = $"{m.Surname} {m.Name}"
            }).ToList();
            cmbMechanic.DataSource = mechanics;
            cmbMechanic.DisplayMember = "Display";
            cmbMechanic.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCar.SelectedValue == null)
                    throw new ArgumentException("Не выбран автомобиль.");
                if (cmbMechanic.SelectedValue == null)
                    throw new ArgumentException("Не выбран механик.");

                int carId = (int)cmbCar.SelectedValue;
                int mechanicId = (int)cmbMechanic.SelectedValue;
                DateTime date = dtpAppointmentDate.Value;

                var appointment = Appointment.Create(carId, mechanicId, date);
                _appointmentRepository.Add(appointment);

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