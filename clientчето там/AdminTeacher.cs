
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientчето_там
{
    public partial class AdminTeacher : Form
    {
        public AdminTeacher()
        {
            InitializeComponent();
        }

        private void AdminTeacher_Load(object sender, EventArgs e)
        {
            List<string> list = main.MySelect("SELECT name FROM teachers");
            deletepan.Controls.Clear();

            int y = 30;
            for(int i=0; i < list.Count; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(250, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i];
                deletepan.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(350, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteHotelClick);
                btn.Text = "Удалить";
                deletepan.Controls.Add(btn);

                y += 30;
            }
        }

        private void DeleteHotelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach(Control control in deletepan.Controls)
            {
                if(control.Location == new Point (50, y))
                {
                    main.MyUpdate("DELETE FROM teachers WHERE name = '" + control.Text + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminTeacher_Load(sender, e);
                    return;
                }
            }
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            main.MyUpdate("INSERT INTO teachers (name, password, subject, subject2, mail)" +
                          "VALUES('" + namebx.Text + "', '" + passbx.Text + "', '" + subjbx.Text + "', '"
                          + subj2bx.Text + "', '" + mailbx.Text + "')");
            MessageBox.Show("Сохранено");
            AdminTeacher_Load(sender, e);
            return;
        }


    }
}
