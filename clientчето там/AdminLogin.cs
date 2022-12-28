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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (passtb.Text.Length > 0 && logintb.Text.Length > 0)
            {
                List<string> list = sql.Select("SELECT login FROM admins WHERE login ='" + logintb.Text + "' AND password ='" + passtb.Text + "'");
                List<string> wrongpass = sql.Select("SELECT login FROM admins WHERE login ='" + logintb.Text + "'");
                List<string> loginl = sql.Select("SELECT login FROM admins WHERE password ='" + passtb.Text + "'");

                if (list.Count == 0 && loginl.Count == 0 && wrongpass.Count == 0) MessageBox.Show("Неправильный логин и пароль", "Ничего не угадал :(");
                if (list.Count == 0 && loginl.Count > 0 && wrongpass.Count == 0) MessageBox.Show("Неправильный логин, а вот пароль угадал...", "Проверь еще раз");
                if (list.Count == 0 && wrongpass.Count  > 0) MessageBox.Show("Неправильный пароль", "Ошибка");
                if (list.Count > 0)
                {
                    Admin sus = new Admin(list[0]);      
                    Close();
                    sus.ShowDialog();
                }
            }
            else
                MessageBox.Show("Заполните все поля", "Ошибка");
        }
    }
}
