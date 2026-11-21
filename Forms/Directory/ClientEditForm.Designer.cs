namespace AutoService
{
    partial class ClientEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Namelabel = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtSurname = new TextBox();
            Surnamelabel = new Label();
            txtPhoneNumber = new TextBox();
            PhoneNumberslabel = new Label();
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
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(22, 210);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(240, 31);
            txtPhoneNumber.TabIndex = 7;
            // 
            // PhoneNumberslabel
            // 
            PhoneNumberslabel.AutoSize = true;
            PhoneNumberslabel.Location = new Point(22, 182);
            PhoneNumberslabel.Name = "PhoneNumberslabel";
            PhoneNumberslabel.Size = new Size(150, 25);
            PhoneNumberslabel.TabIndex = 6;
            PhoneNumberslabel.Text = "Номер телефона";
            // 
            // ClientEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPhoneNumber);
            Controls.Add(PhoneNumberslabel);
            Controls.Add(txtSurname);
            Controls.Add(Surnamelabel);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(Namelabel);
            Name = "ClientEditForm";
            Text = "ClientEditForm";
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
        private TextBox txtPhoneNumber;
        private Label PhoneNumberslabel;
    }
}