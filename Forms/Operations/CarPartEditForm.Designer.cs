namespace AutoService
{
    partial class CarPartEditForm
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
            Articlelabel = new Label();
            txtArticle = new TextBox();
            Pricelabel = new Label();
            txtPrice = new TextBox();
            StockQuantitylabel = new Label();
            txtStockQuantity = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(22, 24);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(166, 25);
            Namelabel.TabIndex = 0;
            Namelabel.Text = "Название запчасти";
            // 
            // txtName
            // 
            txtName.Location = new Point(22, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 31);
            txtName.TabIndex = 1;
            // 
            // Articlelabel
            // 
            Articlelabel.AutoSize = true;
            Articlelabel.Location = new Point(22, 100);
            Articlelabel.Name = "Articlelabel";
            Articlelabel.Size = new Size(79, 25);
            Articlelabel.TabIndex = 2;
            Articlelabel.Text = "Артикул";
            // 
            // txtArticle
            // 
            txtArticle.Location = new Point(22, 128);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(240, 31);
            txtArticle.TabIndex = 3;
            // 
            // Pricelabel
            // 
            Pricelabel.AutoSize = true;
            Pricelabel.Location = new Point(22, 176);
            Pricelabel.Name = "Pricelabel";
            Pricelabel.Size = new Size(53, 25);
            Pricelabel.TabIndex = 4;
            Pricelabel.Text = "Цена";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(22, 204);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(240, 31);
            txtPrice.TabIndex = 5;
            // 
            // StockQuantitylabel
            // 
            StockQuantitylabel.AutoSize = true;
            StockQuantitylabel.Location = new Point(22, 252);
            StockQuantitylabel.Name = "StockQuantitylabel";
            StockQuantitylabel.Size = new Size(190, 25);
            StockQuantitylabel.TabIndex = 6;
            StockQuantitylabel.Text = "Количество на складе";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(22, 280);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(240, 31);
            txtStockQuantity.TabIndex = 7;
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
            // CarPartEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtStockQuantity);
            Controls.Add(StockQuantitylabel);
            Controls.Add(txtPrice);
            Controls.Add(Pricelabel);
            Controls.Add(txtArticle);
            Controls.Add(Articlelabel);
            Controls.Add(txtName);
            Controls.Add(Namelabel);
            Name = "CarPartEditForm";
            Text = "Запчасть";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Namelabel;
        private TextBox txtName;
        private Label Articlelabel;
        private TextBox txtArticle;
        private Label Pricelabel;
        private TextBox txtPrice;
        private Label StockQuantitylabel;
        private TextBox txtStockQuantity;
        private Button btnSave;
        private Button btnCancel;
    }
}