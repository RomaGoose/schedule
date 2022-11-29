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
    public partial class AdminSubject : Form
    {
        public AdminSubject()
        {
            InitializeComponent();
        }

        public List<string> subjectid = new List<string>();
        private void AdminSubject_Load(object sender, EventArgs e)
        {
            List<string> list = main.MySelect("SELECT name, ID FROM subjects");
            deletepan.Controls.Clear();

            int y = 30;
            for (int i = 0; i < list.Count; i+=2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(250, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i];
                lbl.Tag = list[i+1];
                deletepan.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(470, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteHotelClick);
                btn.Text = "Удалить";
                deletepan.Controls.Add(btn);

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                pb.Load("../../pictures/change.png");
                pb.Location = new Point(435, y);
                pb.Size = new Size(30, 30);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Click += new EventHandler(UpdateNameClick);
                deletepan.Controls.Add(pb);

                /*Image img = new Image();
                
                Button cbtn = new Button();
                cbtn.Location = new Point(315, y);
                cbtn.Size = new Size(30, 30);
                cbtn.Text = "";
                cbtn.BackgroundImage = 
                cbtn.Click += new EventHandler(UpdateNameClick);
                deletepan.Controls.Add(cbtn);
                */
                y += 30;
            }
        }


        private void DeleteHotelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in deletepan.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    main.MyUpdate("DELETE FROM subjects WHERE ID = '" + control.Tag + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminSubject_Load(sender, e);
                    return;
                }
            }
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            main.MyUpdate("INSERT INTO subjects (name)" +
                          "VALUES('" + namebx.Text +  "')");
            MessageBox.Show("Сохранено");
            AdminSubject_Load(sender, e);

            namebx.Text = " ";
            return;
        }
        private void UpdateNameClick(object sender, EventArgs e)
        {
           

         //   main.MyUpdate("UPDATE teachers SET name='" + nametb.Text + "' WHERE ID ='" + teacherid + "'");
            MessageBox.Show("Сохранено");
            AdminSubject_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                button1.PerformClick();
            }
        }
    }
}
