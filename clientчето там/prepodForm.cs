using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientчето_там
{
    public partial class prepodForm : Form
    {
        private string id;
        private string name;

        public prepodForm(string ID)
        {
            InitializeComponent();
            List<string> list = sql.Select("SELECT name FROM teachers WHERE ID = '" + ID + "'");
           
            id = ID;
            name = list[0];
            label1.Text = list[0];
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
            





           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account sus = new Account(id, name);
            sus.ShowDialog();
        }
    }
}
