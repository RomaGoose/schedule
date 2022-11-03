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
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {   
            if(logintb.Text == "" || passtb.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Да блин");
            }
            else
            {
                List<string> user_data = main.MySelect("SELECT login, name FROM teachers WHERE login = '" + logintb.Text + "' and password = '" + passtb.Text + "'");
                List<string> fakeuser_data = main.MySelect("SELECT login, name FROM requestteachers WHERE login = '" + logintb.Text + "' and password = '" + passtb.Text + "'");
                if (fakeuser_data.Count > 0)
                    MessageBox.Show("Погоди, админы спят или им просто лень принимать заявку", "Рано тебе сюда...");

                if (user_data.Count > 0)
                {
                    prepodForm pf = new prepodForm(user_data[1]);
                    pf.ShowDialog();
                }

               
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
