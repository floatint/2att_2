namespace _18._1
{
    partial class Form1
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
            this.frameWaitLabel = new System.Windows.Forms.Label();
            this.frameWaitTextBox = new System.Windows.Forms.TextBox();
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
            this.runButton.Location = new System.Drawing.Point(3, 81);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Рисовать";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // frameWaitLabel
            // 
            this.frameWaitLabel.AutoSize = true;
            this.frameWaitLabel.Location = new System.Drawing.Point(0, 39);
            this.frameWaitLabel.Name = "frameWaitLabel";
            this.frameWaitLabel.Size = new System.Drawing.Size(97, 13);
            this.frameWaitLabel.TabIndex = 3;
            this.frameWaitLabel.Text = "Задержка кадра :";
            // 
            // frameWaitTextBox
            // 
            this.frameWaitTextBox.Location = new System.Drawing.Point(3, 55);
            this.frameWaitTextBox.Name = "frameWaitTextBox";
            this.frameWaitTextBox.Size = new System.Drawing.Size(100, 20);
            this.frameWaitTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 369);
            this.Controls.Add(this.frameWaitTextBox);
            this.Controls.Add(this.frameWaitLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.editKTextBox);
            this.Controls.Add(this.editKLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editKLabel;
        private System.Windows.Forms.TextBox editKTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label frameWaitLabel;
        private System.Windows.Forms.TextBox frameWaitTextBox;
    }
}

