using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class CarPartListForm : Form
    {
        private readonly ICarPartRepository _carPartRepository;
        private readonly IUnityContainer _container;

        public CarPartListForm(ICarPartRepository carPartRepository, IUnityContainer container)
        {
            InitializeComponent();
            _carPartRepository = carPartRepository;
            _container = container;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadCarParts();
        }

        private void LoadCarParts()
        {
            dataGridViewCarParts.DataSource = null;
            dataGridViewCarParts.Rows.Clear();
            var parts = _carPartRepository.GetAll();
            dataGridViewCarParts.DataSource = new List<CarPart>(parts);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = _container.Resolve<CarPartEditForm>();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCarParts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarParts.CurrentRow?.DataBoundItem is not CarPart selected)
            {
                MessageBox.Show("Выберите запчасть для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var editForm = _container.Resolve<CarPartEditForm>();
            editForm.SetCarPart(selected);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCarParts();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarParts.CurrentRow?.DataBoundItem is not CarPart selected)
            {
                MessageBox.Show("Выберите запчасть для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Удалить запчасть {selected.Name}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _carPartRepository.Delete(selected.Id);
                LoadCarParts();
            }
        }
    }
}