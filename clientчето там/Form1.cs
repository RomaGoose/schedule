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
    public partial class Form1 : Form
    {
        public Form1()
        {

            Label aaaa = new Label();
            aaaa.Text = "sdtstdfayhf";
            aaaa.Location = new Point(30, 30);
            Controls.Add(aaaa);

            Label a2aaa2 = new Label();
            a2aaa2.Text = "ye ffwdfasd";
            a2aaa2.Location = new Point(330, 30);
            Controls.Add(a2aaa2);


            Label mon = new Label();
            mon.AutoSize = true;
            mon.Font = new Font("Microsoft Sans Serif", 12F);
            mon.Location = new Point(20, 173);
            mon.Name = "mon";
            mon.Size = new Size(216, 20);
            mon.Text = "Понедельник";
            Controls.Add(mon);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
