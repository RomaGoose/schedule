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

            label1.Text = "Вы вошли как " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change brr = new change();
            brr.ShowDialog();
        }

        private void prepodForm_Load(object sender, EventArgs e)
        {

        }
    }
}
