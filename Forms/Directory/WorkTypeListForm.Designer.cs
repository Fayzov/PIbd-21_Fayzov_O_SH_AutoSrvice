namespace AutoService
{
    partial class WorkTypeListForm
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
            dataGridViewWorkTypes = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkTypes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWorkTypes
            // 
            dataGridViewWorkTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkTypes.Location = new Point(12, 81);
            dataGridViewWorkTypes.Name = "dataGridViewWorkTypes";
            dataGridViewWorkTypes.RowHeadersWidth = 62;
            dataGridViewWorkTypes.Size = new Size(776, 343);
            dataGridViewWorkTypes.TabIndex = 0;
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
            // WorkTypeListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewWorkTypes);
            Name = "WorkTypeListForm";
            Text = "Список видов работ";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewWorkTypes;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}