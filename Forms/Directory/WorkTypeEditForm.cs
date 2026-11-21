using AutoService.Models;
using AutoService.Repositories.Interfaces;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoService
{
    public partial class WorkTypeEditForm : Form
    {
        private readonly IWorkTypeRepository _workTypeRepository;
        private WorkType? _editingWorkType;

        public WorkTypeEditForm(IWorkTypeRepository workTypeRepository)
        {
            InitializeComponent();
            _workTypeRepository = workTypeRepository;
        }

        public void SetWorkType(WorkType workType)
        {
            _editingWorkType = workType;
            txtName.Text = workType.Name;
            txtHours.Text = workType.Hours.ToString();
            txtPrice.Text = workType.Price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtHours.Text, out decimal hours))
                    throw new ArgumentException("Нормо-часы должны быть числом.");
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                    throw new ArgumentException("Стоимость должна быть числом.");

                if (_editingWorkType == null)
                {
                    var workType = WorkType.Create(txtName.Text, hours, price);
                    _workTypeRepository.Add(workType);
                }
                else
                {
                    var workType = WorkType.Create(txtName.Text, hours, price);
                    workType.SetId(_editingWorkType.Id);
                    _workTypeRepository.Update(workType);
                }

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