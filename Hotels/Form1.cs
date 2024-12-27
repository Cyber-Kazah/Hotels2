using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Hotels
{
    //города
    public partial class Form1 : Form
    {
        

        public static string UserName = "";
        public static string Login = "";
        public static string UserSurname = "";
        public static int isAdmin;

        public Form1()
        {
            InitializeComponent();

            Filtr_panel.Height = Filtr_button.Height;

            Hellolabel.Visible = false;
            Admin_button.Visible = false;
            Reg_button.Visible = true;
            Search_button_Click(null, null);


        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Filtr_panel.Height > 100)
            {
                Filtr_panel.Height = Filtr_button.Height;
            }
            else
            {
                Filtr_panel.Height = 160;
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Form2 hotelform = new Form2(pb.Tag.ToString());
            hotelform.ShowDialog();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            List<string> citys = Sql_class.MySelect("SELECT id, Name FROM citys");

            City_comboBox.Items.Clear();
            City_comboBox.Items.Add("");

            for (int i = 0; i < citys.Count; i += 2)
            {
                City_comboBox.Items.Add(citys[i] + ". " + citys[i+1]);
            }

            string cmdText = "SELECT id, name, rate, city_id, pic FROM hotels WHERE 1";

            if(City_comboBox.Text != "")
            {
                cmdText += " AND city_id = '" + City_comboBox.Text + "'";
            }

            if (Rate_comboBox.Text != "")
            {
                cmdText += " AND rate = '" + Rate_comboBox.Text + "'";
            }

            List<string> hotels = Sql_class.MySelect(cmdText);
            Mainpanel.Controls.Clear();
            int x = 20;
            for (int i = 0; i < hotels.Count; i += 5)
            {
                Label lbl = new Label();
                lbl.Text = hotels[i + 1];
                lbl.Location = new Point(x, 300);
                lbl.Size = new Size(300, 230);
                Mainpanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();

                try
                {
                    pb.Load("../../Pic/" + hotels[i + 4]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 20);
                pb.Size = new Size(350, 250);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = hotels[i];
                pb.Click += new EventHandler(pictureBox1_Click);
                Mainpanel.Controls.Add(pb);

                x += 380;
            }
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            

            List <string> user = Sql_class.MySelect("SELECT login, parol, name, surname, admin FROM users WHERE login = '" + Log_textBox.Text + "' AND parol = '" + Pass_textBox.Text + "'");

            if (Enter_button.Text == "Выйти")
            {
                

                UserName = "";
                UserSurname = "";
                isAdmin = Convert.ToInt32(user[4]);
                Auth_panel.Controls.Clear();
                Auth_panel.Controls.Add(label1);
                Auth_panel.Controls.Add(label2);
                Log_textBox.Text = "";
                Auth_panel.Controls.Add(Log_textBox);
                Pass_textBox.Text = "";
                Auth_panel.Controls.Add(Pass_textBox);
                Auth_panel.Controls.Add(Enter_button);
                Hellolabel.Text = "";
                Hellolabel.Visible = false;
                Reg_button.Visible = true;

                Auth_panel.Controls.Add(Reg_button);
                Admin_button.Visible = Convert.ToBoolean(isAdmin);

                Enter_button.Text = "Войти";


            }
            else
            {


                if (user.Count > 0)
                {
                    UserName = user[3];
                    UserSurname = user[2];
                    isAdmin = Convert.ToInt32(user[4]);

                    Auth_panel.Controls.Clear();
                    Auth_panel.Controls.Add(Hellolabel);
                    Hellolabel.Visible = true;
                    Hellolabel.Text = "Здравствуйте, " + UserName + " " + UserSurname;
                    Auth_panel.Controls.Add(Enter_button);
                    Enter_button.Text = "Выйти";
                    Admin_button.Visible = Convert.ToBoolean(isAdmin);
                    Auth_panel.Controls.Add(Admin_button);

                    Reg_button.Visible = false;
                    Auth_panel.Controls.Add(Reg_button);
                }
                else
                {
                    Log_textBox.Text = "";
                    Pass_textBox.Text = "";
                    var results = MessageBox.Show("вы указади неверный логин-пароль или вы не зарегестрированы. Создать новую учётную запись?", "Ошибка", MessageBoxButtons.YesNo);
                    if (results == DialogResult.Yes)
                    {
                        FormReg formreg = new FormReg();
                        formreg.ShowDialog();
                    }

                }
            }
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            FormAdmin formadmin = new FormAdmin();
            formadmin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_textBox.Text = "zam";
            Pass_textBox.Text = "2008";
        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            FormReg formreg = new FormReg();
            formreg.ShowDialog();
        }
    }
}
