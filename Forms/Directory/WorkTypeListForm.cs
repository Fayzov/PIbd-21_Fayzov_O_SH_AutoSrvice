using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService
{
    public partial class WorkTypeListForm : Form
    {
        private readonly IWorkTypeRepository _workTypeRepository;
        private readonly IUnityContainer _container;

        public WorkTypeListForm(IWorkTypeRepository workTypeRepository, IUnityContainer container)
        {
            InitializeComponent();
            _workTypeRepository = workTypeRepository;
            _container = container;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadWorkTypes();
        }

        private void LoadWorkTypes()
        {
            dataGridViewWorkTypes.DataSource = null;
            dataGridViewWorkTypes.Rows.Clear();
            var workTypes = _workTypeRepository.GetAll();
            dataGridViewWorkTypes.DataSource = new List<WorkType>(workTypes);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = _container.Resolve<WorkTypeEditForm>();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadWorkTypes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkTypes.CurrentRow?.DataBoundItem is not WorkType selected)
            {
                MessageBox.Show("Выберите вид работы для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var editForm = _container.Resolve<WorkTypeEditForm>();
            editForm.SetWorkType(selected);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadWorkTypes();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewWorkTypes.CurrentRow?.DataBoundItem is not WorkType selected)
            {
                MessageBox.Show("Выберите вид работы для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Удалить вид работы {selected.Name}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _workTypeRepository.Delete(selected.Id);
                LoadWorkTypes();
            }
        }
    }
}