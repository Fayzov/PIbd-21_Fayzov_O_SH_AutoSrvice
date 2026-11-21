namespace AutoService
{
    partial class AppointmentEditForm
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
            Carlabel = new Label();
            cmbCar = new ComboBox();
            Mechaniclabel = new Label();
            cmbMechanic = new ComboBox();
            Datelabel = new Label();
            dtpAppointmentDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // Carlabel
            // 
            Carlabel.AutoSize = true;
            Carlabel.Location = new Point(22, 24);
            Carlabel.Name = "Carlabel";
            Carlabel.Size = new Size(100, 25);
            Carlabel.TabIndex = 0;
            Carlabel.Text = "Автомобиль";
            // 
            // cmbCar
            // 
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCar.FormattingEnabled = true;
            cmbCar.Location = new Point(22, 52);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(300, 33);
            cmbCar.TabIndex = 1;
            // 
            // Mechaniclabel
            // 
            Mechaniclabel.AutoSize = true;
            Mechaniclabel.Location = new Point(22, 100);
            Mechaniclabel.Name = "Mechaniclabel";
            Mechaniclabel.Size = new Size(78, 25);
            Mechaniclabel.TabIndex = 2;
            Mechaniclabel.Text = "Механик";
            // 
            // cmbMechanic
            // 
            cmbMechanic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMechanic.FormattingEnabled = true;
            cmbMechanic.Location = new Point(22, 128);
            cmbMechanic.Name = "cmbMechanic";
            cmbMechanic.Size = new Size(300, 33);
            cmbMechanic.TabIndex = 3;
            // 
            // Datelabel
            // 
            Datelabel.AutoSize = true;
            Datelabel.Location = new Point(22, 180);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(110, 25);
            Datelabel.TabIndex = 4;
            Datelabel.Text = "Дата и время";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.Location = new Point(22, 208);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(300, 31);
            dtpAppointmentDate.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(22, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(140, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AppointmentEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(Datelabel);
            Controls.Add(cmbMechanic);
            Controls.Add(Mechaniclabel);
            Controls.Add(cmbCar);
            Controls.Add(Carlabel);
            Name = "AppointmentEditForm";
            Text = "Новая запись на ремонт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Carlabel;
        private ComboBox cmbCar;
        private Label Mechaniclabel;
        private ComboBox cmbMechanic;
        private Label Datelabel;
        private DateTimePicker dtpAppointmentDate;
        private Button btnSave;
        private Button btnCancel;
    }
}