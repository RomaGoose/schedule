
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

            List<string> subject_list = sql.Select("SELECT name, ID FROM subjects");



            subj1cbx.Items.Clear();
            for (int i = 0; i < subject_list.Count; i += 2)
            {
                subj1cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
                subj2cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
            }
        }

        private void AdminTeacher_Load(object sender, EventArgs e)
        {
            List<string> list = sql.Select("SELECT name, mail, ID FROM teachers");
            pan.Controls.Clear();
           
            

            int y = 30;
            for(int i=0; i < list.Count; i+=3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(10, y);
                lbl.Size = new Size(300, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i];
                lbl.Name = "lbl" + i;
                lbl.Tag = list[i + 2];
                lbl.Visible = true;
                pan.Controls.Add(lbl); 
         
                TextBox tb = new TextBox();
                tb.Location = new Point(10, y);
                tb.Size = new Size(300, 20);
                tb.Font = new Font("Microsoft Sans Serif", 12);
                tb.Name = "tb" + i; 
                tb.Visible = false;
                tb.Text = list[i];
                tb.Tag = list[i + 2];
                pan.Controls.Add(tb);

                Label lbl2 = new Label();
                lbl2.Location = new Point(320, y); 
                lbl2.Size = new Size(300, 20);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = list[i + 1];
                lbl2.Name = "lbl2" + i;
                lbl2.Tag = list[i + 2];
                lbl2.Visible = true;
                pan.Controls.Add(lbl2); 
                
                TextBox tb2 = new TextBox();
                tb2.Location = new Point(320, y);
                tb2.Size = new Size(300, 20);
                tb2.Font = new Font("Microsoft Sans Serif", 12);
                tb2.Name = "tb2" + i; 
                tb2.Visible = false;
                tb2.Text = list[i + 1];
                tb2.Tag = list[i + 2];
                pan.Controls.Add(tb2);

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                pb.Load("../../pictures/change.png");
                pb.Click += new EventHandler(UpdateNameClick);
                pb.Location = new Point(640, y);
                pb.Size = new Size(30, 30);
                pb.SizeMode = PictureBoxSizeMode.Zoom; 
                toolTip1.SetToolTip(pb, "Изменить");
                pan.Controls.Add(pb);


                Button btn = new Button();
                btn.Location = new Point(680, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteHotelClick);
                btn.Text = "Удалить";
                pan.Controls.Add(btn);

                y += 30;
            }
        }
        private void UpdateNameClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            foreach (Control control in pan.Controls)
            {
                if (control.Location == new Point(10, y))
                {
                    if (control.Name.StartsWith("tb"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
            }
            foreach (Control control in pan.Controls)
            {
                if (control.Location == new Point(320, y))
                {
                    if (control.Name.StartsWith("tb"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
            }
            btn.Load("../../pictures/save.png");
            btn.Click += new EventHandler(SaveClick);
            toolTip1.SetToolTip(btn, "Сохранить");


        }
        private void SaveClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            foreach (Control control in pan.Controls)
            {
                if (control.Location == new Point(10, y))
                {
                    if (control.Name.StartsWith("tb"))
                    {
                        control.Visible = false;
                        sql.Update("UPDATE teachers SET name='" + control.Text + "' WHERE ID ='" + control.Tag + "'");
                    }
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = true;
                }
            }

            foreach (Control control in pan.Controls)
            {
                if (control.Location == new Point (320, y))
                {
                    if (control.Name.StartsWith("tb"))
                    {
                        control.Visible = false;
                        sql.Update("UPDATE teachers SET mail='" + control.Text + "' WHERE ID ='" + control.Tag + "'");
                        MessageBox.Show("Сохранено"); 
                      
                    }
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = true;
                }
            }
            btn.Load("../../pictures/change.png");
            btn.Click += new EventHandler(UpdateNameClick);
            AdminTeacher_Load(sender, e);
                 
        }

        private void DeleteHotelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach(Control control in pan.Controls)
            {
                if(control.Location == new Point (10, y))
                {
                    sql.Select("DELETE FROM teachers WHERE ID = '" + control.Tag + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminTeacher_Load(sender, e);
                    return;
                }
            }
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            string[] parts1 = subj1cbx.Text.Split(new char[] { ',' });
            string[] parts2 = subj2cbx.Text.Split(new char[] { ',' });

            if (subj1cbx.Text == subj2cbx.Text)
                MessageBox.Show("Bыбери два РАЗНЫХ предмета.");
               
            else
            {
                sql.Select("INSERT INTO teachers (name, login, password, mail, subjID, subj2ID)" +
                              "VALUES('" + namebx.Text + "', '" + loginbx.Text + "', '" + passbx.Text + "', '" + mailbx.Text + "', '" 
                              + parts1[1] + "', '" + parts2[1] + "')");
                MessageBox.Show("Сохранено");
            }

            loginbx.Text = "";
            namebx.Text = "";
            passbx.Text = "";
            subj1cbx.Text = "";
            subj2cbx.Text = "";
            mailbx.Text = "";

            AdminTeacher_Load(sender, e);
            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void namepan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mailpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void AdminTeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void addpan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
