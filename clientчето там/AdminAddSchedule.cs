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
    public partial class AdminAddSchedule : Form
    {
        public AdminAddSchedule()
        {
            InitializeComponent();

            List<string> faculties = main.MySelect("SELECT name, ID FROM faculties");
            List<string> groups = main.MySelect("SELECT name, ID FROM groups");
            for (int i = 0; i < faculties.Count; i += 2) faccbx.Items.Add(faculties[i] + "," + faculties[i + 1]);
            for (int i = 0; i < groups.Count; i += 2) grcbx.Items.Add(groups[i] + "," + groups[i + 1]);


            List<string> subject_list = main.MySelect("SELECT name, ID FROM subjects");
            List<string> teachers_list = main.MySelect("SELECT name, ID, subjID, subj2ID FROM teachers");
            List<string> classrooms_list = main.MySelect("SELECT name, ID FROM classrooms");

            string daytext = "";
            int x = 0;
            int y = 0;


            for (int dotw = 0; dotw < 6; dotw++)
            {
                if (dotw == 0) daytext = "mon";
                if (dotw == 1) daytext = "tue";
                if (dotw == 2) daytext = "wen";
                if (dotw == 3) daytext = "thu";
                if (dotw == 4) daytext = "fri";
                if (dotw == 5) daytext = "sat";

                for (int less = 1; less < 6; less++)
                {
                    ComboBox teachcbx = new ComboBox();
                    teachcbx.DropDownStyle = ComboBoxStyle.DropDownList;
                    teachcbx.Enabled = true;
                    teachcbx.FormattingEnabled = true;
                    teachcbx.Location = new Point(x, y);
                    teachcbx.Name = daytext + less + "teacher";
                    teachcbx.Size = new Size(131, 21);
                    teachcbx.SelectedIndexChanged += new EventHandler(TeacherSelected);
                    pan.Controls.Add(teachcbx);
                    for (int i = 0; i < teachers_list.Count; i += 4) teachcbx.Items.Add(teachers_list[i] + "," + teachers_list[i + 1]);

                    ComboBox subcbx = new ComboBox();
                    subcbx.DropDownStyle = ComboBoxStyle.DropDownList;
                    subcbx.Enabled = false;
                    subcbx.FormattingEnabled = true;
                    subcbx.Location = new Point(x, y + 27);
                    subcbx.Name = daytext + less + "sub";
                    subcbx.Size = new Size(131, 21);
                    pan.Controls.Add(subcbx);

                    ComboBox classcbx = new ComboBox();
                    classcbx.DropDownStyle = ComboBoxStyle.DropDownList;
                    classcbx.Enabled = true;
                    classcbx.FormattingEnabled = true;
                    classcbx.Location = new Point(x, y + 54);
                    classcbx.Name = daytext + less + "class";
                    classcbx.Size = new Size(131, 21);
                    pan.Controls.Add(classcbx);
                    for (int i = 0; i < classrooms_list.Count; i += 2) classcbx.Items.Add(classrooms_list[i] + "," + classrooms_list[i + 1]);

                    y += 94;
                }

                y = 0;
                x += 170;
            }
            /*
            for (int dotw = 0; dotw < 6; dotw++)
            {
                if (dotw == 0) daytext = "mon";
                if (dotw == 1) daytext = "tue";
                if (dotw == 2) daytext = "wen";
                if (dotw == 3) daytext = "thu";
                if (dotw == 4) daytext = "fri";
                if (dotw == 5) daytext = "sat";

                for (int less = 1; less < 6; less++)
                {
                    tcbxname = daytext + less + "teacher";
                    scbxname = daytext + less + "sub";


                    foreach (Control teacher in pan.Controls)
                    {
                        hui = "внутри фор";
                        if (teacher.Name == tcbxname && pomenyalos == true)
                            hui = "da";
                        else
                            hui = "net";

                        if (teacher.Name == tcbxname && pomenyalos)
                        {
                            foreach (ComboBox sub in pan.Controls)
                            {
                                if (sub.Name == scbxname)
                                {
                                    sub.Enabled = true;

                                    string[] parts = teacher.Text.Split(new char[] { ',' });

                                    List<string> prepod = main.MySelect("SELECT name, ID, subjID, subj2ID FROM teachers WHERE ID = '" + parts[1] + "'");
                                    List<string> sub1 = main.MySelect("SELECT name, ID FROM subjects WHERE ID ='" + prepod[2] + "'");
                                    List<string> sub2 = main.MySelect("SELECT name, ID FROM subjects WHERE ID ='" + prepod[3] + "'");
                                    sub.Items.Add(sub1[0] + "," + sub1[1]);
                                    sub.Items.Add(sub2[0] + "," + sub2[1]);
                                }
                            }
                        }
                    }

                }
            }
            */
          
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void TeacherSelected(object sender, EventArgs e)
        {
            ComboBox teacher = (ComboBox)sender;

            string subname = "";
            for (int i = 0; i < 4; i++)
            {
                subname += teacher.Name[i]; 
            }
            subname += "sub";

            foreach (ComboBox sub in pan.Controls)
            {
                if (sub.Name == subname)
                {
                    sub.Enabled = true;

                    string[] parts = teacher.Text.Split(new char[] { ',' });

                    List<string> teacher_data = main.MySelect("SELECT name, ID, subjID, subj2ID FROM teachers WHERE ID = '" + parts[1] + "'");
                    List<string> sub1 = main.MySelect("SELECT name, ID FROM subjects WHERE ID ='" + teacher_data[2] + "'");
                    List<string> sub2 = main.MySelect("SELECT name, ID FROM subjects WHERE ID ='" + teacher_data[3] + "'");
                    sub.Items.Add(sub1[0] + "," + sub1[1]);
                    sub.Items.Add(sub2[0] + "," + sub2[1]);
                }
            }

                      
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AdminAddSchedule_Load(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void grcbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
