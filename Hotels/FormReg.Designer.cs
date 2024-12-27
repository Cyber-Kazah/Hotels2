namespace Hotels
{
    partial class FormReg
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Sur_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reg_button = new System.Windows.Forms.Button();
            this.PassCon_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(17, 41);
            this.Name_textBox.Multiline = true;
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(471, 22);
            this.Name_textBox.TabIndex = 1;
            // 
            // Sur_textBox
            // 
            this.Sur_textBox.Location = new System.Drawing.Point(17, 131);
            this.Sur_textBox.Multiline = true;
            this.Sur_textBox.Name = "Sur_textBox";
            this.Sur_textBox.Size = new System.Drawing.Size(471, 22);
            this.Sur_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // Log_textBox
            // 
            this.Log_textBox.Location = new System.Drawing.Point(17, 226);
            this.Log_textBox.Multiline = true;
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.Size = new System.Drawing.Size(471, 22);
            this.Log_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Location = new System.Drawing.Point(17, 313);
            this.Pass_textBox.Multiline = true;
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.PasswordChar = '*';
            this.Pass_textBox.Size = new System.Drawing.Size(471, 22);
            this.Pass_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль";
            // 
            // Reg_button
            // 
            this.Reg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg_button.Location = new System.Drawing.Point(17, 421);
            this.Reg_button.Name = "Reg_button";
            this.Reg_button.Size = new System.Drawing.Size(471, 104);
            this.Reg_button.TabIndex = 8;
            this.Reg_button.Text = "Создать аккаунт";
            this.Reg_button.UseVisualStyleBackColor = true;
            this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
            // 
            // PassCon_textbox
            // 
            this.PassCon_textbox.Location = new System.Drawing.Point(17, 384);
            this.PassCon_textbox.Multiline = true;
            this.PassCon_textbox.Name = "PassCon_textbox";
            this.PassCon_textbox.PasswordChar = '*';
            this.PassCon_textbox.Size = new System.Drawing.Size(471, 22);
            this.PassCon_textbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Повторите пароль";
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 568);
            this.Controls.Add(this.PassCon_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Reg_button);
            this.Controls.Add(this.Pass_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Log_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sur_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.label1);
            this.Name = "FormReg";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Sur_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Log_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reg_button;
        private System.Windows.Forms.TextBox PassCon_textbox;
        private System.Windows.Forms.Label label5;
    }
}