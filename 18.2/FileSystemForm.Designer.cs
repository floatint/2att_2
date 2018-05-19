namespace _18._2
{
    partial class FileSystemForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccessTreeView = new System.Windows.Forms.TreeView();
            this.RunButton = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.AccessTreeViewLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccessTreeView
            // 
            this.AccessTreeView.Location = new System.Drawing.Point(9, 22);
            this.AccessTreeView.Name = "AccessTreeView";
            this.AccessTreeView.Size = new System.Drawing.Size(546, 210);
            this.AccessTreeView.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(9, 237);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(106, 23);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Создать";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(128, 239);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 2;
            // 
            // AccessTreeViewLabel
            // 
            this.AccessTreeViewLabel.AutoSize = true;
            this.AccessTreeViewLabel.Location = new System.Drawing.Point(6, 6);
            this.AccessTreeViewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccessTreeViewLabel.Name = "AccessTreeViewLabel";
            this.AccessTreeViewLabel.Size = new System.Drawing.Size(112, 13);
            this.AccessTreeViewLabel.TabIndex = 3;
            this.AccessTreeViewLabel.Text = "Дерево обращений :";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(345, 239);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(68, 21);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FileSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 397);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AccessTreeViewLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.AccessTreeView);
            this.Name = "FileSystemForm";
            this.Text = "Поиск и удаление в файловой системе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView AccessTreeView;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label AccessTreeViewLabel;
        private System.Windows.Forms.Button DeleteButton;
    }
}

