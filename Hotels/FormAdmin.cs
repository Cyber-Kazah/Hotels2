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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminCities formadmincities = new FormAdminCities();
            formadmincities.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminHotels formadminhotels = new FormAdminHotels();
            formadminhotels.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminRoomsForm formroomshotels = new AdminRoomsForm();
            formroomshotels.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAdminUsers formusers = new FormAdminUsers();
            formusers.ShowDialog();
        }
    }
}
