using System;
using System.Linq;
using System.Windows.Forms;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class UsedPartEditForm : Form
    {
        private readonly IUsedPartRepository _usedPartRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly ICarPartRepository _carPartRepository;

        public UsedPartEditForm(
            IUsedPartRepository usedPartRepository,
            IAppointmentRepository appointmentRepository,
            ICarPartRepository carPartRepository)
        {
            InitializeComponent();
            _usedPartRepository = usedPartRepository;
            _appointmentRepository = appointmentRepository;
            _carPartRepository = carPartRepository;

            // Загружаем записи
            var appointments = _appointmentRepository.GetAll().Select(a => new
            {
                Id = a.Id,
                Display = $"Запись #{a.Id} от {a.AppointmentDate:dd.MM.yyyy}"
            }).ToList();
            cmbAppointment.DataSource = appointments;
            cmbAppointment.DisplayMember = "Display";
            cmbAppointment.ValueMember = "Id";

            // Загружаем запчасти
            var parts = _carPartRepository.GetAll().Select(p => new
            {
                Id = p.Id,
                Display = $"{p.Name} ({p.Article})"
            }).ToList();
            cmbCarPart.DataSource = parts;
            cmbCarPart.DisplayMember = "Display";
            cmbCarPart.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(cmbAppointment.SelectedValue is int appointmentId))
                    throw new ArgumentException("Не выбрана запись на ремонт.");
                if (!(cmbCarPart.SelectedValue is int carPartId))
                    throw new ArgumentException("Не выбрана запчасть.");

                if (!int.TryParse(txtQuantity.Text, out int quantity))
                    throw new ArgumentException("Количество должно быть целым числом.");

                var usedPart = UsedPart.Create(appointmentId, carPartId, quantity);
                _usedPartRepository.Add(usedPart);

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