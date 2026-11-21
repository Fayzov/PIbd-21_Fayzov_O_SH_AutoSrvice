using AutoService.Models;
using AutoService.Repositories.Interfaces;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoService
{
    public partial class CarPartEditForm : Form
    {
        private readonly ICarPartRepository _carPartRepository;
        private CarPart? _editingCarPart;

        public CarPartEditForm(ICarPartRepository carPartRepository)
        {
            InitializeComponent();
            _carPartRepository = carPartRepository;
        }

        public void SetCarPart(CarPart carPart)
        {
            _editingCarPart = carPart;
            txtName.Text = carPart.Name;
            txtArticle.Text = carPart.Article;
            txtPrice.Text = carPart.Price.ToString();
            txtStockQuantity.Text = carPart.StockQuantity.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                    throw new ArgumentException("Цена должна быть числом.");
                if (!int.TryParse(txtStockQuantity.Text, out int quantity))
                    throw new ArgumentException("Количество должно быть целым числом.");

                if (_editingCarPart == null)
                {
                    var part = CarPart.Create(txtName.Text, txtArticle.Text, price, quantity);
                    _carPartRepository.Add(part);
                }
                else
                {
                    var part = CarPart.Create(txtName.Text, txtArticle.Text, price, quantity);
                    part.SetId(_editingCarPart.Id);
                    _carPartRepository.Update(part);
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