namespace AutoService
{
    partial class UsedPartListForm
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
            dataGridViewUsedParts = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsedParts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsedParts
            // 
            dataGridViewUsedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsedParts.Location = new Point(12, 81);
            dataGridViewUsedParts.Name = "dataGridViewUsedParts";
            dataGridViewUsedParts.RowHeadersWidth = 62;
            dataGridViewUsedParts.Size = new Size(776, 343);
            dataGridViewUsedParts.TabIndex = 0;
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
            // btnDelete
            // 
            btnDelete.Location = new Point(141, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // UsedPartListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewUsedParts);
            Name = "UsedPartListForm";
            Text = "Использованные запчасти";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsedParts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsedParts;
        private Button btnAdd;
        private Button btnDelete;
    }
}