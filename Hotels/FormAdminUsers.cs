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
    public partial class FormAdminUsers : Form
    {
        public FormAdminUsers()
        {
            InitializeComponent();
        }

        private void FormAdminUsers_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);

            List<string> users = Sql_class.MySelect("SELECT id, login, parol, name, surname FROM users ORDER BY name");

            int y = 50;
            for (int i = 0; i < users.Count; i += 5)
            {
                Label lbl1 = new Label();
                lbl1.Text = users[i];
                lbl1.Location = new Point(15, y);
                lbl1.Size = new Size(20, 20);
                lbl1.Tag = users[i];
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Text = users[i + 1];
                lbl2.Location = new Point(120, y);
                lbl2.Size = new Size(50, 20);
                lbl2.Tag = users[i];
                panel1.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Text = users[i + 2];
                lbl3.Location = new Point(329, y);
                lbl3.Size = new Size(30, 20);
                lbl3.Tag = users[i];
                panel1.Controls.Add(lbl3);

                Label lbl4 = new Label();
                lbl4.Text = users[i + 3];
                lbl4.Location = new Point(564, y);
                lbl4.Size = new Size(100, 20);
                lbl4.Tag = users[i];
                panel1.Controls.Add(lbl4);

                Label lbl5 = new Label();
                lbl5.Text = users[i + 4];
                lbl5.Location = new Point(752, y);
                lbl5.Size = new Size(100, 20);
                lbl5.Tag = users[i];
                panel1.Controls.Add(lbl5);

                Button btn = new Button();
                btn.Location = new Point(850, y);
                btn.Size = new Size(100, 40);
                btn.Text = "Удалить";
                //btn.Click += new EventHandler(DelUserClick);
                panel1.Controls.Add(btn);

                y += 60;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
