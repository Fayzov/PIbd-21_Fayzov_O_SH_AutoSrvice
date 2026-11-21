using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class MechanicListForm : Form
    {
        private readonly IMechanicRepository _mechanicRepository;
        private readonly IUnityContainer _container;

        public MechanicListForm(IMechanicRepository mechanicRepository, IUnityContainer container)
        {
            InitializeComponent();
            _mechanicRepository = mechanicRepository;
            _container = container;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadMechanics();
        }

        private void LoadMechanics()
        {
            dataGridViewMechanics.DataSource = null;
            dataGridViewMechanics.Rows.Clear();
            var mechanics = _mechanicRepository.GetAll();
            dataGridViewMechanics.DataSource = new List<Mechanic>(mechanics);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = _container.Resolve<MechanicEditForm>();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadMechanics();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMechanics.CurrentRow?.DataBoundItem is not Mechanic selected)
            {
                MessageBox.Show("Выберите механика для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var editForm = _container.Resolve<MechanicEditForm>();
            editForm.SetMechanic(selected);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadMechanics();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMechanics.CurrentRow?.DataBoundItem is not Mechanic selected)
            {
                MessageBox.Show("Выберите механика для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Удалить механика {selected.Name} {selected.Surname}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _mechanicRepository.Delete(selected.Id);
                LoadMechanics();
            }
        }
    }
}