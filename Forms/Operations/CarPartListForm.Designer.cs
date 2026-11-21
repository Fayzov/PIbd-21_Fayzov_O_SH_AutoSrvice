namespace AutoService
{
    partial class CarPartListForm
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
            dataGridViewCarParts = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarParts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCarParts
            // 
            dataGridViewCarParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarParts.Location = new Point(12, 81);
            dataGridViewCarParts.Name = "dataGridViewCarParts";
            dataGridViewCarParts.RowHeadersWidth = 62;
            dataGridViewCarParts.Size = new Size(776, 343);
            dataGridViewCarParts.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(141, 27);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 34);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(313, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CarPartListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewCarParts);
            Name = "CarPartListForm";
            Text = "Список запчастей";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarParts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCarParts;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}