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
                List<string> wrong_user_data = sql.Select("SELECT name FROM teachers WHERE login = '" + logintb.Text + "'");
                //List<string> wrong_fakeuser_data = sql.Select("SELECT name FROM requestteachers WHERE login = '" + logintb.Text + "'");
                List<string> user_data = sql.Select("SELECT login, name, ID FROM teachers WHERE login = '" + logintb.Text + "' and password = '" + passtb.Text + "'");
                List<string> fakeuser_data = sql.Select("SELECT login, name FROM requestteachers WHERE login = '" + logintb.Text + "'");
               // if (fakeuser_data.Count == 0 && wrong_fakeuser_data.Count > 0)
                  //  MessageBox.Show("Во-первых, " + wrong_fakeuser_data[0] + ", Вы не угадали пароль, во-вторых админы вашу заявку ещё не одобрили", "Комбо");

                if (fakeuser_data.Count > 0)
                    MessageBox.Show("Ваша заявка еще не одобрена", "Ошибка");

                if (user_data.Count == 0 && wrong_user_data.Count > 0)
                    MessageBox.Show(wrong_user_data[0] + ", пароль неправильный.", "Ошибка");
                
                if (user_data.Count > 0)
                {
                    main.userid = user_data[2];
                    main.username = user_data[1];
                    main.usertype = "teachers";
                    Close();
                }

                if (user_data.Count == 0 && fakeuser_data.Count == 0 && wrong_user_data.Count == 0)
                    MessageBox.Show("Неправильный логин", "Ошибка");

               
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
