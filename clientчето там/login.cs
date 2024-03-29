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
    public partial class login : Form
    {

        bool cl = false;
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aut atcl = new aut();
            atcl.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {/*
            1. сделай чтобы нельзхя бюыло выбрать ищзначально два разных предметва в препод реге
            2. обновить при выходк из запросов кнопку желтукю
            3. при создании расписания разбить выбор факультетов и групп
            4. как нибудь избавься от циферок епта :(
            */
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            if(logintb.Text == "" || passtb.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
            }
            else
            {   
                List<string> fakeuser_data = sql.Select("SELECT login, name FROM requestteachers WHERE login = '" + logintb.Text + "'");
                if (fakeuser_data.Count > 0)
                    MessageBox.Show("Ваша заявка еще не одобрена", "Ошибка");

                List<string> t = sql.Select("SELECT login FROM teachers WHERE login = '" + logintb.Text + "'");
                List<string> s = sql.Select("SELECT login FROM students WHERE login = '" + logintb.Text + "'");
                
                if (t.Count == 0 && s.Count == 0)
                    MessageBox.Show("Неправильный логин", "Ошибка"); 
             
                string who = t.Count() > s.Count() ? "teachers" : "students";

               
                List<string> wrong_user_data = sql.Select("SELECT name FROM " + who + " WHERE login = '" + logintb.Text + "'");
                List<string> user_data = sql.Select("SELECT name, ID FROM " + who + " WHERE login = '" + logintb.Text + "' and password = '" + passtb.Text + "'");

               
                if (user_data.Count == 0 && wrong_user_data.Count > 0)
                    MessageBox.Show(wrong_user_data[0] + ", пароль неправильный.", "Ошибка");
                
                if (user_data.Count > 0)
                {
                    main.userid = user_data[1];
                    main.username = user_data[0];
                    main.usertype = who;
                    Close();
                }


               
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cl = !cl;
            if (cl) { pictureBox1.Load("../../pictures/eye.png"); passtb.UseSystemPasswordChar = true; }
            if (!cl) { pictureBox1.Load("../../pictures/opneye.png"); passtb.UseSystemPasswordChar = false; }
        }
    }
}
