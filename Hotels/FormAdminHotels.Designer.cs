namespace Hotels
{
    partial class FormAdminHotels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rate_comboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Add_pic_button = new System.Windows.Forms.Button();
            this.Hotel_pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.City_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Tel_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adress_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Opis_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 256);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(873, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(200, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Город";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Гостиница";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.Opis_comboBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Adress_comboBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Tel_comboBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Rate_comboBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Add_pic_button);
            this.panel2.Controls.Add(this.Hotel_pictureBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.City_comboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Name_comboBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 285);
            this.panel2.TabIndex = 1;
            // 
            // Rate_comboBox
            // 
            this.Rate_comboBox.FormattingEnabled = true;
            this.Rate_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Rate_comboBox.Location = new System.Drawing.Point(231, 68);
            this.Rate_comboBox.Name = "Rate_comboBox";
            this.Rate_comboBox.Size = new System.Drawing.Size(179, 24);
            this.Rate_comboBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(226, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Рейтинг";
            // 
            // Add_pic_button
            // 
            this.Add_pic_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_pic_button.Location = new System.Drawing.Point(664, 212);
            this.Add_pic_button.Name = "Add_pic_button";
            this.Add_pic_button.Size = new System.Drawing.Size(257, 65);
            this.Add_pic_button.TabIndex = 7;
            this.Add_pic_button.Text = "Добавить картинку";
            this.Add_pic_button.UseVisualStyleBackColor = true;
            this.Add_pic_button.Click += new System.EventHandler(this.Add_pic_button_Click);
            // 
            // Hotel_pictureBox
            // 
            this.Hotel_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hotel_pictureBox.Location = new System.Drawing.Point(664, 36);
            this.Hotel_pictureBox.Name = "Hotel_pictureBox";
            this.Hotel_pictureBox.Size = new System.Drawing.Size(257, 171);
            this.Hotel_pictureBox.TabIndex = 6;
            this.Hotel_pictureBox.TabStop = false;
            this.Hotel_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // City_comboBox
            // 
            this.City_comboBox.FormattingEnabled = true;
            this.City_comboBox.Location = new System.Drawing.Point(446, 68);
            this.City_comboBox.Name = "City_comboBox";
            this.City_comboBox.Size = new System.Drawing.Size(179, 24);
            this.City_comboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(441, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Город *";
            // 
            // Name_comboBox
            // 
            this.Name_comboBox.FormattingEnabled = true;
            this.Name_comboBox.Location = new System.Drawing.Point(12, 68);
            this.Name_comboBox.Name = "Name_comboBox";
            this.Name_comboBox.Size = new System.Drawing.Size(179, 24);
            this.Name_comboBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление гостиницы";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Tel_comboBox
            // 
            this.Tel_comboBox.FormattingEnabled = true;
            this.Tel_comboBox.Location = new System.Drawing.Point(12, 139);
            this.Tel_comboBox.Name = "Tel_comboBox";
            this.Tel_comboBox.Size = new System.Drawing.Size(179, 24);
            this.Tel_comboBox.TabIndex = 11;
            this.Tel_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Телефон";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Adress_comboBox
            // 
            this.Adress_comboBox.FormattingEnabled = true;
            this.Adress_comboBox.Location = new System.Drawing.Point(226, 139);
            this.Adress_comboBox.Name = "Adress_comboBox";
            this.Adress_comboBox.Size = new System.Drawing.Size(179, 24);
            this.Adress_comboBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(226, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Адрес";
            // 
            // Opis_comboBox
            // 
            this.Opis_comboBox.FormattingEnabled = true;
            this.Opis_comboBox.Location = new System.Drawing.Point(441, 139);
            this.Opis_comboBox.Name = "Opis_comboBox";
            this.Opis_comboBox.Size = new System.Drawing.Size(179, 24);
            this.Opis_comboBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(441, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Описание";
            // 
            // FormAdminHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdminHotels";
            this.Text = "FormAdminHotels";
            this.Load += new System.EventHandler(this.FormAdminHotels_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Hotel_pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox City_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Name_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_pic_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox Rate_comboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Tel_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Opis_comboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Adress_comboBox;
        private System.Windows.Forms.Label label8;
    }
}