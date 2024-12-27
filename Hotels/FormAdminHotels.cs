using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotels
{
    public partial class FormAdminHotels : Form
    {
        public FormAdminHotels()
        {
            InitializeComponent();
            Text = "Форма управления таблицей \"Отели\"";

        }

        private void FormAdminHotels_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);

            City_comboBox.Items.Clear();
            List<string> citys = Sql_class.MySelect("SELECT id, Name FROM citys");
            for (int i = 0; i < citys.Count; i += 2)
            {
                City_comboBox.Items.Add(citys[i] + ". " + citys[i + 1]);
            }

            List<string> hotels = Sql_class.MySelect("SELECT id, name, city_id FROM hotels");

            int y = 40;
            for(int i = 0; i < hotels.Count; i+=3)
            {
           
                Label lbl2 = new Label();
                lbl2.Text = hotels[i + 1];
                lbl2.Location = new Point(25, y);
                lbl2.Size = new Size(100, 30);
                panel1.Controls.Add(lbl2);

                List<string> city = Sql_class.MySelect("SELECT id, name FROM citys WHERE id = '" + hotels[i+2] + "'");

                Label lbl3 = new Label();
                lbl3.Text = hotels[i + 2] +  ". " + city[1];
                lbl3.Location = new Point(150, y);
                lbl3.Size = new Size(100, 30);
                panel1.Controls.Add(lbl3);

                Button btn1 = new Button();
                btn1.Location = new Point(300, y);
                btn1.Size = new Size(100, 30);
                btn1.Text = "Удалить";
                panel1.Controls.Add(btn1);

                y += 40;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        string adress;
        private void Add_pic_button_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                adress = openFileDialog1.FileName;
                Hotel_pictureBox.Load(adress);
                adress = Path.GetFileName(adress);

            }
        }
        //доделать для телефона, описания и адреса
        private void button1_Click(object sender, EventArgs e)
        {
            if (Name_comboBox.Text != "" && City_comboBox.Text != "" && Hotel_pictureBox.Image != null)
            {
                Sql_class.MyUpDate("INSERT INTO hotels (name, city_id, rate, pic, adress, phone, opis) VALUE ('" + Name_comboBox.Text + "','" + City_comboBox.Text + "','" + Rate_comboBox.Text + "','" + adress + "','" + Tel_comboBox.Text + "','" + Adress_comboBox.Text + "','" + Opis_comboBox.Text + "')");
                MessageBox.Show("Сохранено");
                Name_comboBox.Text = "";
                City_comboBox.Text = "";
                Rate_comboBox.Text = "";
                Tel_comboBox.Text = "";
                Adress_comboBox.Text = "";
                Opis_comboBox.Text = "";
                Hotel_pictureBox.Image = null;

            }
            else
            {
                MessageBox.Show("Заполните поля со знаком *");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поля со знаком * должны быть заполнены обязательно");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
