namespace AutoService
{
    partial class PerformedWorkListForm
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
            dataGridViewPerformedWorks = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformedWorks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPerformedWorks
            // 
            dataGridViewPerformedWorks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPerformedWorks.Location = new Point(12, 81);
            dataGridViewPerformedWorks.Name = "dataGridViewPerformedWorks";
            dataGridViewPerformedWorks.RowHeadersWidth = 62;
            dataGridViewPerformedWorks.Size = new Size(776, 343);
            dataGridViewPerformedWorks.TabIndex = 0;
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
            // PerformedWorkListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewPerformedWorks);
            Name = "PerformedWorkListForm";
            Text = "Выполненные работы";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformedWorks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPerformedWorks;
        private Button btnAdd;
        private Button btnDelete;
    }
}