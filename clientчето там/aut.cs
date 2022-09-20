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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametb.Text == "" || passtb.Text == "" || pass2tb.Text == "" || mailtb.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Да блин");
            }
            else 
            {
                MessageBox.Show("Вы успешно зарегистрированы, пожалуйста, перейдите на вкладку авторизации и войдите в аккаунт", "Крутяк");
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
