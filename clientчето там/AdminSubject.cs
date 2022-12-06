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
            List<string> list = sql.Select("SELECT name, ID FROM subjects");
            deletepan.Controls.Clear();

            int y = 30;
            for (int i = 0; i < list.Count; i+=2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(250, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Visible = true;
                lbl.Name = "lbl" + i;
                lbl.Text = list[i];
                lbl.Tag = list[i + 1];
                deletepan.Controls.Add(lbl);

                TextBox tb = new TextBox();
                tb.Location = new Point(50, y);
                tb.Size = new Size(250, 20);
                tb.Font = new Font("Microsoft Sans Serif", 12);
                tb.Visible = false;
                tb.Name = "tb" + i; 
                tb.Text = list[i];
                tb.Tag = list[i + 1];
                deletepan.Controls.Add(tb);

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                pb.Load("../../pictures/change.png");
                pb.Click += new EventHandler(UpdateNameClick);
                pb.Location = new Point(435, y);
                pb.Size = new Size(30, 30);
                toolTip1.SetToolTip(pb, "Изменить");
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                deletepan.Controls.Add(pb);
               
                Button btn = new Button();
                btn.Location = new Point(470, y);
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

            foreach (Control control in deletepan.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    sql.Select("DELETE FROM subjects WHERE ID = '" + control.Tag + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminSubject_Load(sender, e);
                    return;
                }
            }
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            sql.Select("INSERT INTO subjects (name)" +
                          "VALUES('" + namebx.Text +  "')");
            MessageBox.Show("Сохранено");
            AdminSubject_Load(sender, e);

            namebx.Text = "";
            return;
        }
        private void UpdateNameClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            foreach (Control control in deletepan.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    if (control.Name.StartsWith("tb"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
            }
            btn.Load("../../pictures/save.png");
            toolTip1.SetToolTip(btn, "Изменить");
            btn.Click += new EventHandler(SaveClick);


        }
        private void SaveClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            foreach (Control control in deletepan.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    if (control.Name.StartsWith("tb"))
                    {
                        control.Visible = false; 
                        sql.Update("UPDATE subjects SET name='" + control.Text + "' WHERE ID ='" + control.Tag + "'");
                        AdminSubject_Load(sender, e);
                        MessageBox.Show("Сохранено");
                     }
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = true;
                }
            }
            btn.Load("../../pictures/change.png");
            btn.Click += new EventHandler(UpdateNameClick);

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
