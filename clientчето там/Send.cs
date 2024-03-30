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
        bool prep = main.usertype == "teachers";
        public static string messid;
        public Send()
        {
            InitializeComponent();
            
            List<string> teachers = sql.Select("SELECT name, ID FROM teachers");
            for (int i = 0; i < teachers.Count; i+=2)
                CB.Items.Add(teachers[i] + ',' + teachers[i+1]);
            
            if (prep)
            {
                List<string> mess = sql.Select("SELECT theme, text, students.name, groups.name FROM messages " +
                                                  " JOIN students ON students.ID = messages.studID" +
                                                  " JOIN groups ON students.groupID = groups.ID" +
                                                  " WHERE messages.ID = " + messid + "");


                label1.Text = "От: " + mess[2] + ", из группы: " + mess[3];
                label2.Text = "Тема: " + mess[0];
                label3.Text = "Сообщение";
                CB.Visible = false;
                theme.Visible = false;
                textBox3.Text = mess[1];
                textBox3.ReadOnly= true;
            }

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
            MessageBox.Show("Сообщение отправлено");
            this.Close();
        }

        private void Send_Load(object sender, EventArgs e)
        {
            textBox3.Select(0, 0);
        }
    }
}
