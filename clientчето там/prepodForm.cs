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
        { /*
            #region lable 
            // 
            // mon
            // 
            Label mon = new Label();
            mon.AutoSize = true;
            mon.Font = new Font("Microsoft Sans Serif", 12F);
            mon.Location = new Point(24, 70);
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
            tue.Location = new Point(24, 266);
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
            wed.Location = new Point(24, 468);
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
            thu.Location = new Point(343, 70);
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
            fri.Location = new Point(343, 266);
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
            sat.Location = new Point(343, 468);
            sat.Name = "sat";
            sat.Size = new Size(175, 20);
            sat.Text = "Суббота";
            Controls.Add(sat);
            #endregion*/


            #region lable 
            // 
            // mon
            // 
            Label mon = new Label();
            mon.AutoSize = true;
            mon.Font = new Font("Microsoft Sans Serif", 12F);
            mon.Location = new Point(20, 73);
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
            tue.Location = new Point(20, 245 + 60);
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
            wed.Location = new Point(20, 479 + 60);
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
            thu.Location = new Point(339, 13 + 60);
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
            fri.Location = new Point(337, 245 + 60);
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
            sat.Location = new Point(337, 479 + 60);
            sat.Name = "sat";
            sat.Size = new Size(175, 20);
            sat.Text = "Суббота";
            Controls.Add(sat);
            #endregion


            InitializeComponent();
            List<string> list = sql.Select("SELECT name FROM teachers WHERE ID = '" + ID + "'");
           
            id = ID;
            name = list[0];
            label1.Text = list[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void prepodForm_Load(object sender, EventArgs e)
        {
            string daytext = "";

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
                    if (pan.Name == daytext + "pan")
                    {
                        int row = 0;
                        for (int less = 0; less < 5; less++)
                        {
                            List<string> list = new List<string>();

                            list = sql.Select(
                                " SELECT subjects.name, groups.name, classrooms.name" +
                                " FROM dotw " +
                                    " JOIN lessons    ON lessons.ID    = dotw.s" + (less + 1) + "ID " +
                                    " JOIN groups     ON groups.ID     = dotw.groupID " +
                                    " JOIN teachers   ON teachers.ID   = lessons.teacherID " +
                                    " JOIN subjects   ON subjects.ID   = lessons.subjID " +
                                    " JOIN classrooms ON classrooms.ID = lessons.classroomID " +
                                    " WHERE teachers.ID = '" + id + "' AND dotw.name = '" + daytext + "' ");

                            if (list.Count > 0)
                            {
                                Label lbl = new Label();
                                lbl.Anchor = AnchorStyles.None;
                                lbl.Location = new Point(13, 6);
                                lbl.Size = new Size(100, 26);
                                lbl.Text = list[0];
                                pan.Controls.Add(lbl, 0, less);

                                Label tlbl = new Label();
                                tlbl.Anchor = AnchorStyles.None;
                                tlbl.Location = new Point(137, 6);
                                tlbl.Size = new Size(97, 26);
                                tlbl.Text = list[1];
                                pan.Controls.Add(tlbl, 1, less);

                                Label clbl = new Label();
                                clbl.Anchor = AnchorStyles.None;
                                clbl.Font = new Font("Microsoft Sans Serif", 8F);
                                clbl.Location = new Point(253, 152);
                                clbl.Size = new Size(25, 13);
                                clbl.Text = list[2];
                                pan.Controls.Add(clbl, 2, less);
                            }
                            row++;
                        }

                        break;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            





           

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
