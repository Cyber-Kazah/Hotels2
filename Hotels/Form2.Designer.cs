namespace Hotels
{
    partial class Form2
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
            this.phonetextBox = new System.Windows.Forms.TextBox();
            this.adresstextBox = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.Adresslabel = new System.Windows.Forms.Label();
            this.OpistextBox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Hotel_pictureBox = new System.Windows.Forms.PictureBox();
            this.roompanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.phonetextBox);
            this.panel1.Controls.Add(this.adresstextBox);
            this.panel1.Controls.Add(this.Save_button);
            this.panel1.Controls.Add(this.Phonelabel);
            this.panel1.Controls.Add(this.Adresslabel);
            this.panel1.Controls.Add(this.OpistextBox);
            this.panel1.Controls.Add(this.Name_label);
            this.panel1.Controls.Add(this.Hotel_pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 300);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // phonetextBox
            // 
            this.phonetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phonetextBox.Location = new System.Drawing.Point(593, 54);
            this.phonetextBox.Name = "phonetextBox";
            this.phonetextBox.Size = new System.Drawing.Size(435, 34);
            this.phonetextBox.TabIndex = 7;
            // 
            // adresstextBox
            // 
            this.adresstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adresstextBox.Location = new System.Drawing.Point(593, 5);
            this.adresstextBox.Name = "adresstextBox";
            this.adresstextBox.Size = new System.Drawing.Size(435, 34);
            this.adresstextBox.TabIndex = 6;
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(861, 237);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(192, 45);
            this.Save_button.TabIndex = 5;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phonelabel.Location = new System.Drawing.Point(499, 57);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(76, 29);
            this.Phonelabel.TabIndex = 4;
            this.Phonelabel.Text = "Тел. :";
            // 
            // Adresslabel
            // 
            this.Adresslabel.AutoSize = true;
            this.Adresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adresslabel.Location = new System.Drawing.Point(499, 10);
            this.Adresslabel.Name = "Adresslabel";
            this.Adresslabel.Size = new System.Drawing.Size(88, 29);
            this.Adresslabel.TabIndex = 3;
            this.Adresslabel.Text = "Адрес:";
            // 
            // OpistextBox
            // 
            this.OpistextBox.Enabled = false;
            this.OpistextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpistextBox.Location = new System.Drawing.Point(504, 89);
            this.OpistextBox.Multiline = true;
            this.OpistextBox.Name = "OpistextBox";
            this.OpistextBox.ReadOnly = true;
            this.OpistextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OpistextBox.Size = new System.Drawing.Size(549, 141);
            this.OpistextBox.TabIndex = 2;
            this.OpistextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(7, 245);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(79, 29);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "label1";
            // 
            // Hotel_pictureBox
            // 
            this.Hotel_pictureBox.Location = new System.Drawing.Point(12, 10);
            this.Hotel_pictureBox.Name = "Hotel_pictureBox";
            this.Hotel_pictureBox.Size = new System.Drawing.Size(342, 220);
            this.Hotel_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hotel_pictureBox.TabIndex = 0;
            this.Hotel_pictureBox.TabStop = false;
            // 
            // roompanel
            // 
            this.roompanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.roompanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roompanel.Location = new System.Drawing.Point(0, 300);
            this.roompanel.Name = "roompanel";
            this.roompanel.Size = new System.Drawing.Size(1065, 277);
            this.roompanel.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 577);
            this.Controls.Add(this.roompanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OpistextBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.PictureBox Hotel_pictureBox;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Label Adresslabel;
        private System.Windows.Forms.Panel roompanel;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox phonetextBox;
        private System.Windows.Forms.TextBox adresstextBox;
    }
}