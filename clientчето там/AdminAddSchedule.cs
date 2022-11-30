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
            List<string> groups = main.MySelect("SELECT name, facID, ID FROM groups");
           
            for (int i = 0; i < groups.Count; i += 3)
               for (int j = 0; j < faculties.Count; j += 2)
                    if (groups[i + 1] == faculties[j + 1])
                        grcbx.Items.Add(groups[i] + "," + faculties[j] + "," + groups[i + 2]);

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

      

        private void AddClick(object sender, EventArgs e)
        {
            string daytext = "";
            char[] aaaa = { 's', 'u', 'b', 't', 'e', 'a', 'c', 'h', 'e', 'r', 'c', 'l', 'a', 's', 's' };
            string[] gparts = grcbx.Text.Split(new char[] { ',' });
            
            // hz = control.Name.TrimEnd(aaaa);
            if (gparts.Count() > 1)
            {             

                for (int dotw = 0; dotw < 1; dotw++)
                {
                    if (dotw == 0) daytext = "mon";
                    if (dotw == 1) daytext = "tue";
                    if (dotw == 2) daytext = "wen";
                    if (dotw == 3) daytext = "thu";
                    if (dotw == 4) daytext = "fri";
                    if (dotw == 5) daytext = "sat";

                    for (int less = 1; less < 6; less++)
                    {
                        string[] tparts = { };
                        string[] sparts = { };
                        string[] cparts = { };
          
                        int flag = 0;
                        string message = "";

                        foreach (Control control in pan.Controls)
                        {
                            if (control.Name == (daytext + less + "teacher"))
                            {
                                if (control.Text == "") 
                                {
                                    flag += 1;
                                    message += daytext + less + "teacher, не заполнено \n";
                                }
                                else tparts = control.Text.Split(new char[] { ',' });
                            }

                            if (control.Name == (daytext + less + "sub"))
                            {
                                if (control.Text == "") 
                                { 
                                    message += daytext + less + "sub, не заполнено \n"; 
                                    flag += 1;
                                }
                                else sparts = control.Text.Split(new char[] { ',' });
                            }


                            if (control.Name == (daytext + less + "class"))
                            {
                                if (control.Text == "")
                                {
                                    message += daytext + less + "class, не заполнено \n";
                                    flag += 1;
                                }
                                else cparts = control.Text.Split(new char[] { ',' });
                            }

                    

                        }

                        if (flag != 0 && flag != 3)
                        {
                            MessageBox.Show(message, "Ошибка");
                            goto leave;

                        }

                        if(flag == 0)
                        main.MyUpdate("INSERT INTO lessons (teacherID, subjID, groupID, classroomID)" +
                                      "VALUES('" + tparts[1] + "', '" + sparts[1] + "', '" + gparts[2] + "', '" + cparts[1] + "')");
                  
                    }
                  
                           
                }
            
            leave:
                ; 
            
            }
            else
                MessageBox.Show("Выберите группу", "Ошибка");
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
