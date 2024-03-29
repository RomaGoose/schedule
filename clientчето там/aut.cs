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
    public partial class aut : Form
    {

        bool prep = true;
        public aut()
        {
            InitializeComponent();


            List<string> subject_list = sql.Select("SELECT name, ID FROM subjects");

            subj1cbx.Items.Clear();
            for (int i = 0; i < subject_list.Count; i += 2)
            {
                subj1cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametb.Text == "" || passtb.Text == "" || pass2tb.Text == "" || mailtb.Text == "" ||subj1cbx.Text == "" )
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
            }
            else 
            {
                if (passtb.Text != pass2tb.Text)
                    MessageBox.Show("Пароли не совпадают", "Ошибка");

                else
                {
                    if (prep)
                    {
                        string[] parts1 = subj1cbx.Text.Split(new char[] { ',' });
                        string[] parts2 = subj2cbx.Text.Split(new char[] { ',' });
                        string s2;
                        if (parts1.Length == 0)
                            s2 = "0";
                        else s2 = parts1[1];


                        sql.Select("INSERT INTO requestteachers (name, login, password, mail, subjID, subj2ID)" +
                                "VALUES('" + nametb.Text + "', '" + logintb.Text + "', '" + passtb.Text + "', '" + mailtb.Text + "', '"
                                + parts1[1] + "', '" + parts2[1] + "')");
                        MessageBox.Show("Заявка отправлена, ожидайте подтверждения", "Успех");
                    }
                    else
                    {
                        string[] parts1 = subj1cbx.Text.Split(new char[] { ',' });

                        sql.Select("INSERT INTO students (name, login, password, mail, groupID)" +
                                "VALUES('" + nametb.Text + "', '" + logintb.Text + "', '" + passtb.Text + "', '" + mailtb.Text + "', '" + parts1[1] + "')");
                        MessageBox.Show("Вы успешно зарегистрированы", "Успех");
                    }
                    
                }
            }
        }

        private void passtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void aut_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (TextBox con in Controls)
            //    con.Text = "";
            subj2cbx.Items.Clear();
            subj1cbx.Items.Clear();
            subj2cbx.Enabled= false;
            prep = !prep;
            if (prep) 
            { 
                label6.Text = "Выберите Ваш предмет...";
                label7.Text = "Выберите Ваш второй предмет...(если есть)";

                List<string> subject_list = sql.Select("SELECT name, ID FROM subjects");

                for (int i = 0; i < subject_list.Count; i += 2)
                    subj1cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
            }

            if (!prep) 
            { 
                label6.Text = "Выберите Ваше направление...";
                label7.Text = "Выберите Вашу группу...";

                List<string> faculties = sql.Select("SELECT name, ID FROM faculties");
              
                for (int j = 0; j < faculties.Count; j += 2)
                    subj1cbx.Items.Add( faculties[j] + "," + faculties[j + 1]);

            }

        }

        bool cl = true;
        bool cl2 = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cl = !cl;
            if (cl) { pictureBox1.Load("../../pictures/eye.png"); passtb.UseSystemPasswordChar = true; }
            if (!cl) { pictureBox1.Load("../../pictures/opneye.png"); passtb.UseSystemPasswordChar = false; }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cl2 = !cl2;
            if (cl2) { pictureBox2.Load("../../pictures/eye.png"); pass2tb.UseSystemPasswordChar = true; }
            if (!cl2) { pictureBox2.Load("../../pictures/opneye.png"); pass2tb.UseSystemPasswordChar = false; }
        }

        private void subj1cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] parts = subj1cbx.Text.Split(',');
            subj2cbx.Enabled = true;
            if (!prep)
            {
                List<string> groups = sql.Select("SELECT name, ID FROM groups WHERE facID = '" + parts[1] + "'");

                for (int i = 0; i < groups.Count; i += 2)
                    subj2cbx.Items.Add(groups[i] + "," + groups[i + 1]);
            }
            if (prep)
            {
                List<string> groups = sql.Select("SELECT name, ID FROM subjects WHERE ID != '" + parts[1] + "'");

                for (int i = 0; i < groups.Count; i += 2)
                    subj2cbx.Items.Add(groups[i] + "," + groups[i + 1]);
            }
        }
    }
}
