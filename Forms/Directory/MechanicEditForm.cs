using AutoService.Enums;
using AutoService.Models;
using AutoService.Repositories.Interfaces;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoService
{
    public partial class MechanicEditForm : Form
    {
        private readonly IMechanicRepository _mechanicRepository;
        private Mechanic _editingMechanic;

        public MechanicEditForm(IMechanicRepository mechanicRepository)
        {
            InitializeComponent();
            _mechanicRepository = mechanicRepository;

            // Заполняем ComboBox значениями перечисления
            cmbQualification.DataSource = Enum.GetValues(typeof(Qualification));
        }

        public void SetMechanic(Mechanic mechanic)
        {
            _editingMechanic = mechanic;
            txtName.Text = mechanic.Name;
            txtSurname.Text = mechanic.Surname;
            cmbQualification.SelectedItem = mechanic.Qualification;
            txtExperience.Text = mechanic.ExperienceYear.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtExperience.Text, out int experience))
                {
                    throw new ArgumentException("Стаж должен быть целым числом.");
                }

                var qualification = (Qualification)cmbQualification.SelectedItem;

                if (_editingMechanic == null)
                {
                    var mechanic = Mechanic.Create(txtName.Text, txtSurname.Text, qualification, experience);
                    _mechanicRepository.Add(mechanic);
                }
                else
                {
                    var mechanic = Mechanic.Create(txtName.Text, txtSurname.Text, qualification, experience);
                    mechanic.SetId(_editingMechanic.Id);
                    _mechanicRepository.Update(mechanic);
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