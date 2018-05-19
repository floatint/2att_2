namespace _17._1
{
    partial class LogicExprForm
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
            this.exprLabel = new System.Windows.Forms.Label();
            this.exprTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exprLabel
            // 
            this.exprLabel.AutoSize = true;
            this.exprLabel.Location = new System.Drawing.Point(1, 6);
            this.exprLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exprLabel.Name = "exprLabel";
            this.exprLabel.Size = new System.Drawing.Size(72, 13);
            this.exprLabel.TabIndex = 0;
            this.exprLabel.Text = "Выражение :";
            // 
            // exprTextBox
            // 
            this.exprTextBox.Location = new System.Drawing.Point(3, 21);
            this.exprTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exprTextBox.Name = "exprTextBox";
            this.exprTextBox.Size = new System.Drawing.Size(228, 20);
            this.exprTextBox.TabIndex = 1;
            this.exprTextBox.Text = "And(T, And(Or(T, F), T))";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(3, 51);
            this.runButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(85, 30);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // LogicExprForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 229);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.exprTextBox);
            this.Controls.Add(this.exprLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogicExprForm";
            this.Text = "Вычисление логических выражений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exprLabel;
        private System.Windows.Forms.TextBox exprTextBox;
        private System.Windows.Forms.Button runButton;
    }
}

