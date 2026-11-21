namespace AutoService
{
    partial class UsedPartEditForm
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
            CarPartlabel = new Label();
            cmbCarPart = new ComboBox();
            Quantitylabel = new Label();
            txtQuantity = new TextBox();
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
            // CarPartlabel
            // 
            CarPartlabel.AutoSize = true;
            CarPartlabel.Location = new Point(22, 100);
            CarPartlabel.Name = "CarPartlabel";
            CarPartlabel.Size = new Size(98, 25);
            CarPartlabel.TabIndex = 2;
            CarPartlabel.Text = "Запчасть";
            // 
            // cmbCarPart
            // 
            cmbCarPart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarPart.FormattingEnabled = true;
            cmbCarPart.Location = new Point(22, 128);
            cmbCarPart.Name = "cmbCarPart";
            cmbCarPart.Size = new Size(400, 33);
            cmbCarPart.TabIndex = 3;
            // 
            // Quantitylabel
            // 
            Quantitylabel.AutoSize = true;
            Quantitylabel.Location = new Point(22, 180);
            Quantitylabel.Name = "Quantitylabel";
            Quantitylabel.Size = new Size(115, 25);
            Quantitylabel.TabIndex = 4;
            Quantitylabel.Text = "Количество";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(22, 208);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(240, 31);
            txtQuantity.TabIndex = 5;
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
            // UsedPartEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtQuantity);
            Controls.Add(Quantitylabel);
            Controls.Add(cmbCarPart);
            Controls.Add(CarPartlabel);
            Controls.Add(cmbAppointment);
            Controls.Add(Appointmentlabel);
            Name = "UsedPartEditForm";
            Text = "Использованная запчасть";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Appointmentlabel;
        private ComboBox cmbAppointment;
        private Label CarPartlabel;
        private ComboBox cmbCarPart;
        private Label Quantitylabel;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnCancel;
    }
}