using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class PerformedWorkListForm : Form
    {
        private readonly IPerformedWorkRepository _performedWorkRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IWorkTypeRepository _workTypeRepository;
        private readonly ICarRepository _carRepository;
        private readonly IMechanicRepository _mechanicRepository;
        private readonly IUnityContainer _container;

        public PerformedWorkListForm(
            IPerformedWorkRepository performedWorkRepository,
            IAppointmentRepository appointmentRepository,
            IWorkTypeRepository workTypeRepository,
            ICarRepository carRepository,
            IMechanicRepository mechanicRepository,
            IUnityContainer container)
        {
            InitializeComponent();
            _performedWorkRepository = performedWorkRepository;
            _appointmentRepository = appointmentRepository;
            _workTypeRepository = workTypeRepository;
            _carRepository = carRepository;
            _mechanicRepository = mechanicRepository;
            _container = container;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadPerformedWorks();
        }

        private void LoadPerformedWorks()
        {
            dataGridViewPerformedWorks.DataSource = null;
            dataGridViewPerformedWorks.Rows.Clear();

            var works = _performedWorkRepository.GetAll();
            var appointments = _appointmentRepository.GetAll();
            var workTypes = _workTypeRepository.GetAll();
            var cars = _carRepository.GetAll();
            var mechanics = _mechanicRepository.GetAll();

            var displayList = new List<PerformedWorkDisplayItem>();

            foreach (var work in works)
            {
                var appointment = appointments.FirstOrDefault(a => a.Id == work.AppointmentId);
                var workType = workTypes.FirstOrDefault(w => w.Id == work.WorkTypeId);

                string appointmentInfo = "Запись удалена";
                if (appointment != null)
                {
                    var car = cars.FirstOrDefault(c => c.Id == appointment.CarId);
                    var mechanic = mechanics.FirstOrDefault(m => m.Id == appointment.MechanicId);
                    string carStr = car != null ? $"{car.Brand} {car.Model}" : "Авто удалено";
                    string mechStr = mechanic != null ? $"{mechanic.Surname}" : "Механик удален";
                    appointmentInfo = $"{appointment.AppointmentDate:dd.MM.yyyy} — {carStr} / {mechStr}";
                }

                displayList.Add(new PerformedWorkDisplayItem
                {
                    Id = work.Id,
                    AppointmentInfo = appointmentInfo,
                    WorkTypeInfo = workType != null ? workType.Name : "Вид работы удален",
                    ActualHours = work.ActualHours,
                    TotalPrice = work.TotalPrice
                });
            }

            dataGridViewPerformedWorks.DataSource = displayList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = _container.Resolve<PerformedWorkEditForm>();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadPerformedWorks();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPerformedWorks.CurrentRow?.DataBoundItem is not PerformedWorkDisplayItem selected)
            {
                MessageBox.Show("Выберите запись для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Удалить выполненную работу?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _performedWorkRepository.Delete(selected.Id);
                LoadPerformedWorks();
            }
        }
    }
}