namespace AutoService
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ReferencesToolStripMenuItem = new ToolStripMenuItem();
            ClientsToolStripMenuItem = new ToolStripMenuItem();
            MechanicsToolStripMenuItem = new ToolStripMenuItem();
            CarsToolStripMenuItem = new ToolStripMenuItem();
            WorkTypesToolStripMenuItem = new ToolStripMenuItem();
            CarPartsToolStripMenuItem = new ToolStripMenuItem();
            OperationsToolStripMenuItem = new ToolStripMenuItem();
            AppointmentsToolStripMenuItem = new ToolStripMenuItem();
            PerformedWorksToolStripMenuItem = new ToolStripMenuItem();
            UsedPartsToolStripMenuItem = new ToolStripMenuItem();
            ReportsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ReferencesToolStripMenuItem, OperationsToolStripMenuItem, ReportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            // 
            // ReferencesToolStripMenuItem (Справочники)
            // 
            ReferencesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClientsToolStripMenuItem, MechanicsToolStripMenuItem, CarsToolStripMenuItem, WorkTypesToolStripMenuItem, CarPartsToolStripMenuItem });
            ReferencesToolStripMenuItem.Name = "ReferencesToolStripMenuItem";
            ReferencesToolStripMenuItem.Size = new Size(139, 29);
            ReferencesToolStripMenuItem.Text = "Справочники";
            // 
            // ClientsToolStripMenuItem
            // 
            ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            ClientsToolStripMenuItem.Size = new Size(270, 34);
            ClientsToolStripMenuItem.Text = "Клиенты";
            ClientsToolStripMenuItem.Click += ClientsToolStripMenuItem_Click;
            // 
            // MechanicsToolStripMenuItem
            // 
            MechanicsToolStripMenuItem.Name = "MechanicsToolStripMenuItem";
            MechanicsToolStripMenuItem.Size = new Size(270, 34);
            MechanicsToolStripMenuItem.Text = "Механики";
            MechanicsToolStripMenuItem.Click += MechanicsToolStripMenuItem_Click;
            // 
            // CarsToolStripMenuItem
            // 
            CarsToolStripMenuItem.Name = "CarsToolStripMenuItem";
            CarsToolStripMenuItem.Size = new Size(270, 34);
            CarsToolStripMenuItem.Text = "Автомобили";
            CarsToolStripMenuItem.Click += CarsToolStripMenuItem_Click;
            // 
            // WorkTypesToolStripMenuItem
            // 
            WorkTypesToolStripMenuItem.Name = "WorkTypesToolStripMenuItem";
            WorkTypesToolStripMenuItem.Size = new Size(270, 34);
            WorkTypesToolStripMenuItem.Text = "Виды работ";
            WorkTypesToolStripMenuItem.Click += WorkTypesToolStripMenuItem_Click;
            // 
            // CarPartsToolStripMenuItem
            // 
            CarPartsToolStripMenuItem.Name = "CarPartsToolStripMenuItem";
            CarPartsToolStripMenuItem.Size = new Size(270, 34);
            CarPartsToolStripMenuItem.Text = "Запчасти";
            CarPartsToolStripMenuItem.Click += CarPartsToolStripMenuItem_Click;
            // 
            // OperationsToolStripMenuItem (Операции)
            // 
            OperationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AppointmentsToolStripMenuItem, PerformedWorksToolStripMenuItem, UsedPartsToolStripMenuItem });
            OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            OperationsToolStripMenuItem.Size = new Size(112, 29);
            OperationsToolStripMenuItem.Text = "Операции";
            // 
            // AppointmentsToolStripMenuItem
            // 
            AppointmentsToolStripMenuItem.Name = "AppointmentsToolStripMenuItem";
            AppointmentsToolStripMenuItem.Size = new Size(300, 34);
            AppointmentsToolStripMenuItem.Text = "Записи на ремонт";
            AppointmentsToolStripMenuItem.Click += AppointmentsToolStripMenuItem_Click;
            // 
            // PerformedWorksToolStripMenuItem
            // 
            PerformedWorksToolStripMenuItem.Name = "PerformedWorksToolStripMenuItem";
            PerformedWorksToolStripMenuItem.Size = new Size(300, 34);
            PerformedWorksToolStripMenuItem.Text = "Выполненные работы";
            PerformedWorksToolStripMenuItem.Click += PerformedWorksToolStripMenuItem_Click;
            // 
            // UsedPartsToolStripMenuItem
            // 
            UsedPartsToolStripMenuItem.Name = "UsedPartsToolStripMenuItem";
            UsedPartsToolStripMenuItem.Size = new Size(300, 34);
            UsedPartsToolStripMenuItem.Text = "Использованные запчасти";
            UsedPartsToolStripMenuItem.Click += UsedPartsToolStripMenuItem_Click;
            // 
            // ReportsToolStripMenuItem (Отчёты)
            // 
            ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            ReportsToolStripMenuItem.Size = new Size(88, 29);
            ReportsToolStripMenuItem.Text = "Отчёты";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Автосервис - Учет работы";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ReferencesToolStripMenuItem;
        private ToolStripMenuItem ClientsToolStripMenuItem;
        private ToolStripMenuItem MechanicsToolStripMenuItem;
        private ToolStripMenuItem CarsToolStripMenuItem;
        private ToolStripMenuItem WorkTypesToolStripMenuItem;
        private ToolStripMenuItem CarPartsToolStripMenuItem;
        private ToolStripMenuItem OperationsToolStripMenuItem;
        private ToolStripMenuItem AppointmentsToolStripMenuItem;
        private ToolStripMenuItem PerformedWorksToolStripMenuItem;
        private ToolStripMenuItem UsedPartsToolStripMenuItem;
        private ToolStripMenuItem ReportsToolStripMenuItem;
    }
}