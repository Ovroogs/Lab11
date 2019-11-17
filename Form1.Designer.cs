namespace Lab11_Alekseev_Igor
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
            this.textBoxNow = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEnterBirthday = new System.Windows.Forms.TextBox();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnSplitUp = new System.Windows.Forms.Button();
            this.btnClearNow = new System.Windows.Forms.Button();
            this.btnClearSplitUp = new System.Windows.Forms.Button();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnCalculateAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNow
            // 
            this.textBoxNow.Location = new System.Drawing.Point(12, 119);
            this.textBoxNow.Multiline = true;
            this.textBoxNow.Name = "textBoxNow";
            this.textBoxNow.Size = new System.Drawing.Size(171, 94);
            this.textBoxNow.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(378, 80);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(142, 166);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(217, 104);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(0, 13);
            this.labelDay.TabIndex = 2;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(217, 136);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(0, 13);
            this.labelMonth.TabIndex = 3;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(217, 166);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(0, 13);
            this.labelYear.TabIndex = 4;
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Location = new System.Drawing.Point(217, 200);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(0, 13);
            this.labelDayOfWeek.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(76, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Работа с датами";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "введите дату рождения";
            // 
            // textBoxEnterBirthday
            // 
            this.textBoxEnterBirthday.Location = new System.Drawing.Point(591, 182);
            this.textBoxEnterBirthday.Name = "textBoxEnterBirthday";
            this.textBoxEnterBirthday.Size = new System.Drawing.Size(128, 20);
            this.textBoxEnterBirthday.TabIndex = 8;
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(55, 247);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(75, 23);
            this.btnNow.TabIndex = 9;
            this.btnNow.Text = "Сегодня";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnSplitUp
            // 
            this.btnSplitUp.Location = new System.Drawing.Point(198, 247);
            this.btnSplitUp.Name = "btnSplitUp";
            this.btnSplitUp.Size = new System.Drawing.Size(75, 23);
            this.btnSplitUp.TabIndex = 10;
            this.btnSplitUp.Text = "Разделить";
            this.btnSplitUp.UseVisualStyleBackColor = true;
            this.btnSplitUp.Click += new System.EventHandler(this.btnSplitUp_Click);
            // 
            // btnClearNow
            // 
            this.btnClearNow.Location = new System.Drawing.Point(55, 283);
            this.btnClearNow.Name = "btnClearNow";
            this.btnClearNow.Size = new System.Drawing.Size(75, 23);
            this.btnClearNow.TabIndex = 11;
            this.btnClearNow.Text = "Очистить";
            this.btnClearNow.UseVisualStyleBackColor = true;
            this.btnClearNow.Click += new System.EventHandler(this.btnClearNow_Click);
            // 
            // btnClearSplitUp
            // 
            this.btnClearSplitUp.Location = new System.Drawing.Point(198, 283);
            this.btnClearSplitUp.Name = "btnClearSplitUp";
            this.btnClearSplitUp.Size = new System.Drawing.Size(75, 23);
            this.btnClearSplitUp.TabIndex = 12;
            this.btnClearSplitUp.Text = "Очистить";
            this.btnClearSplitUp.UseVisualStyleBackColor = true;
            this.btnClearSplitUp.Click += new System.EventHandler(this.btnClearSplitUp_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(412, 283);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(75, 23);
            this.btnNextDay.TabIndex = 13;
            this.btnNextDay.Text = "Завтра";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // btnCalculateAge
            // 
            this.btnCalculateAge.Location = new System.Drawing.Point(591, 208);
            this.btnCalculateAge.Name = "btnCalculateAge";
            this.btnCalculateAge.Size = new System.Drawing.Size(128, 23);
            this.btnCalculateAge.TabIndex = 14;
            this.btnCalculateAge.Text = "Вычислить возраст";
            this.btnCalculateAge.UseVisualStyleBackColor = true;
            this.btnCalculateAge.Click += new System.EventHandler(this.btnCalculateAge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 433);
            this.Controls.Add(this.btnCalculateAge);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.btnClearSplitUp);
            this.Controls.Add(this.btnClearNow);
            this.Controls.Add(this.btnSplitUp);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.textBoxEnterBirthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textBoxNow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNow;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEnterBirthday;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnSplitUp;
        private System.Windows.Forms.Button btnClearNow;
        private System.Windows.Forms.Button btnClearSplitUp;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.Button btnCalculateAge;
    }
}

