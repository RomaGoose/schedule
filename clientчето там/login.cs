﻿using System;
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
            if(nametb.Text == "" || passtb.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Да блин");
            }
            else
            {
                prepodForm pf = new prepodForm();
                pf.ShowDialog();
            }
        }
    }
}
