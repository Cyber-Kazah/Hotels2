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
    //отели

    public partial class Form2 : Form
    {
        string id;
        public Form2(string idhotel)
        {
            InitializeComponent();

            id = idhotel;

            Save_button.Visible = Convert.ToBoolean(Form1.isAdmin);

            OpistextBox.ReadOnly = !Convert.ToBoolean(Form1.isAdmin);
            OpistextBox.Enabled = Convert.ToBoolean(Form1.isAdmin);
            
            adresstextBox.Visible = Convert.ToBoolean(Form1.isAdmin);
            phonetextBox.Visible = Convert.ToBoolean(Form1.isAdmin);

            List<string> hotel = Sql_class.MySelect("SELECT id, Name, rate, City_id, pic, adress, phone, opis FROM hotels WHERE id = " + idhotel);
            

            Text = hotel[1];
            try
            { 
                Hotel_pictureBox.Load("../../Pic/" + hotel[4]);
            }
            catch (Exception) { }
            Name_label.Text = hotel[1];

            int rating = Convert.ToInt32(hotel[2]);

            int x = 310;

            for (int i = 0; i<rating; i++)
            {
              
                PictureBox pb = new PictureBox();
                pb.Load("../../Pic/star.png");
                pb.Location = new Point(x, 186);
                pb.Size = new Size(70, 60);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(pb);

                x += 65;
            }

            Adresslabel.Text = hotel[5];
            adresstextBox.Text = hotel[5];
            Phonelabel.Text = hotel[6];
            phonetextBox.Text = hotel[6];
            OpistextBox.Text = hotel[7];

            List<string> rooms = Sql_class.MySelect("SELECT id, name, hotel_id, pic FROM rooms WHERE hotel_id = " + idhotel);

            int xRooms = 50;
            for (int i = 0; i < rooms.Count; i += 4)
            {
                Label lbl = new Label();
                lbl.Text = rooms[i + 1];
                lbl.Location = new Point(xRooms, 180);
                lbl.Size = new Size(260, 170);
                roompanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();

                try
                {
                    pb.Load("../../Pic/" + rooms[i + 3]);
                }
                catch (Exception) { }
                pb.Location = new Point(xRooms, 20);
                pb.Size = new Size(285, 150);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = rooms[i];
                pb.Click += new EventHandler(One_pictureBox_Click);
                roompanel.Controls.Add(pb);

                xRooms += 300;


            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void One_pictureBox_Click(object sender, EventArgs e)
        {

            PictureBox pb = (PictureBox)sender;
            Form3 roomform = new Form3(pb.Tag.ToString());
            roomform.ShowDialog();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Sql_class.MyUpDate("UPDATE hotels SET opis = '" + OpistextBox.Text + "', phone  = '" + phonetextBox.Text + "', adress = '" + adresstextBox.Text + "' WHERE  id = " + id );
            MessageBox.Show("Сохранено");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
