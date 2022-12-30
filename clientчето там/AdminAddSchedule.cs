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
        public List<string> subject_list = sql.Select("SELECT name, ID FROM subjects");
        public int flag = 0;

        public AdminAddSchedule()
        {
            InitializeComponent();

            List<string> faculties = sql.Select("SELECT name, ID FROM faculties");
            List<string> groups = sql.Select("SELECT name, facID, ID FROM groups");
           
            for (int i = 0; i < groups.Count; i += 3)
               for (int j = 0; j < faculties.Count; j += 2)
                    if (groups[i + 1] == faculties[j + 1])
                        grcbx.Items.Add(groups[i] + "," + faculties[j] + "," + groups[i + 2]);
        }
        private void AdminAddSchedule_Load(object sender, EventArgs e)
        {
            pan.Controls.Clear();

            List<string> teachers_list   = sql.Select("SELECT name, ID, subjID, subj2ID FROM teachers");
            List<string> classrooms_list = sql.Select("SELECT name, ID FROM classrooms");

          
            string daytext = "";
            int x = 0;
            int y = 0;
            
            if (grcbx.Text != "")
            for (int dotw = 0; dotw < 6; dotw++)
            {
                string[] gparts = grcbx.Text.Split(new char[] {','});

                if (dotw == 0) daytext = "mon";
                if (dotw == 1) daytext = "tue";
                if (dotw == 2) daytext = "wen";
                if (dotw == 3) daytext = "thu";
                if (dotw == 4) daytext = "fri";
                if (dotw == 5) daytext = "sat";

                for (int less = 1; less < 6; less++)
                {  
                    ComboBox subcbx = new ComboBox();
                    subcbx.DropDownStyle = ComboBoxStyle.DropDownList;
                    subcbx.Enabled = false;
                    subcbx.FormattingEnabled = true;
                    subcbx.Location = new Point(x, y + 27);
                    subcbx.Name = daytext + less + "sub";
                    subcbx.Size = new Size(131, 21);
                    pan.Controls.Add(subcbx);
                 
                        

                    ComboBox teachcbx = new ComboBox();
                    teachcbx.DropDownStyle = ComboBoxStyle.DropDownList;
                    teachcbx.Enabled = true;
                    teachcbx.FormattingEnabled = true;
                    teachcbx.Location = new Point(x, y);
                    teachcbx.Name = daytext + less + "teacher";
                    teachcbx.Size = new Size(131, 21);
                    teachcbx.SelectedIndexChanged += new EventHandler(TeacherSelected);
                    pan.Controls.Add(teachcbx);

                    List<string> noteacher = sql.Select(
                        " SELECT lessons.teacherID from dotw " +
                            " JOIN lessons ON lessons.ID = dotw.s" + less + "ID" +
                            " WHERE dotw.name = '" + daytext + "' AND lessons.teacherID != '0' AND lessons.groupID != '" + gparts[2] + "'");
                    
                    List<string> steacher = sql.Select(
                        " SELECT lessons.teacherID from dotw " +
                            " JOIN lessons ON lessons.ID = dotw.s" + less + "ID" +
                            " WHERE dotw.name = '" + daytext + "' AND lessons.teacherID != '0' AND lessons.groupID = '" + gparts[2] + "'");
                    
                    List<string> avaialableteacher = new List<string>();
                    
                    for (int i = 0; i < teachers_list.Count; i += 4)
                    {
                        if (!noteacher.Contains(teachers_list[i + 1]))
                        {
                            teachcbx.Items.Add(teachers_list[i] + "," + teachers_list[i + 1]);
                             avaialableteacher.Add(teachers_list[i + 1]);
                        }
                        
                       
                    }

                    for (int i =0; i < avaialableteacher.Count; i++)
                        if (steacher.Count > 0 && avaialableteacher[i] == steacher[0])
                        {
                            teachcbx.SelectedIndex = i;
                            TeacherSelected(teachcbx, new EventArgs());
                        }

                    ComboBox classcbx = new ComboBox();
                    classcbx.DropDownStyle = ComboBoxStyle.DropDownList;
                    classcbx.Enabled = true;
                    classcbx.FormattingEnabled = true;
                    classcbx.Location = new Point(x, y + 54);
                    classcbx.Name = daytext + less + "class";
                    classcbx.Size = new Size(131, 21);
                    pan.Controls.Add(classcbx);
                    
                    List<string> noclass = sql.Select(
                        " SELECT classrooms.ID from dotw " +
                            " JOIN lessons ON lessons.ID = dotw.s" + less + "ID" +
                            " JOIN classrooms ON classrooms.ID = lessons.classroomID" +
                            " WHERE dotw.name = '" + daytext + "' AND classrooms.ID != '0' AND lessons.groupID != '" + gparts[2] + "'");

                    List<string> sclass = sql.Select(
                        " SELECT lessons.classroomID from dotw " +
                            " JOIN lessons ON lessons.ID = dotw.s" + less + "ID" +
                            " WHERE dotw.name = '" + daytext + "' AND lessons.classroomID != '0' AND lessons.groupID = '" + gparts[2] + "'");
                    
                        List<string> avaialableclass = new List<string>();

                        for (int i = 0; i < classrooms_list.Count; i += 2)
                        {
                            if (!noclass.Contains(classrooms_list[i + 1]))
                            {
                                classcbx.Items.Add(classrooms_list[i] + "," + classrooms_list[i + 1]);
                                avaialableclass.Add(classrooms_list[i+1]);
                            }

                     
                        }
                        
                        for (int i = 0; i < avaialableclass.Count; i++)
                            if (sclass.Count > 0 && avaialableclass[i] == sclass[0])
                            {
                                classcbx.SelectedIndex = i;
                                TeacherSelected(teachcbx, new EventArgs());
                            }


                        y += 94;
                }

                y = 0;
                x += 170;
            }
         
        }
       
        private void TeacherSelected(object sender, EventArgs e)
        {
            ComboBox teacher = (ComboBox)sender;
            string[] gparts = grcbx.Text.Split(new char[] { ',' });


            List<string> ssubj = sql.Select(
                   " SELECT lessons.subjID from dotw " +
                       " JOIN lessons ON lessons.ID = dotw.s" + teacher.Name[3] + "ID" +
                       " WHERE dotw.name = '" + teacher.Name.Substring(0, 3) + "' AND lessons.teacherID != '0' AND lessons.groupID = '" + gparts[2] + "'");

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
                    sub.Items.Clear();
                    string[] parts = teacher.Text.Split(new char[] { ',' });

                    List<string> teacher_data = sql.Select("SELECT name, ID, subjID, subj2ID FROM teachers WHERE ID = '" + parts[1] + "'");
                    List<string> sub1 = sql.Select("SELECT name, ID FROM subjects WHERE ID ='" + teacher_data[2] + "'");
                    List<string> sub2 = sql.Select("SELECT name, ID FROM subjects WHERE ID ='" + teacher_data[3] + "'");
                    sub.Items.Add(sub1[0] + "," + sub1[1]);
                    sub.Items.Add(sub2[0] + "," + sub2[1]);

                    if (ssubj.Count > 0)
                    {
                        if (sub1[1] == ssubj[0])
                             sub.SelectedIndex = 0;
                        else sub.SelectedIndex = 1;
                    }
                }
            }

                      
        }

      
        private void AddClick(object sender, EventArgs e)
        {
            string daytext = "";
            string[] gparts = grcbx.Text.Split(new char[] { ',' });
            
            if (gparts.Count() > 1)
            {
                int dayflag = 0;
                for (int dotw = 0; dotw < 6; dotw++)
                {
                    if (dotw == 0) daytext = "mon";
                    if (dotw == 1) daytext = "tue";
                    if (dotw == 2) daytext = "wen";
                    if (dotw == 3) daytext = "thu";
                    if (dotw == 4) daytext = "fri";
                    if (dotw == 5) daytext = "sat";

                    int dayId;

                    List<string> dday = sql.Select("SELECT ID FROM dotw WHERE name = '" + daytext + "' AND groupID = '" + gparts[2] + "'");

                    if (dday.Count > 0)
                    {
                        dayId = Convert.ToInt32(dday[0]);
                    }
                    else
                    {
                        sql.Update("INSERT INTO dotw (name, groupID) VALUES('" + daytext + "', '" + gparts[2] + "')");
                        List<string> list = sql.Select("SELECT ID FROM dotw");
                        dayId = Convert.ToInt32(list.Last());
                    }

                    List<string> lessid = new List<string>();

                    int listflag = 0;
                       
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
                                    message += daytext + less + "teacher, не заполнено \n";
                                    flag++; listflag++;
                                }
                                else tparts = control.Text.Split(new char[] { ',' });
                            }

                            if (control.Name == (daytext + less + "sub"))
                            {
                                if (control.Text == "") 
                                { 
                                    message += daytext + less + "sub, не заполнено \n";
                                    flag++; listflag++;
                                }
                                else sparts = control.Text.Split(new char[] { ',' });
                            }


                            if (control.Name == (daytext + less + "class"))
                            {
                                if (control.Text == "")
                                {
                                    message += daytext + less + "class, не заполнено \n";
                                    flag++; listflag++;
                                }
                                else cparts = control.Text.Split(new char[] { ',' });
                            }

                    

                        }


                        if (flag != 0 && flag != 3)
                        {
                            MessageBox.Show(message, "Ошибка");
                            if (dday.Count < 1)
                                sql.Update("DELETE FROM dotw WHERE ID = '" + dayId + "'");
                            goto leave;
                        }

                        if (flag == 0 && (tparts[1] == "0" && cparts[1] != "0" || tparts[1] != "0" && cparts[1] == "0"))
                        {
                            MessageBox.Show("Либо все три поля пустые, либо все три поля заполнены действительными вариантами (" + daytext + ", "+ less + " урок)", "Ошибка");
                            if (dday.Count < 1)
                                sql.Update("DELETE FROM dotw WHERE ID = '" + dayId + "'");
                            goto leave;
                        }

                        if (flag == 3 || (tparts[1] == "0" && sparts[1] == "0" && cparts[1] == "0"))
                        {
                            List<string> id = sql.Select("SELECT s" + less + "ID FROM dotw WHERE ID ='" + dayId + "'");

                            if (id[0] != "0")
                                sql.Update("DELETE FROM lessons WHERE ID ='" + id[0] + "'");
                                
                            lessid.Add("0");
                           
                        }

                        if (flag == 0 && !(tparts[1] == "0" && sparts[1] == "0" && cparts[1] == "0"))
                        {
                            List<string> id = sql.Select("SELECT s" + less + "ID FROM dotw WHERE ID ='" + dayId + "'");

                            if (dday.Count < 1 || id[0] == "0")
                            {
                                sql.Update("INSERT INTO lessons (teacherID, subjID, groupID, classroomID, dayID)" +
                                              "VALUES('" + tparts[1] + "', '" + sparts[1] + "', '" + gparts[2] + "', '" + cparts[1] + "', '" + dayId + "')");
                                List<string> lesslist = sql.Select("SELECT ID FROM lessons WHERE ID != '0'");
                                lessid.Add(lesslist.Last());
                            }
                            else
                            {
                                sql.Update("UPDATE lessons SET teacherID ='" + tparts[1] + "', classroomID = '" + cparts[1] + "', subjID ='" + sparts[1] + "' WHERE ID ='" + id[0] + "'");
                                lessid.Add(id[0]);
                            }
                         
                        }
                        //for less
                    }
                    //for dotw
                    if (listflag == 15)
                    {
                      //  MessageBox.Show("Заполните" + daytext, "Ошибка");
                       // sql.Update("INSERT INTO dotw (name, groupID) VALUES('" + daytext + "', '" + gparts[2] +"')");
                        dayflag++;
                        //goto leave;
                    }
                    if (lessid.Count>0 && listflag != 15)
                    {
                        sql.Update("UPDATE dotw SET s1ID ='" + lessid[0] + "' , s2ID ='" + lessid[1] + "' , s3ID ='" + lessid[2] + "' , s4ID ='" + lessid[3] + "' , s5ID ='" + lessid[4] + "' WHERE ID = '" + dayId + "'");
                        MessageBox.Show("Сохранено " + daytext, "Успешно");
                    }
                          
                }

                if (dayflag == 6)
                    MessageBox.Show("Заполните хотя бы один день", "Ошибка");
                dayflag = 0;

                leave:
                   ; 
            
           }
            else
                MessageBox.Show("Выберите группу", "Ошибка");
        }
       

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void grcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminAddSchedule_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                button2.BackColor = System.Drawing.Color.GreenYellow;
                flag++;
            }
            else
            {
                button2.BackColor = System.Drawing.SystemColors.Control;
                flag = 0;
            }
        }
    }
}
