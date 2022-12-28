using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Security.AccessControl;

namespace clientчето_там
{
    #region подсказки типа
    /* 
     */
    #endregion


    public partial class main : Form
    {

        /// <summary>
        /// Функция Select-запроса
        /// </summary>
        private string who = "";
        List<string> grav = new List<string>();
        public main()
        {
       
            #region lable 
            // 
            // mon
            // 
            Label mon = new Label();
            mon.AutoSize = true;
            mon.Font = new Font("Microsoft Sans Serif", 12F);
            mon.Location = new Point(20, 173);
            mon.Name = "mon";
            mon.Size = new Size(216, 20);
            mon.Text = "Понедельник";
            Controls.Add(mon);
            // 
            // tue
            // 
            Label tue = new Label();
            tue.AutoSize = true;
            tue.Font = new Font("Microsoft Sans Serif", 12F);
            tue.Location = new Point(20, 245 + 160);
            tue.Name = "tue";
            tue.Size = new Size(176, 20);
            tue.Text = "Вторник";
            Controls.Add(tue);
            // 
            // wed
            // 
            Label wed = new Label();
            wed.AutoSize = true;
            wed.Font = new Font("Microsoft Sans Serif", 12F);
            wed.Location = new Point(20, 479 + 160);
            wed.Name = "wed";
            wed.Size = new Size(161, 20);
            wed.Text = "Среда";
            Controls.Add(wed);
            // 
            // thu
            // 
            Label thu = new Label();
            thu.AutoSize = true;
            thu.Font = new Font("Microsoft Sans Serif", 12F);
            thu.Location = new Point(339, 13 + 160);
            thu.Name = "thu";
            thu.Size = new Size(176, 20);
            thu.Text = "Четверг";
            Controls.Add(thu);
            // 
            // fri
            // 
            Label fri = new Label();
            fri.AutoSize = true;
            fri.Font = new Font("Microsoft Sans Serif", 12F);
            fri.Location = new Point(337, 245 + 160);
            fri.Name = "fri";
            fri.Size = new Size(178, 20);
            fri.Text = "Пятница";
            Controls.Add(fri);
            // 
            // sat
            // 
            Label sat = new Label();
            sat.AutoSize = true;
            sat.Font = new Font("Microsoft Sans Serif", 12F);
            sat.Location = new Point(337, 479 + 160);
            sat.Name = "sat";
            sat.Size = new Size(175, 20);
            sat.Text = "Суббота";
            Controls.Add(sat);
            #endregion

            InitializeComponent();



        }

