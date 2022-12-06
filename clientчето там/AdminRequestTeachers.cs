using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientчето_там
{
    public partial class AdminRequestTeachers : Form
    {
        public AdminRequestTeachers()
        {
            InitializeComponent();
        }

        private void AdminRequestTeachers_Load(object sender, EventArgs e)
        {
            List<string> list = sql.Select("SELECT name, subjID, subj2ID FROM requestteachers");
            panel.Controls.Clear();

            int y = 30;
            for (int i = 0; i < list.Count; i += 3)
            {
                List<string> sublist = sql.Select("SELECT name FROM subjects WHERE ID = '" + list[i + 1] + "'");
                List<string> sub2list = sql.Select("SELECT name FROM subjects WHERE ID = '" + list[i + 2] + "'");

                Label lbl = new Label();
                lbl.Location = new Point(20, y);
                lbl.Size = new Size(150, 50);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i]; 
                panel.Controls.Add(lbl);

                Label subjlbl = new Label();
                subjlbl.Location = new Point(180, y);
                subjlbl.Size = new Size(170, 50);
                subjlbl.Font = new Font("Microsoft Sans Serif", 12);
                subjlbl.Text = sublist[0];
                panel.Controls.Add(subjlbl);

                Label subj2lbl = new Label();
                subj2lbl.Location = new Point(360, y);
                subj2lbl.Size = new Size(170, 50);
                subj2lbl.Font = new Font("Microsoft Sans Serif", 12);
                subj2lbl.Text = sub2list[0];
                panel.Controls.Add(subj2lbl);

                Button btn = new Button(); 
                btn.Location = new Point(530, y);
                btn.Size = new Size(120, 50);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(AcceptClick);
                btn.BackColor = Color.LimeGreen;
                btn.Text = "Принять";
                panel.Controls.Add(btn);

                Button btn2 = new Button();
                btn2.Location = new Point(670, y);
                btn2.Size = new Size(120, 50);
                btn2.Font = new Font("Microsoft Sans Serif", 12);
                btn2.Click += new EventHandler(DeleteClick);
                btn2.BackColor = Color.Red;
                btn2.Text = "Отклонить";
                panel.Controls.Add(btn2);

                y += 60;
            }
        }

        private void AcceptClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            int x = panel.AutoScrollPosition.X;


            foreach (Control control in panel.Controls)
            {
                if (control.Location == new Point(20 + x, y))
                {
                    List<string> list = sql.Select("SELECT name, login, password, mail, subjID, subj2ID FROM requestteachers WHERE name = '" + control.Text + "'");


                    sql.Select("INSERT INTO teachers (name, login, password, mail, subjID, subj2ID)" +
                                  "VALUES('" + list[0] + "', '" + list[1] + "', '" + list[2] + 
                                  "', '" + list[3] + "', '" + list[4] + "', '" + list[5] + "')"); 
                    
                    sql.Select("DELETE FROM requestteachers WHERE name = '" + control.Text + "'");
                    MessageBox.Show("Плюс один кадр", "Принято");

                    AdminRequestTeachers_Load(sender, e);
                    return;
                }
            }
        }

        private void DeleteClick(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            int y = btn.Location.Y;
            int x = panel.AutoScrollPosition.X;
            foreach (Control control in panel.Controls)
            {
                if (control.Location == new Point(20 + x, y))
                {
                    sql.Select("DELETE FROM requestteachers WHERE name = '" + control.Text + "'");
                    MessageBox.Show("Жалко его","Отклонено");
                    AdminRequestTeachers_Load(sender, e);
                    return;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
