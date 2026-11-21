using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class UsedPartListForm : Form
    {
        private readonly IUsedPartRepository _usedPartRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly ICarPartRepository _carPartRepository;
        private readonly ICarRepository _carRepository;
        private readonly IMechanicRepository _mechanicRepository;
        private readonly IUnityContainer _container;

        public UsedPartListForm(
            IUsedPartRepository usedPartRepository,
            IAppointmentRepository appointmentRepository,
            ICarPartRepository carPartRepository,
            ICarRepository carRepository,
            IMechanicRepository mechanicRepository,
            IUnityContainer container)
        {
            InitializeComponent();
            _usedPartRepository = usedPartRepository;
            _appointmentRepository = appointmentRepository;
            _carPartRepository = carPartRepository;
            _carRepository = carRepository;
            _mechanicRepository = mechanicRepository;
            _container = container;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadUsedParts();
        }

        private void LoadUsedParts()
        {
            dataGridViewUsedParts.DataSource = null;
            dataGridViewUsedParts.Rows.Clear();

            var usedParts = _usedPartRepository.GetAll();
            var appointments = _appointmentRepository.GetAll();
            var carParts = _carPartRepository.GetAll();
            var cars = _carRepository.GetAll();
            var mechanics = _mechanicRepository.GetAll();

            var displayList = new List<UsedPartDisplayItem>();

            foreach (var usedPart in usedParts)
            {
                var appointment = appointments.FirstOrDefault(a => a.Id == usedPart.AppointmentId);
                var carPart = carParts.FirstOrDefault(p => p.Id == usedPart.CarPartId);

                string appointmentInfo = "Запись удалена";
                if (appointment != null)
                {
                    var car = cars.FirstOrDefault(c => c.Id == appointment.CarId);
                    var mechanic = mechanics.FirstOrDefault(m => m.Id == appointment.MechanicId);
                    string carStr = car != null ? $"{car.Brand} {car.Model}" : "Авто удалено";
                    string mechStr = mechanic != null ? $"{mechanic.Surname}" : "Механик удален";
                    appointmentInfo = $"{appointment.AppointmentDate:dd.MM.yyyy} — {carStr} / {mechStr}";
                }

                displayList.Add(new UsedPartDisplayItem
                {
                    Id = usedPart.Id,
                    AppointmentInfo = appointmentInfo,
                    CarPartInfo = carPart != null ? $"{carPart.Name} ({carPart.Article})" : "Запчасть удалена",
                    Quantity = usedPart.Quantity
                });
            }

            dataGridViewUsedParts.DataSource = displayList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = _container.Resolve<UsedPartEditForm>();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsedParts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsedParts.CurrentRow?.DataBoundItem is not UsedPartDisplayItem selected)
            {
                MessageBox.Show("Выберите запись для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Удалить использование запчасти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _usedPartRepository.Delete(selected.Id);
                LoadUsedParts();
            }
        }
    }
}