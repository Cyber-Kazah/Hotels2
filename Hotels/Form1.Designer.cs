namespace Hotels
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
            this.Auth_panel = new System.Windows.Forms.Panel();
            this.Admin_button = new System.Windows.Forms.Button();
            this.Hellolabel = new System.Windows.Forms.Label();
            this.Enter_button = new System.Windows.Forms.Button();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Filtr_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Filtr_button = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Search_button = new System.Windows.Forms.Button();
            this.Rate_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.City_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.Reg_button = new System.Windows.Forms.Button();
            this.Auth_panel.SuspendLayout();
            this.Filtr_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Auth_panel
            // 
            this.Auth_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Auth_panel.Controls.Add(this.Reg_button);
            this.Auth_panel.Controls.Add(this.Admin_button);
            this.Auth_panel.Controls.Add(this.Hellolabel);
            this.Auth_panel.Controls.Add(this.Enter_button);
            this.Auth_panel.Controls.Add(this.Pass_textBox);
            this.Auth_panel.Controls.Add(this.label2);
            this.Auth_panel.Controls.Add(this.Log_textBox);
            this.Auth_panel.Controls.Add(this.label1);
            this.Auth_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Auth_panel.Location = new System.Drawing.Point(0, 0);
            this.Auth_panel.Name = "Auth_panel";
            this.Auth_panel.Size = new System.Drawing.Size(1282, 90);
            this.Auth_panel.TabIndex = 0;
            // 
            // Admin_button
            // 
            this.Admin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Admin_button.Location = new System.Drawing.Point(878, 21);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(379, 46);
            this.Admin_button.TabIndex = 6;
            this.Admin_button.Text = "Панель администрателя";
            this.Admin_button.UseVisualStyleBackColor = true;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // Hellolabel
            // 
            this.Hellolabel.AutoSize = true;
            this.Hellolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hellolabel.Location = new System.Drawing.Point(32, 28);
            this.Hellolabel.Name = "Hellolabel";
            this.Hellolabel.Size = new System.Drawing.Size(79, 29);
            this.Hellolabel.TabIndex = 5;
            this.Hellolabel.Text = "label7";
            // 
            // Enter_button
            // 
            this.Enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_button.Location = new System.Drawing.Point(667, 21);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(170, 46);
            this.Enter_button.TabIndex = 4;
            this.Enter_button.Text = "Войти";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass_textBox.Location = new System.Drawing.Point(450, 28);
            this.Pass_textBox.Multiline = true;
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.PasswordChar = '*';
            this.Pass_textBox.Size = new System.Drawing.Size(200, 30);
            this.Pass_textBox.TabIndex = 3;
            this.Pass_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(345, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // Log_textBox
            // 
            this.Log_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_textBox.Location = new System.Drawing.Point(111, 28);
            this.Log_textBox.Multiline = true;
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.Size = new System.Drawing.Size(200, 30);
            this.Log_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // Filtr_panel
            // 
            this.Filtr_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Filtr_panel.Controls.Add(this.button1);
            this.Filtr_panel.Controls.Add(this.Filtr_button);
            this.Filtr_panel.Controls.Add(this.dateTimePicker2);
            this.Filtr_panel.Controls.Add(this.label6);
            this.Filtr_panel.Controls.Add(this.dateTimePicker1);
            this.Filtr_panel.Controls.Add(this.label5);
            this.Filtr_panel.Controls.Add(this.Search_button);
            this.Filtr_panel.Controls.Add(this.Rate_comboBox);
            this.Filtr_panel.Controls.Add(this.label4);
            this.Filtr_panel.Controls.Add(this.City_comboBox);
            this.Filtr_panel.Controls.Add(this.label3);
            this.Filtr_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filtr_panel.Location = new System.Drawing.Point(0, 90);
            this.Filtr_panel.Name = "Filtr_panel";
            this.Filtr_panel.Size = new System.Drawing.Size(1282, 160);
            this.Filtr_panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 82);
            this.button1.TabIndex = 12;
            this.button1.Text = "секрет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filtr_button
            // 
            this.Filtr_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filtr_button.Location = new System.Drawing.Point(0, 0);
            this.Filtr_button.Name = "Filtr_button";
            this.Filtr_button.Size = new System.Drawing.Size(155, 40);
            this.Filtr_button.TabIndex = 11;
            this.Filtr_button.Text = "Фильтр";
            this.Filtr_button.UseVisualStyleBackColor = true;
            this.Filtr_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(525, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(245, 34);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(366, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата выезда";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(525, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 34);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(366, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата заезда";
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_button.Location = new System.Drawing.Point(1082, 47);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(170, 80);
            this.Search_button.TabIndex = 6;
            this.Search_button.Text = "Искать";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Rate_comboBox
            // 
            this.Rate_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rate_comboBox.FormattingEnabled = true;
            this.Rate_comboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Rate_comboBox.Location = new System.Drawing.Point(145, 90);
            this.Rate_comboBox.Name = "Rate_comboBox";
            this.Rate_comboBox.Size = new System.Drawing.Size(200, 37);
            this.Rate_comboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Рейтинг";
            // 
            // City_comboBox
            // 
            this.City_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.City_comboBox.FormattingEnabled = true;
            this.City_comboBox.Location = new System.Drawing.Point(145, 47);
            this.City_comboBox.Name = "City_comboBox";
            this.City_comboBox.Size = new System.Drawing.Size(200, 37);
            this.City_comboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Город";
            // 
            // Mainpanel
            // 
            this.Mainpanel.AutoScroll = true;
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(0, 250);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(1282, 403);
            this.Mainpanel.TabIndex = 2;
            // 
            // Reg_button
            // 
            this.Reg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg_button.Location = new System.Drawing.Point(878, 22);
            this.Reg_button.Name = "Reg_button";
            this.Reg_button.Size = new System.Drawing.Size(379, 46);
            this.Reg_button.TabIndex = 7;
            this.Reg_button.Text = "Регистрация";
            this.Reg_button.UseVisualStyleBackColor = true;
            this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.Filtr_panel);
            this.Controls.Add(this.Auth_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Auth_panel.ResumeLayout(false);
            this.Auth_panel.PerformLayout();
            this.Filtr_panel.ResumeLayout(false);
            this.Filtr_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Auth_panel;
        private System.Windows.Forms.Panel Filtr_panel;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Log_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Button Filtr_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.ComboBox Rate_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox City_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Label Hellolabel;
        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reg_button;
    }
}

