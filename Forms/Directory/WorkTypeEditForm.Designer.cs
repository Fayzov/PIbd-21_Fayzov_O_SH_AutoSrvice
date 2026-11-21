namespace AutoService
{
    partial class WorkTypeEditForm
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
            Namelabel = new Label();
            txtName = new TextBox();
            Hourslabel = new Label();
            txtHours = new TextBox();
            Pricelabel = new Label();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(22, 24);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(150, 25);
            Namelabel.TabIndex = 0;
            Namelabel.Text = "Название работы";
            // 
            // txtName
            // 
            txtName.Location = new Point(22, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 31);
            txtName.TabIndex = 1;
            // 
            // Hourslabel
            // 
            Hourslabel.AutoSize = true;
            Hourslabel.Location = new Point(22, 100);
            Hourslabel.Name = "Hourslabel";
            Hourslabel.Size = new Size(120, 25);
            Hourslabel.TabIndex = 2;
            Hourslabel.Text = "Нормо-часы";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(22, 128);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(240, 31);
            txtHours.TabIndex = 3;
            // 
            // Pricelabel
            // 
            Pricelabel.AutoSize = true;
            Pricelabel.Location = new Point(22, 176);
            Pricelabel.Name = "Pricelabel";
            Pricelabel.Size = new Size(107, 25);
            Pricelabel.TabIndex = 4;
            Pricelabel.Text = "Стоимость";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(22, 204);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(240, 31);
            txtPrice.TabIndex = 5;
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
            // WorkTypeEditForm
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
            Controls.Add(txtName);
            Controls.Add(Namelabel);
            Name = "WorkTypeEditForm";
            Text = "Вид работы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Namelabel;
        private TextBox txtName;
        private Label Hourslabel;
        private TextBox txtHours;
        private Label Pricelabel;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}