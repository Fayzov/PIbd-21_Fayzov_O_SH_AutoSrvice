using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class AppointmentListForm : Form
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly ICarRepository _carRepository;
        private readonly IMechanicRepository _mechanicRepository;
        private readonly IUnityContainer _container;

        public AppointmentListForm(
            IAppointmentRepository appointmentRepository,
            ICarRepository carRepository,
            IMechanicRepository mechanicRepository,
            IUnityContainer container)
        {
            InitializeComponent();
            _appointmentRepository = appointmentRepository;
            _carRepository = carRepository;
            _mechanicRepository = mechanicRepository;
            _container = container;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            dataGridViewAppointments.DataSource = null;
            dataGridViewAppointments.Rows.Clear();

            // Получаем все записи
            var appointments = _appointmentRepository.GetAll();
            // Получаем все машины и механиков для быстрого поиска
            var cars = _carRepository.GetAll();
            var mechanics = _mechanicRepository.GetAll();

            // Формируем список для отображения (DTO)
            var displayList = new List<AppointmentDisplayItem>();

            foreach (var app in appointments)
            {
                var car = cars.FirstOrDefault(c => c.Id == app.CarId);
                var mechanic = mechanics.FirstOrDefault(m => m.Id == app.MechanicId);

                displayList.Add(new AppointmentDisplayItem
                {
                    Id = app.Id,
                    // Формат: Марка Модель (Госномер)
                    CarInfo = car != null ? $"{car.Brand} {car.Model} ({car.CarNumbers})" : "Автомобиль удален",
                    // Формат: Фамилия Имя (Квалификация)
                    MechanicInfo = mechanic != null ? $"{mechanic.Surname} {mechanic.Name}" : "Механик удален",
                    AppointmentDate = app.AppointmentDate
                });
            }

            dataGridViewAppointments.DataSource = displayList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = _container.Resolve<AppointmentEditForm>();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadAppointments();
            }
        }
    }
}