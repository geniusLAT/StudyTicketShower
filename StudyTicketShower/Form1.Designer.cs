namespace StudyTicketShower
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.PositiveButton = new System.Windows.Forms.Button();
            this.NegativeButton = new System.Windows.Forms.Button();
            this.StatisticsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.questionLabel.Location = new System.Drawing.Point(12, 39);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(64, 18);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "question";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(12, 96);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(41, 13);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "answer";
            this.answerLabel.Click += new System.EventHandler(this.answerLabel_Click);
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(13, 70);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.showAnswerButton.TabIndex = 2;
            this.showAnswerButton.Text = "Show Answer";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // PositiveButton
            // 
            this.PositiveButton.Location = new System.Drawing.Point(176, 70);
            this.PositiveButton.Name = "PositiveButton";
            this.PositiveButton.Size = new System.Drawing.Size(191, 23);
            this.PositiveButton.TabIndex = 3;
            this.PositiveButton.Text = "PositiveButton";
            this.PositiveButton.UseVisualStyleBackColor = true;
            this.PositiveButton.Click += new System.EventHandler(this.PositiveButton_Click);
            // 
            // NegativeButton
            // 
            this.NegativeButton.Location = new System.Drawing.Point(373, 70);
            this.NegativeButton.Name = "NegativeButton";
            this.NegativeButton.Size = new System.Drawing.Size(191, 23);
            this.NegativeButton.TabIndex = 4;
            this.NegativeButton.Text = "NegativeButton";
            this.NegativeButton.UseVisualStyleBackColor = true;
            this.NegativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // StatisticsLabel
            // 
            this.StatisticsLabel.AutoSize = true;
            this.StatisticsLabel.Location = new System.Drawing.Point(13, 13);
            this.StatisticsLabel.Name = "StatisticsLabel";
            this.StatisticsLabel.Size = new System.Drawing.Size(15, 13);
            this.StatisticsLabel.TabIndex = 5;
            this.StatisticsLabel.Text = "U";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatisticsLabel);
            this.Controls.Add(this.NegativeButton);
            this.Controls.Add(this.PositiveButton);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button showAnswerButton;
        private System.Windows.Forms.Button PositiveButton;
        private System.Windows.Forms.Button NegativeButton;
        private System.Windows.Forms.Label StatisticsLabel;
    }
}

