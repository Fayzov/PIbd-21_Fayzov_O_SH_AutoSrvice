namespace AutoService
{
    partial class CarEditForm
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
            Clientlabel = new Label();
            cmbClient = new ComboBox();
            txtBrand = new TextBox();
            Brandlabel = new Label();
            txtModel = new TextBox();
            Modellabel = new Label();
            txtCarNumbers = new TextBox();
            CarNumberslabel = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // Clientlabel
            // 
            Clientlabel.AutoSize = true;
            Clientlabel.Location = new Point(22, 24);
            Clientlabel.Name = "Clientlabel";
            Clientlabel.Size = new Size(69, 25);
            Clientlabel.TabIndex = 0;
            Clientlabel.Text = "Клиент";
            // 
            // cmbClient
            // 
            cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(22, 52);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(240, 33);
            cmbClient.TabIndex = 1;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(22, 125);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(240, 31);
            txtBrand.TabIndex = 3;
            // 
            // Brandlabel
            // 
            Brandlabel.AutoSize = true;
            Brandlabel.Location = new Point(22, 97);
            Brandlabel.Name = "Brandlabel";
            Brandlabel.Size = new Size(61, 25);
            Brandlabel.TabIndex = 2;
            Brandlabel.Text = "Марка";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(22, 200);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(240, 31);
            txtModel.TabIndex = 5;
            // 
            // Modellabel
            // 
            Modellabel.AutoSize = true;
            Modellabel.Location = new Point(22, 172);
            Modellabel.Name = "Modellabel";
            Modellabel.Size = new Size(73, 25);
            Modellabel.TabIndex = 4;
            Modellabel.Text = "Модель";
            // 
            // txtCarNumbers
            // 
            txtCarNumbers.Location = new Point(22, 275);
            txtCarNumbers.Name = "txtCarNumbers";
            txtCarNumbers.Size = new Size(240, 31);
            txtCarNumbers.TabIndex = 7;
            // 
            // CarNumberslabel
            // 
            CarNumberslabel.AutoSize = true;
            CarNumberslabel.Location = new Point(22, 247);
            CarNumberslabel.Name = "CarNumberslabel";
            CarNumberslabel.Size = new Size(80, 25);
            CarNumberslabel.TabIndex = 6;
            CarNumberslabel.Text = "Госномер";
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
            // CarEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCarNumbers);
            Controls.Add(CarNumberslabel);
            Controls.Add(txtModel);
            Controls.Add(Modellabel);
            Controls.Add(txtBrand);
            Controls.Add(Brandlabel);
            Controls.Add(cmbClient);
            Controls.Add(Clientlabel);
            Name = "CarEditForm";
            Text = "Автомобиль";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Clientlabel;
        private ComboBox cmbClient;
        private TextBox txtBrand;
        private Label Brandlabel;
        private TextBox txtModel;
        private Label Modellabel;
        private TextBox txtCarNumbers;
        private Label CarNumberslabel;
        private Button btnSave;
        private Button btnCancel;
    }
}