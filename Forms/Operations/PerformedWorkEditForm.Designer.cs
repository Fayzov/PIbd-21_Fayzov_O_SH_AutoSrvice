namespace AutoService
{
    partial class PerformedWorkEditForm
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
            Appointmentlabel = new Label();
            cmbAppointment = new ComboBox();
            WorkTypelabel = new Label();
            cmbWorkType = new ComboBox();
            Hourslabel = new Label();
            txtHours = new TextBox();
            Pricelabel = new Label();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // Appointmentlabel
            // 
            Appointmentlabel.AutoSize = true;
            Appointmentlabel.Location = new Point(22, 24);
            Appointmentlabel.Name = "Appointmentlabel";
            Appointmentlabel.Size = new Size(150, 25);
            Appointmentlabel.TabIndex = 0;
            Appointmentlabel.Text = "Запись на ремонт";
            // 
            // cmbAppointment
            // 
            cmbAppointment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAppointment.FormattingEnabled = true;
            cmbAppointment.Location = new Point(22, 52);
            cmbAppointment.Name = "cmbAppointment";
            cmbAppointment.Size = new Size(400, 33);
            cmbAppointment.TabIndex = 1;
            // 
            // WorkTypelabel
            // 
            WorkTypelabel.AutoSize = true;
            WorkTypelabel.Location = new Point(22, 100);
            WorkTypelabel.Name = "WorkTypelabel";
            WorkTypelabel.Size = new Size(105, 25);
            WorkTypelabel.TabIndex = 2;
            WorkTypelabel.Text = "Вид работы";
            // 
            // cmbWorkType
            // 
            cmbWorkType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorkType.FormattingEnabled = true;
            cmbWorkType.Location = new Point(22, 128);
            cmbWorkType.Name = "cmbWorkType";
            cmbWorkType.Size = new Size(400, 33);
            cmbWorkType.TabIndex = 3;
            // 
            // Hourslabel
            // 
            Hourslabel.AutoSize = true;
            Hourslabel.Location = new Point(22, 180);
            Hourslabel.Name = "Hourslabel";
            Hourslabel.Size = new Size(150, 25);
            Hourslabel.TabIndex = 4;
            Hourslabel.Text = "Фактические часы";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(22, 208);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(240, 31);
            txtHours.TabIndex = 5;
            // 
            // Pricelabel
            // 
            Pricelabel.AutoSize = true;
            Pricelabel.Location = new Point(22, 260);
            Pricelabel.Name = "Pricelabel";
            Pricelabel.Size = new Size(107, 25);
            Pricelabel.TabIndex = 6;
            Pricelabel.Text = "Стоимость";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(22, 288);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(240, 31);
            txtPrice.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(22, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(140, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PerformedWorkEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(Pricelabel);
            Controls.Add(txtHours);
            Controls.Add(Hourslabel);
            Controls.Add(cmbWorkType);
            Controls.Add(WorkTypelabel);
            Controls.Add(cmbAppointment);
            Controls.Add(Appointmentlabel);
            Name = "PerformedWorkEditForm";
            Text = "Выполненная работа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Appointmentlabel;
        private ComboBox cmbAppointment;
        private Label WorkTypelabel;
        private ComboBox cmbWorkType;
        private Label Hourslabel;
        private TextBox txtHours;
        private Label Pricelabel;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}