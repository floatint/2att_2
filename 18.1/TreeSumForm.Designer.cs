namespace _18._1
{
    partial class TreeSumForm
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
            this.editKLabel = new System.Windows.Forms.Label();
            this.editKTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editKLabel
            // 
            this.editKLabel.AutoSize = true;
            this.editKLabel.Location = new System.Drawing.Point(0, 0);
            this.editKLabel.Name = "editKLabel";
            this.editKLabel.Size = new System.Drawing.Size(64, 13);
            this.editKLabel.TabIndex = 0;
            this.editKLabel.Text = "Введите k :";
            // 
            // editKTextBox
            // 
            this.editKTextBox.Location = new System.Drawing.Point(3, 16);
            this.editKTextBox.Name = "editKTextBox";
            this.editKTextBox.Size = new System.Drawing.Size(100, 20);
            this.editKTextBox.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(3, 55);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Работать";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(0, 39);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(109, 13);
            this.SumLabel.TabIndex = 3;
            this.SumLabel.Text = "Сумма на k-уровне :";
            // 
            // TreeSumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 333);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.editKTextBox);
            this.Controls.Add(this.editKLabel);
            this.Name = "TreeSumForm";
            this.Text = "Сложение элементов на k-уровне";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editKLabel;
        private System.Windows.Forms.TextBox editKTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label SumLabel;
    }
}

