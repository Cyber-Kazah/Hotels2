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
    public partial class AdminRoomsForm : Form
    {
        public AdminRoomsForm()
        {
            InitializeComponent();
        }

        private void AdminRoomsForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(Room_label);
            panel1.Controls.Add(Hotel_label);
            panel1.Controls.Add(Id_label);

            hotelcomboBox.Items.Clear();
            List<string> hotels = Sql_class.MySelect("SELECT id, Name FROM hotels");
            for (int i = 0; i < hotels.Count; i += 2)
            {
                hotelcomboBox.Items.Add(hotels[i] + ". " + hotels[i + 1]);
            }

            roomcomboBox.Items.Clear();
            List<string> rooming = Sql_class.MySelect("SELECT id, Name, hotel_id FROM rooms");
            for (int i = 0; i < rooming.Count; i += 3)
            {
                roomcomboBox.Items.Add(rooming[i] + ". " + rooming[i + 1] + ". " + rooming[i + 2]);
            }

            List<string> rooms = Sql_class.MySelect("SELECT id, name, hotel_id FROM rooms");

            int y = 50;
            for (int i = 0; i < rooms.Count; i += 3)
            {

                Label lbl1 = new Label();
                lbl1.Text = rooms[i];
                lbl1.Location = new Point(12, y);
                lbl1.Size = new Size(20, 20);
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Text = rooms[i + 1];
                lbl2.Location = new Point(120, y);
                lbl2.Size = new Size(100, 40);
                panel1.Controls.Add(lbl2);

                List<string> hotel = Sql_class.MySelect("SELECT Name FROM hotels WHERE id = '" + rooms[i + 2] + "' ");

                Label lbl3 = new Label();
                lbl3.Text = hotel[0];
                lbl3.Location = new Point(395, y);
                lbl3.Size = new Size(100, 40);
                panel1.Controls.Add(lbl3);

                Button btn1 = new Button();
                btn1.Location = new Point(735, y);
                btn1.Size = new Size(150, 40);
                btn1.Text = "Удалить";
                panel1.Controls.Add(btn1);

                y += 60;
            }
        }
    }
}
