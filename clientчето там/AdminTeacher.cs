
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
using static System.Net.Mime.MediaTypeNames;

namespace clientчето_там
{
    public partial class AdminTeacher : Form
    {
        bool prep = true;
        string table = "";
        
        public AdminTeacher()
        {
            InitializeComponent();

             }

        private void AdminTeacher_Load(object sender, EventArgs e)
        {
            List<string> subject_list = sql.Select("SELECT name, ID FROM subjects WHERE ID != '0'");
            List<string> faculties = sql.Select("SELECT name, ID FROM faculties");
            List<string> groups = sql.Select("SELECT name, facID, ID FROM groups");


            if (!prep)
                table = "students";
            else
                table = "teachers";

            subj1cbx.Items.Clear();
            if (prep)
                for (int i = 0; i < subject_list.Count; i += 2)
                {
                    subj1cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
                    subj2cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
                }

            if (!prep)
                for (int j = 0; j < faculties.Count; j += 2)
                    for (int i = 0; i < groups.Count; i += 3)
                        if (groups[i + 1] == faculties[j + 1])
                            subj1cbx.Items.Add(groups[i] + "," + faculties[j] + "," + groups[i + 2]);

            if (!prep)
                table = "students";
            else
                table = "teachers";
            List<string> list = sql.Select("SELECT name, mail, ID, role FROM " + table +" WHERE ID != '0'");
            pan.Controls.Clear();

            int y = 10;
            for(int i=0; i < list.Count; i+=4)
            {
                int nd = 0;
                string txt = "";

                if (list[i + 3] == "no") nd = 0;
                if (list[i + 3] == "admin") nd = 1;
                if (list[i + 3] == "changer") nd = 2;

                if (list[i + 3] == "no") txt = "нет";
                if (list[i + 3] == "admin") txt = "админ";
                if (list[i + 3] == "changer") txt = "староста";



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
                lbl2.Size = new Size(250, 20);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = list[i + 1];
                lbl2.Name = "lbl2" + i;
                lbl2.Tag = list[i + 2];
                lbl2.Visible = true;
                pan.Controls.Add(lbl2);

                TextBox tb2 = new TextBox();
                tb2.Location = new Point(320, y);
                tb2.Size = new Size(250, 20);
                tb2.Font = new Font("Microsoft Sans Serif", 12);
                tb2.Name = "tb2" + i;
                tb2.Visible = false;
                tb2.Text = list[i + 1];
                tb2.Tag = list[i + 2];
                pan.Controls.Add(tb2); 
                
                Label lbl3 = new Label();
                lbl3.Location = new Point(585, y);
                lbl3.Size = new Size(120, 20);
                lbl3.Font = new Font("Microsoft Sans Serif", 12);
                lbl3.Text = txt;
                lbl3.Name = "lbl3" + i;
                lbl3.Tag = list[i + 2];
                lbl3.Visible = true;
                pan.Controls.Add(lbl3);

                ComboBox cmbx = new ComboBox();
                cmbx.Location = new Point(585, y);
                cmbx.Size = new Size(120, 20);
                cmbx.Font = new Font("Microsoft Sans Serif", 12);
                cmbx.Name = "cmbx" + i;
                cmbx.Items.Add("нет");
                cmbx.Items.Add("админ");
                cmbx.Items.Add("староста");
                cmbx.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbx.SelectedIndex = nd;
                cmbx.Visible = false;
                cmbx.Tag = list[i + 2];
                pan.Controls.Add(cmbx);

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                pb.Load("../../pictures/change.png");
                pb.Click += new EventHandler(UpdateNameClick);
                pb.Location = new Point(720, y);
                pb.Size = new Size(30, 30);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = list[i + 2];
                toolTip1.SetToolTip(pb, "Изменить");
                pan.Controls.Add(pb);


                Button btn = new Button();
                btn.Location = new Point(760, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteHotelClick);
                btn.Tag = list[i + 2];
                btn.Text = "Удалить";
                pan.Controls.Add(btn);

                y += 30;
            }
        }
        private void UpdateNameClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            object tag = btn.Tag;
            foreach (Control control in pan.Controls)
            {
                if (control.Location.X == 10 && control.Tag == tag)
                {
                    control.Location = new Point(10, y);
                    if (control.Name.StartsWith("tb"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
                if (control.Location.X == 320 && control.Tag == tag)
                {
                    control.Location = new Point(320, y);
                    if (control.Name.StartsWith("tb"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
                if (control.Location.X == 585 && control.Tag == tag)
                {
                    control.Location = new Point(585, y);
                    if (control.Name.StartsWith("cmbx"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
            }
           // foreach (Control control in pan.Controls)
           // {
               
          //  }
            btn.Load("../../pictures/save.png");
            btn.Click += new EventHandler(SaveClick);
            toolTip1.SetToolTip(btn, "Сохранить");


        }
        private void SaveClick(object sender, EventArgs e)
        {
            
             
            PictureBox btn = (PictureBox)sender;
            object tag = btn.Tag;
            int y = btn.Location.Y;
             foreach (Control control in pan.Controls)
             {
                if (control.Location.X == 10 && control.Tag == tag)
                {
                    control.Location = new Point(10, y);
                    if (control.Name.StartsWith("tb"))
                    {
                        control.Visible = false;
                        sql.Update("UPDATE " + table + " SET name='" + control.Text + "' WHERE ID ='" + control.Tag + "'");
                    }
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = true;
                }
                //   }

                //   foreach (Control control in pan.Controls)
                //   {
                if (control.Location.X == 320 && control.Tag == tag)
                {
                    control.Location = new Point(320, y);
                    if (control.Name.StartsWith("tb"))
                    {
                        control.Visible = false;
                        sql.Update("UPDATE " + table + " SET mail='" + control.Text + "' WHERE ID ='" + control.Tag + "'");
               
                    }
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = true;
                }
                if (control.Location.X == 585 && control.Tag == tag)
                {
                    control.Location = new Point(585, y);
                    if (control.Name.StartsWith("cmbx"))
                    {
                        string txt = "";
                        if (control.Text == "нет") txt = "no";
                        if (control.Text == "админ") txt = "admin";
                        if (control.Text == "староста") txt = "changer";

                        control.Visible = false;
                        if (txt != "")
                        sql.Update("UPDATE " + table + " SET role='" + txt + "' WHERE ID ='" + control.Tag + "'");
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

            sql.Select("DELETE FROM " + table + " WHERE ID = '" + btn.Tag + "'");
            MessageBox.Show("Удалено");
            AdminTeacher_Load(sender, e);
           
            
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            string[] parts1 = subj1cbx.Text.Split(new char[] { ',' });
            string[] parts2 = subj2cbx.Text.Split(new char[] { ',' });
            string fk;
            if (parts2[0] == "") fk = "0";
            else fk = parts2[1];


            string txt = "";
            if (rulecbx.Text == "нет") txt = "no";
            if (rulecbx.Text == "админ") txt = "admin";
            if (rulecbx.Text == "староста") txt = "changer";

            if (loginbx.Text != "" && namebx.Text != "" && passbx.Text != "" && mailbx.Text != "" && rulecbx.Text != "" && (!prep && subj1cbx.Text != ""))
            {
                List<string> t = sql.Select("SELECT login FROM teachers WHERE login = '" + loginbx.Text + "'");
                List<string> s = sql.Select("SELECT login FROM students WHERE login = '" + loginbx.Text + "'");
                if (t.Contains(loginbx.Text) || s.Contains(loginbx.Text))
                    MessageBox.Show("Такой логин уже занят", "Ошибка");
                else
                {
                    if (prep)
                    {
                        if ((subj1cbx.Text == "" && subj2cbx.Text == "") || (subj1cbx.Text == ",0" && subj2cbx.Text == ",0"))
                            MessageBox.Show("Bыберите хотя бы один предмет.");

                        else if (subj1cbx.Text == subj2cbx.Text)
                            MessageBox.Show("Bыберите два РАЗНЫХ предмета.");

                        else
                        {
                            sql.Select("INSERT INTO teachers (name, login, password, mail, subjID, subj2ID, role)" +
                                          "VALUES('" + namebx.Text + "', '" + loginbx.Text + "', '" + passbx.Text + "', '" + mailbx.Text + "', '"
                                          + parts1[1] + "', '" + fk + "', '" + txt + "')");
                            MessageBox.Show("Сохранено");
                        }
                    }
                    else 
                    {
                        sql.Select("INSERT INTO students (name, login, password, mail, role, groupID)" +
                                        "VALUES('" + namebx.Text + "', '" + loginbx.Text + "', '" + passbx.Text + "', '" + mailbx.Text + "', '" + txt + "', '" + parts1[1] + "')");
                        MessageBox.Show("Сохранено");
                    }

                    loginbx.Text = "";
                    namebx.Text = "";
                    passbx.Text = "";
                    subj1cbx.SelectedIndex = -1;
                    subj2cbx.SelectedIndex = -1;
                    rulecbx.SelectedIndex = -1;
                    mailbx.Text = "";

                    AdminTeacher_Load(sender, e);
                    return;
                }
               
            }

            else
            MessageBox.Show("Заполните все поля.", "Ошибка");

          
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

        private void pan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subj2cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            prep = !prep;
            subj1cbx.Items.Clear();
            if (prep) { subj1cbx.Width = 140; label4.Text = "Выберите предмет..."; }
            if (!prep) { subj1cbx.Width = 250; label4.Text = "Выберите группу..."; }
            subj2cbx.Visible = !subj2cbx.Visible;
            label6.Visible = !label6.Visible;
            AdminTeacher_Load(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
