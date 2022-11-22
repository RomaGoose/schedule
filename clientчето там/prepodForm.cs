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
    public partial class prepodForm : Form
    {
        public prepodForm(string name)
        {
            InitializeComponent();

           
            label1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change brr = new change();
            brr.ShowDialog();
        }

        private void prepodForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            List<string> subject_list = main.MySelect("SELECT name, ID FROM subjects");

            subj1cbx.Items.Clear();
            for (int i = 0; i < subject_list.Count; i += 2)
            {
                subj1cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
                subj2cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
            }





            string name = label1.Text; //еще mail гдето, спросиь можгно ли один цикл фор использовать а не два одинаковых сверху и снизуу
            List<string> user_data = main.MySelect("SELECT name, login, password, subjID, subj2ID FROM users WHERE name = '" + name + "'");
            List<string> subjs = main.MySelect("SELECT name, ID FROM subjects");

            string[] parts1 = subj1cbx.Text.Split(new char[] { ',' });
            string[] parts2 = subj2cbx.Text.Split(new char[] { ',' });

            for(int i = 0; i < subjs.Count; i += 2)
            {
                if (user_data[3] == subjs[i + 1])
                    subj1cbx.Text = subjs[i];

                if (user_data[4] == subjs[i + 1])
                    subj2cbx.Text = subjs[i];
            }

            nametb.Text = user_data[0];
            logintb.Text = user_data[1];
            passtb.Text = user_data[2];
            //mailtb.Text = user_data[x];





            
            main.MyUpdate("UPDATE users SET name='" + nametb.Text + "' , login='" + logintb.Text + "' , password='" + passtb.Text + "' , subjID='" + subj1cbx.Text + "' , subj2ID='" + subj2cbx.Text + "'");
            MessageBox.Show("Сохранено");
            // ...form.load спросиь тоже 

        }
    }
}
