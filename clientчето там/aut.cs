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
        public aut()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametb.Text == "" || passtb.Text == "" || pass2tb.Text == "" || mailtb.Text == "" || subj1cbx.Text == "" || subj2cbx.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Да блин");
            }
            else 
            {
                if (passtb.Text != pass2tb.Text)
                    MessageBox.Show("Пароли не совпадают!", "Перепроверь");

                else
                {

                    string[] parts1 = subj1cbx.Text.Split(new char[] { ',' });
                    string[] parts2 = subj2cbx.Text.Split(new char[] { ',' });

                    if (subj1cbx.Text == subj2cbx.Text)
                        MessageBox.Show("О, Юлий Цезарь, выбери два РАЗНЫХ предмета.");

                    else
                    {
                        sql.Select("INSERT INTO requestteachers (name, login, password, mail, subjID, subj2ID)" +
                                      "VALUES('" + nametb.Text + "', '" + logintb.Text + "', '" + passtb.Text + "', '" + mailtb.Text + "', '"
                                      + parts1[1] + "', '" + parts2[1] + "')");
                        MessageBox.Show("Вы успешно зарегистрированы, ожидайте подтверждения", "Крутяк");
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
    }
}
