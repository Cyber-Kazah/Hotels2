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
    public partial class FormAdminCities : Form
    {
        public FormAdminCities()
        {
            InitializeComponent();
            Text = "Форма управления таблицей \"Города\"";
        }

        private void DelCityClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int y = button.Location.Y;
            foreach(Control control in panel1.Controls)
            {
                if(control.Location == new Point(15, y))
                {
                    Sql_class.MyUpDate("DELETE FROM citys WHERE id = '" + control.Tag + "' ");
                    MessageBox.Show("Город удалён");
                }
            }
            FormAdminCities_Load(sender, e);
        }

        private void AddCity_button_Click(object sender, EventArgs e)
        {
            if (AddCity_textBox.Text != "")
            {
                Sql_class.MyUpDate("INSERT INTO citys (name) VALUE ('" + AddCity_textBox.Text + "')");
                MessageBox.Show("Город добавлен");
                AddCity_textBox.Clear();
            }
            else
            {
                MessageBox.Show("Название города не введенно");
            }
            FormAdminCities_Load(sender, e);

        }

        private void FormAdminCities_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            List<string> cities = Sql_class.MySelect("SELECT id, name FROM citys ORDER BY name");

            int y = 45;
            for (int i = 0; i < cities.Count; i += 2)
            {
                Label lbl = new Label();
                lbl.Text = cities[i + 1];
                lbl.Location = new Point(15, y);
                lbl.Size = new Size(95, 30);
                lbl.Tag = cities[i];
                panel1.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(115, y);
                btn.Size = new Size(60, 30);
                btn.Text = "Удалить";
                btn.Click += new EventHandler(DelCityClick);
                panel1.Controls.Add(btn);

                y += 30;
            }
        }
    }
}
