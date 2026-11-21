using System;
using System.Windows.Forms;
using Unity;

namespace AutoService
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container;
        }

        // Справочники
        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<ClientListForm>();
            form.Show();
        }

        private void MechanicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<MechanicListForm>();
            form.Show();
        }

        private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var carForm = _container.Resolve<CarListForm>();
            carForm.Show();
        }

        private void WorkTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<WorkTypeListForm>();
            form.Show();
        }

        private void CarPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<CarPartListForm>();
            form.Show();
        }

        // Операции
        private void AppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<AppointmentListForm>();
            form.Show();
        }

        private void PerformedWorksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<PerformedWorkListForm>();
            form.Show();
        }

        private void UsedPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _container.Resolve<UsedPartListForm>();
            form.Show();
        }
    }
}