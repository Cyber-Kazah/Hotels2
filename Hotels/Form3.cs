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

    //комнаты
    public partial class Form3 : Form
    {

        string room_id;

        public Form3(string idRoom)
        {
            InitializeComponent();

            room_id = idRoom;

            List<string> room = Sql_class.MySelect("SELECT id, Name, hotel_id, pic, price, space, opis FROM rooms WHERE id = " + idRoom);

            Text = room[1];
            Room_pictureBox.Load("../../Pic/" + room[3]);
            Room_label.Text = room[1];
            price_label.Text = room[4];
            size_label.Text = room[5];
            opis_textBox.Text = room[6];
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Забронировано", "Бронь");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(Form1.Login == "")
            {
                MessageBox.Show("Войдите или зарегестрируйтесь");
                return;
            }
            Sql_class.MyUpDate("INSERT INTO book (user, datefrom, dateto, room_id) VALUE ('" + Form1.Login + "', '" + IndateTimePicker.Value.ToString("yyyy-MM-dd") + "', '" + FromdateTimePicker.Value.ToString("yyyy-MM-dd") + "', '" + room_id + "')");
            MessageBox.Show("Забронированно");
        }
    }
}
