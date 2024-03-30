using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace clientчето_там
{
   
    public partial class Account : Form
    {
        string name = main.username;
        string who = main.usertype;
        bool prep = main.usertype == "teachers";
        public string uid = main.userid;
        public List<string> subject_list;
        List<string> faculties;
        List<string> user_data;

        public Account()
        {
            InitializeComponent();
            label4.Text = name;
            subject_list = sql.Select("SELECT name, ID FROM subjects");
            
            if (prep)
            {
                label6.Text = "Предмет";
                label7.Text = "Второй предмет";
                button2.Text = "Сообщения";

                subject_list = sql.Select("SELECT name, ID FROM subjects");

                for (int i = 0; i < subject_list.Count; i += 2)
                {
                    subj1cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
                    subj2cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
                }
            }

            if (!prep)
            {
                label6.Text = "Направление";
                label7.Text = "Группа";
                button2.Text = "Отправить сообщение";

                faculties = sql.Select("SELECT name, ID FROM faculties");
               // List <string> facid = sql.Select("SELECT facID FROM students WHERE ID = '" + uid + "'");
               // List <string> groups = sql.Select("SELECT name, ID FROM groups WHERE facID = '" + facid + "'");

                for (int j = 0; j < faculties.Count; j += 2)
                    subj1cbx.Items.Add(faculties[j] + "," + faculties[j + 1]);
               // for (int i = 0; i < groups.Count; i += 2)
               //     subj2cbx.Items.Add(groups[i] + "," + groups[i + 1]);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void subj1cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            button1.Visible = true;

            nametb.Enabled = true;
            passtb.Enabled = true;
            logintb.Enabled = true;
            mailtb.Enabled = true;
            subj1cbx.Enabled = true;
            subj2cbx.Enabled = true;

            subj1cbx.Visible = true;
            subj2cbx.Visible = true;

            sub1lbl.Visible = false;
            sub2lbl.Visible = false;

            linkLabel1.Visible = false; 

        }
        private void UpdateClick(object sender, EventArgs e)
        {
            string[] parts1 = subj1cbx.Text.Split(new char[] { ',' });
            string[] parts2 = subj2cbx.Text.Split(new char[] { ',' });

            string s1 = subj1cbx.Text;
            string s2 = subj2cbx.Text;

            List<string> t = sql.Select("SELECT ID FROM teachers WHERE login = '" + logintb.Text + "'");
            List<string> s = sql.Select("SELECT ID FROM students WHERE login = '" + logintb.Text + "'");
            if (t.Count>0 && t[0] != uid || s.Count > 0 && s[0] != uid)
                MessageBox.Show("Такой логин уже занят", "Ошибка");
            else
            {
                if (prep && !(s1 == s2 || s1 == ",0"))
                {
                    sql.Select("UPDATE teachers SET name='" + nametb.Text + "' , login='" + logintb.Text + "' , password='" + passtb.Text + "' , mail='" + mailtb.Text + "' , subjID='" + parts1[1] + "' , subj2ID='" + parts2[1] + "' WHERE ID ='" + uid + "'");
                    MessageBox.Show("Сохранено");
                }
                else if (prep)
                    MessageBox.Show("Ошибка в выборе предметов");

                if (!prep)
                {
                    sql.Select("UPDATE students SET name='" + nametb.Text + "' , login='" + logintb.Text + "' , password='" + passtb.Text + "' , mail='" + mailtb.Text + "' , groupID='" + parts2[1] + "' WHERE ID ='" + uid + "'");
                    MessageBox.Show("Сохранено");
                }
                Account_Load(sender, e); 
       
            }
           }

        private void Account_Load(object sender, EventArgs e)
        {
            nametb.Enabled = false;
            passtb.Enabled = false;
            logintb.Enabled = false;
            mailtb.Enabled = false;
            subj1cbx.Enabled = false;
            subj2cbx.Enabled = false;
            subj1cbx.Visible = false;
            subj2cbx.Visible = false;
            sub1lbl.Visible = true;
            sub2lbl.Visible = true;
            linkLabel1.Visible = true;
            button1.Visible = false;

            List<string> sub1;
            List<string> sub2;
          
            if (prep)
            {
                user_data = sql.Select("SELECT name, login, password, mail, subjID, subj2ID FROM teachers WHERE ID = '" + uid + "'");
                for (int i = 0; i < subject_list.Count; i += 2)
                {
                    if (subject_list[i+1] == user_data[4])
                        subj1cbx.SelectedIndex = i / 2;
                    if (subject_list[i+1] == user_data[5])
                        subj2cbx.SelectedIndex = i / 2;
                    
                }
                sub1 = sql.Select("SELECT name FROM subjects WHERE ID = '" + user_data[4] + "'");
                sub2 = sql.Select("SELECT name FROM subjects WHERE ID = '" + user_data[5] + "'");

            }
            else
            {
                user_data = sql.Select("SELECT students.name, students.login, students.password, students.mail, groups.facID, students.groupID FROM students " +
                                          "JOIN groups ON students.groupID = groups.ID WHERE students.ID = '" + uid + "'");
                List<string> grs = sql.Select("SELECT name, ID FROM groups WHERE facID = '" + user_data[4] + "'");
                for (int i = 0; i < grs.Count; i += 2)
                {
                    subj2cbx.Items.Add(grs[i] + "," + grs[i + 1]);
                    if (grs[i + 1] == user_data[5])
                        subj2cbx.SelectedIndex = i / 2;
                }

                for (int i = 0; i < faculties.Count; i += 2)
                    if (faculties[i + 1] == user_data[4])
                        subj1cbx.SelectedIndex = i / 2;

                sub1 = sql.Select("SELECT name FROM faculties WHERE ID = '" + user_data[4] + "'");
                sub2 = sql.Select("SELECT name FROM groups WHERE ID = '" + user_data[5] + "'");
            }

            nametb.Text = user_data[0];
            logintb.Text = user_data[1];
            passtb.Text = user_data[2];
            mailtb.Text = user_data[3];
            sub1lbl.Text = sub1[0];
            sub2lbl.Text = sub2[0];
        }

        private void subj1cbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!prep)
            {
                string[] parts = subj1cbx.Text.Split(',');
                subj2cbx.Items.Clear();
                List<string> grlist = sql.Select("SELECT name, ID FROM groups WHERE facID = '" + parts[1] + "'");
                for (int i = 0; i < grlist.Count; i += 2)
                    subj2cbx.Items.Add(grlist[i] + ',' + grlist[i + 1]);
                for (int i = 0; i < grlist.Count; i += 2)
                    if (grlist[i + 1] == user_data[5])
                        subj2cbx.SelectedIndex = i / 2;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (prep) new prepodForm().ShowDialog();
            else new Send().ShowDialog();
        }
    }
}
