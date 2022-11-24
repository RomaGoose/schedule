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
    public partial class Account : Form
    {
        public int teacherid;
        public Account(string ID)
        {
            InitializeComponent();
            
            teacherid = Convert.ToInt32(ID);

            List<string> subject_list = main.MySelect("SELECT name, ID FROM subjects");

            subj1cbx.Items.Clear();
            for (int i = 0; i < subject_list.Count; i += 2)
            {
                subj1cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
                subj2cbx.Items.Add(subject_list[i] + "," + subject_list[i + 1]);
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
            Button btn = new Button();
            btn.Location = new Point(362, 296);
            btn.Name = "btn";
            btn.Size = new Size(122, 30);
            btn.Text = "Сохранить";
            btn.Click += new EventHandler(UpdateClick);
            Controls.Add(btn);

            nametb.Enabled = true;
            passtb.Enabled = true;
            logintb.Enabled = true;
            mailtb.Enabled = true;
            subj1cbx.Enabled = true;
            subj2cbx.Enabled = true;

        }
        private void UpdateClick(object sender, EventArgs e)
        {
            string[] parts1 = subj1cbx.Text.Split(new char[] { ',' });
            string[] parts2 = subj2cbx.Text.Split(new char[] { ',' });

            main.MyUpdate("UPDATE teachers SET name='" + nametb.Text + "' , login='" + logintb.Text + "' , password='" + passtb.Text + "' , subjID='" + parts1[1] + "' , subj2ID='" + parts2[1] + "'");
            MessageBox.Show("Сохранено");
            Account_Load(sender, e); 
        }

        private void Account_Load(object sender, EventArgs e)
        {

            string name = label1.Text; //еще mail гдето, спросиь можгно ли один цикл фор использовать а не два одинаковых сверху и снизуу
            List<string> user_data = main.MySelect("SELECT name, login, password, mail, subjID, subj2ID FROM teachers WHERE ID = '" + teacherid + "'");
           
            List<string> sub1 = main.MySelect("SELECT name FROM subjects WHERE ID = '" + user_data[4] + "'");
            List<string> sub2 = main.MySelect("SELECT name FROM subjects WHERE ID = '" + user_data[5] + "'");



            nametb.Text = user_data[0];
            logintb.Text = user_data[1];
            passtb.Text = user_data[2];
            mailtb.Text = user_data[3];
            subj1cbx.Text = sub1[0];
            subj2cbx.Text = sub2[0];

        }
    }
}
