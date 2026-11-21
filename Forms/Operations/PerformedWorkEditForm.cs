using System;
using System.Linq;
using System.Windows.Forms;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class PerformedWorkEditForm : Form
    {
        private readonly IPerformedWorkRepository _performedWorkRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IWorkTypeRepository _workTypeRepository;

        public PerformedWorkEditForm(
            IPerformedWorkRepository performedWorkRepository,
            IAppointmentRepository appointmentRepository,
            IWorkTypeRepository workTypeRepository)
        {
            InitializeComponent();
            _performedWorkRepository = performedWorkRepository;
            _appointmentRepository = appointmentRepository;
            _workTypeRepository = workTypeRepository;

            var appointments = _appointmentRepository.GetAll().Select(a => new
            {
                Id = a.Id,
                Display = $"Запись #{a.Id} от {a.AppointmentDate:dd.MM.yyyy}"
            }).ToList();
            cmbAppointment.DataSource = appointments;
            cmbAppointment.DisplayMember = "Display";
            cmbAppointment.ValueMember = "Id";

            var workTypes = _workTypeRepository.GetAll().Select(w => new
            {
                Id = w.Id,
                Display = $"{w.Name} ({w.Price} руб.)"
            }).ToList();
            cmbWorkType.DataSource = workTypes;
            cmbWorkType.DisplayMember = "Display";
            cmbWorkType.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(cmbAppointment.SelectedValue is int appointmentId))
                    throw new ArgumentException("Не выбрана запись на ремонт.");
                if (!(cmbWorkType.SelectedValue is int workTypeId))
                    throw new ArgumentException("Не выбран вид работы.");

                if (!decimal.TryParse(txtHours.Text, out decimal hours))
                    throw new ArgumentException("Фактические часы должны быть числом.");
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                    throw new ArgumentException("Стоимость должна быть числом.");

                var work = PerformedWork.Create(appointmentId, workTypeId, hours, price);
                _performedWorkRepository.Add(work);

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