        private void main_Load(object sender, EventArgs e)
        {
            monpan.Controls.Clear();
            tuepan.Controls.Clear();
            wenpan.Controls.Clear();
            thupan.Controls.Clear();
            fripan.Controls.Clear();
            satpan.Controls.Clear();

            #region Заполнение комбобоксов
            List<string> teacher_list = sql.Select("SELECT name, ID FROM teachers WHERE ID != 0");

            for (int i = 0; i < teacher_list.Count; i+=2)
                teachercbx.Items.Add(teacher_list[i] + ',' + teacher_list[i+1]);


            grav = sql.Select("SELECT DISTINCT groupID FROM dotw");
            string cmdtext = "SELECT facID FROM groups WHERE ";
            for (int i = 0; i < grav.Count; i++)
            {
                if (i == 0) cmdtext += "ID ='" + grav[i] + "' ";
                else        cmdtext += " OR ID ='" + grav[i] + "' ";
            }

            List<string> facid = sql.Select(cmdtext);
            List<string> fac_list = new List<string>();

            for (int i = 0; i < facid.Count; i++)
            {
                List<string> a = new List<string>();
                if (facid.Count > 0)
                {
                    a = sql.Select("SELECT name, ID FROM faculties WHERE ID='" + facid[i] + "'");
                    fac_list.Add(a[0]);
                    fac_list.Add(a[1]);
                }

            }

            for (int i = 0; i < fac_list.Count; i += 2)
                if (fac_list.Contains(fac_list[i+1]))
                   faccbx.Items.Add(fac_list[i] + ',' + fac_list[i + 1]);
            #endregion

            if ((grcbx.Text != "" && faccbx.Text != "" && who == "fac") || (teachercbx.Text != "" && who == "prep"))
            {
                string daytext = "";
                string[] parts = grcbx.Text.Split(new char[] { ',' });
                string[] tparts = teachercbx.Text.Split(new char[] { ',' });


                for (int dotw = 0; dotw < 6; dotw++)
                {
                    if (dotw == 0) daytext = "mon";
                    if (dotw == 1) daytext = "tue";
                    if (dotw == 2) daytext = "wen";
                    if (dotw == 3) daytext = "thu";
                    if (dotw == 4) daytext = "fri";
                    if (dotw == 5) daytext = "sat";

                    foreach (TableLayoutPanel pan in downpan.Controls)
                    {
                        string eh = pan.Name;
                        if (pan.Name == daytext + "pan")
                        {
                            int row = 0;

                            for (int less = 0; less < 5; less++)
                            {
                                List<string> list = new List<string>();

                                if (who == "fac")
                                    list = sql.Select(
                                        " SELECT subjects.name, teachers.name, classrooms.name" +
                                        " FROM dotw " +
                                            " JOIN lessons    ON lessons.ID    = dotw.s" + (less + 1) + "ID " +
                                            " JOIN groups     ON groups.ID     = dotw.groupID " +
                                            " JOIN teachers   ON teachers.ID   = lessons.teacherID " +
                                            " JOIN subjects   ON subjects.ID   = lessons.subjID " +
                                            " JOIN classrooms ON classrooms.ID = lessons.classroomID " +
                                            " WHERE dotw.groupID = '" + parts[1] + "' AND dotw.name = '" + daytext + "' ");

                                if (who == "prep")
                                    list = sql.Select(
                                        " SELECT subjects.name, groups.name, classrooms.name" +
                                        " FROM dotw " +
                                            " JOIN lessons    ON lessons.ID    = dotw.s" + (less + 1) + "ID " +
                                            " JOIN groups     ON groups.ID     = dotw.groupID " +
                                            " JOIN teachers   ON teachers.ID   = lessons.teacherID " +
                                            " JOIN subjects   ON subjects.ID   = lessons.subjID " +
                                            " JOIN classrooms ON classrooms.ID = lessons.classroomID " +
                                            " WHERE teachers.ID = '" + tparts[1] + "' AND dotw.name = '" + daytext + "' ");

                                //MessageBox.Show("чето нашел");

                                if (list.Count > 0)
                                {
                                    Label lbl = new Label();
                                    lbl.Anchor = AnchorStyles.None;
                                    lbl.Location = new Point(13, 6);
                                    lbl.Size = new Size(100, 26);
                                    lbl.Text = list[0];
                                    pan.Controls.Add(lbl, 0, row);

                                    Label tlbl = new Label();
                                    tlbl.Anchor = AnchorStyles.None;
                                    tlbl.Location = new Point(137, 6);
                                    tlbl.Size = new Size(97, 26);
                                    tlbl.Text = list[1];
                                    pan.Controls.Add(tlbl, 1, row);

                                    Label clbl = new Label();
                                    clbl.Anchor = AnchorStyles.None;
                                    clbl.Font = new Font("Microsoft Sans Serif", 8F);
                                    clbl.Location = new Point(253, 152);
                                    clbl.Size = new Size(25, 13);
                                    clbl.Text = list[2];
                                    pan.Controls.Add(clbl, 2, row);
                                }
                                row++;
                            }

                            break;
                        }
                    }
                }
            }

            else if (who != "")
                MessageBox.Show("Выберите всё, что требуется", "Ошибка");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FiltrBut_Click(object sender, EventArgs e)
        {
            if (FiltrPanel.Size.Height == 49)
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, 160);
            else
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, 49);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login li = new login();
            li.ShowDialog();
        }


        private void search_Click(object sender, EventArgs e)
        {      
            who = "fac";
            main_Load(sender, e);
         }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin sus = new AdminLogin();
            sus.ShowDialog();
        }

        private void teachercbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 sus = new Form1();
            sus.ShowDialog();
        }

        private void presearch_Click(object sender, EventArgs e)
        {      
            who = "prep";
            main_Load(sender, e);
        }

        private void faccbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            grcbx.Items.Clear();
            grcbx.Enabled = true;
            string[] parts = faccbx.Text.Split(new char[] { ',' });

            //List<string> lflfla = sql.Select("SELECT DISTINCT groupID FROM dotw");
            List<string> gr_list = sql.Select("SELECT name, ID FROM groups WHERE facID ='" + parts[1] + "' AND ID != '0'");

            for (int i = 0; i < gr_list.Count; i += 2)
                if (grav.Contains(gr_list[i + 1]))
                    grcbx.Items.Add(gr_list[i] + ',' + gr_list[i + 1]);

          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            main_Load(sender, e);
        }
    }
}
