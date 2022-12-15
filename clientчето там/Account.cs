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
        public List<string> subject_list;
        public Account(string ID, string name)
        {
            InitializeComponent();
            
            teacherid = Convert.ToInt32(ID);

            label4.Text = name;

            subject_list = sql.Select("SELECT name, ID FROM subjects");

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

            sql.Select("UPDATE teachers SET name='" + nametb.Text + "' , login='" + logintb.Text + "' , password='" + passtb.Text + "' , mail='" + mailtb.Text + "' , subjID='" + parts1[1] + "' , subj2ID='" + parts2[1] + "' WHERE ID ='" + teacherid + "'");
            MessageBox.Show("Сохранено");
            Account_Load(sender, e); 
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

            List<string> user_data = sql.Select("SELECT name, login, password, mail, subjID, subj2ID FROM teachers WHERE ID = '" + teacherid + "'");
         
            for (int i = 0; i < subject_list.Count; i += 2)
            {
                if (subject_list[i+1] == user_data[4])
                    subj1cbx.SelectedIndex = i / 2;
                if (subject_list[i+1] == user_data[5])
                    subj2cbx.SelectedIndex = i / 2;
            }

            List<string> sub1 = sql.Select("SELECT name FROM subjects WHERE ID = '" + user_data[4] + "'");
            List<string> sub2 = sql.Select("SELECT name FROM subjects WHERE ID = '" + user_data[5] + "'");

            nametb.Text = user_data[0];
            logintb.Text = user_data[1];
            passtb.Text = user_data[2];
            mailtb.Text = user_data[3];
            sub1lbl.Text = sub1[0];
            sub2lbl.Text = sub2[0];
        }
    }
}
