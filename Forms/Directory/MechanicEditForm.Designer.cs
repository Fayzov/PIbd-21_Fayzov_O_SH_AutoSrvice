namespace AutoService
{
    partial class MechanicEditForm
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
            btnSave = new Button();
            btnCancel = new Button();
            txtSurname = new TextBox();
            Surnamelabel = new Label();
            txtExperience = new TextBox();
            Experiencelabel = new Label();
            Qualificationlabel = new Label();
            cmbQualification = new ComboBox();
            SuspendLayout();
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(22, 24);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(47, 25);
            Namelabel.TabIndex = 0;
            Namelabel.Text = "Имя";
            // 
            // txtName
            // 
            txtName.Location = new Point(22, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 31);
            txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(22, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(140, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(22, 125);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(240, 31);
            txtSurname.TabIndex = 5;
            // 
            // Surnamelabel
            // 
            Surnamelabel.AutoSize = true;
            Surnamelabel.Location = new Point(22, 97);
            Surnamelabel.Name = "Surnamelabel";
            Surnamelabel.Size = new Size(85, 25);
            Surnamelabel.TabIndex = 4;
            Surnamelabel.Text = "Фамилия";
            // 
            // txtExperience
            // 
            txtExperience.Location = new Point(22, 210);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(240, 31);
            txtExperience.TabIndex = 7;
            // 
            // Experiencelabel
            // 
            Experiencelabel.AutoSize = true;
            Experiencelabel.Location = new Point(22, 182);
            Experiencelabel.Name = "Experiencelabel";
            Experiencelabel.Size = new Size(66, 25);
            Experiencelabel.TabIndex = 6;
            Experiencelabel.Text = "Стаж (лет)";
            // 
            // Qualificationlabel
            // 
            Qualificationlabel.AutoSize = true;
            Qualificationlabel.Location = new Point(22, 260);
            Qualificationlabel.Name = "Qualificationlabel";
            Qualificationlabel.Size = new Size(123, 25);
            Qualificationlabel.TabIndex = 8;
            Qualificationlabel.Text = "Квалификация";
            // 
            // cmbQualification
            // 
            cmbQualification.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQualification.FormattingEnabled = true;
            cmbQualification.Location = new Point(22, 288);
            cmbQualification.Name = "cmbQualification";
            cmbQualification.Size = new Size(240, 33);
            cmbQualification.TabIndex = 9;
            // 
            // MechanicEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbQualification);
            Controls.Add(Qualificationlabel);
            Controls.Add(txtExperience);
            Controls.Add(Experiencelabel);
            Controls.Add(txtSurname);
            Controls.Add(Surnamelabel);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(Namelabel);
            Name = "MechanicEditForm";
            Text = "Механик";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Namelabel;
        private TextBox txtName;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtSurname;
        private Label Surnamelabel;
        private TextBox txtExperience;
        private Label Experiencelabel;
        private Label Qualificationlabel;
        private ComboBox cmbQualification;
    }
}