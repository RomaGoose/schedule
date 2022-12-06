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
    public partial class Admin : Form
    {
        public Admin(string login)
        {
            InitializeComponent();

            List<string> list = sql.Select("SELECT name FROM requestteachers");

            if (list.Count > 0)
                button3.BackColor = Color.Gold;

            label1.Text += login;
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminTeacher sus = new AdminTeacher();
            sus.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSubject sus = new AdminSubject();
            sus.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            AdminRequestTeachers sus = new AdminRequestTeachers();
            sus.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminFacultiesGrs sus = new AdminFacultiesGrs();
            sus.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminAddSchedule sus = new AdminAddSchedule();
            sus.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminClasses sus = new AdminClasses();
            sus.ShowDialog();
        }
    }
}
