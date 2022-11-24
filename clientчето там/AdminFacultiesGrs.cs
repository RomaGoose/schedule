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
    public partial class AdminFacultiesGrs : Form
    {
        public AdminFacultiesGrs()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminFacultiesGrs_Load(object sender, EventArgs e)
        {
            List<string> faclist = main.MySelect("SELECT name, ID FROM faculties");
            List<string> grlist = main.MySelect("SELECT name FROM groups");

            comboBox1.Items.Clear();
            for (int i = 0; i < faclist.Count; i += 2)
                comboBox1.Items.Add(faclist[i] + "," + faclist[i + 1]);
            
            
            facpan.Controls.Clear();

            int y = 30;
            for (int i = 0; i < faclist.Count; i += 2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(30, y);
                lbl.Size = new Size(250, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = faclist[i];
                facpan.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(350, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteFacClick);
                btn.Text = "Удалить";
                facpan.Controls.Add(btn);

                y += 30;
            }
           
            for (int i = 0; i < grlist.Count; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(30, y);
                lbl.Size = new Size(250, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = grlist[i];
                grpan.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(350, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteGrClick);
                btn.Text = "Удалить";
                grpan.Controls.Add(btn);

                y += 30;
            }
        }
        private void DeleteFacClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            int x = facpan.AutoScrollPosition.X;

            foreach (Control control in facpan.Controls)
            {
                if (control.Location == new Point(30 + x, y))
                {
                    main.MyUpdate("DELETE FROM faculties WHERE name = '" + control.Text + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminFacultiesGrs_Load(sender, e);
                    return;
                }
            }
        }
        private void DeleteGrClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            int x = grpan.AutoScrollPosition.X;

            foreach (Control control in grpan.Controls)
            {
                if (control.Location == new Point(30 + x, y))
                {
                    main.MyUpdate("DELETE FROM groups WHERE name = '" + control.Text + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminFacultiesGrs_Load(sender, e);
                    return;
                }
            }
        }
       
        private void AddFacClick(object sender, EventArgs e)
        {
            if (facnametb.Text == " ")
                MessageBox.Show("Заполните поле", "Обшибка");

            else
            {
                main.MyUpdate("INSERT INTO faculties (name) VALUES('" + facnametb.Text + "')");
                MessageBox.Show("Сохранено", "Успешно");
            }

            facnametb.Text = " ";

            AdminFacultiesGrs_Load(sender, e);
        }
        private void AddGrClick(object sender, EventArgs e)
        {
            string[] parts = comboBox1.Text.Split(new char[] { ',' });

            if (groupnametb.Text == " ")
                MessageBox.Show("Заполните поле", "Обшибка");

            else
            {
                main.MyUpdate("INSERT INTO groups (name, facID) VALUES('" + groupnametb.Text + "','" + parts[1] +"')");
                MessageBox.Show("Сохранено", "Успешно");
            }

            groupnametb.Text = " ";

            AdminFacultiesGrs_Load(sender, e);

        }
    }
}
