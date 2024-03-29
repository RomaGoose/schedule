using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace clientчето_там
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();

            List<string> teachers = sql.Select("SELECT name, ID FROM teachers");
            for (int i = 0; i < teachers.Count; i+=2)
                CB.Items.Add(teachers[i] + ',' + teachers[i+1]);
        }

        private void CB_Leave(object sender, EventArgs e)
        {
            bool m = false;
            foreach (string it in CB.Items)
                if (it == CB.Text) m = true;
            if (!m) { MessageBox.Show("Выберите преподавателся"); CB.Focus(); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.Update("INSERT INTO messages (theme, text, studID, teachID) VALUES ('"+theme.Text+"', '"+ textBox3.Text +"', '"+ main.userid + "', '" + CB.Text.Split(',')[1] + "')");
        }
    }
}
