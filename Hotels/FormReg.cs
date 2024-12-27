using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotels
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            if(Name_textBox.Text == "" || Sur_textBox.Text == "" || Log_textBox.Text == "")
            {
                return;
                MessageBox.Show("Заполните все поля");
            }


            if (Pass_textBox.Text == PassCon_textbox.Text)
            {
                Sql_class.MyUpDate("INSERT INTO users (login, parol, name, surname, admin) VALUE ('" + Log_textBox.Text + "', '" + Pass_textBox.Text + "', '" + Name_textBox.Text + "', '" + Sur_textBox.Text + "', 0)");
                MessageBox.Show("Аккаунт создан");
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}
