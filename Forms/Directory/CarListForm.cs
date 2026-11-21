using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class CarListForm : Form
    {
        private readonly ICarRepository _carRepository;
        private readonly IUnityContainer _container;

        public CarListForm(ICarRepository carRepository, IUnityContainer container)
        {
            InitializeComponent();
            _carRepository = carRepository;
            _container = container;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadCars();
        }

        private void LoadCars()
        {
            dataGridViewCars.DataSource = null;
            dataGridViewCars.Rows.Clear();
            var cars = _carRepository.GetAll();
            dataGridViewCars.DataSource = new List<Car>(cars);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = _container.Resolve<CarEditForm>();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCars();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow?.DataBoundItem is not Car selected)
            {
                MessageBox.Show("Выберите автомобиль для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var editForm = _container.Resolve<CarEditForm>();
            editForm.SetCar(selected);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCars();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow?.DataBoundItem is not Car selected)
            {
                MessageBox.Show("Выберите автомобиль для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Удалить автомобиль {selected.Brand} {selected.Model}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _carRepository.Delete(selected.Id);
                LoadCars();
            }
        }
    }
}