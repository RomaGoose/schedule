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
        public static string username;
        public static string userid = "no";
        public static string usertype;
        List<string> user_info = new List<string>();
        private string who = "";
        List<string> grav = new List<string>();
        public main()
        {   
     
            InitializeComponent();


            #region создание элементов таблиц

            foreach (Control con in downpan.Controls)
            {
                if (con is TableLayoutPanel && con.Name.Contains("pan"))
                {
                    TableLayoutPanel pan = (TableLayoutPanel)con;

                    #region отрисовка шапок

                    Label nlbl = new Label();
                    nlbl.Anchor = AnchorStyles.None;
                    nlbl.AutoSize = true;
                    nlbl.Location = new Point(8, 10);
                    nlbl.Size = new Size(18, 13);
                    nlbl.TabIndex = 0;
                    nlbl.Text = "№";
                    pan.Controls.Add(nlbl);

                    Label ssbsblbl = new Label();
                    ssbsblbl.Anchor = AnchorStyles.None;
                    ssbsblbl.AutoSize = true;
                    ssbsblbl.Location = new Point(66, 10);
                    ssbsblbl.Size = new Size(52, 13);
                    ssbsblbl.TabIndex = 36;
                    ssbsblbl.Text = "Предмет";
                    pan.Controls.Add(ssbsblbl);

                    Label tctctlbl = new Label();
                    tctctlbl.Anchor = AnchorStyles.None;
                    tctctlbl.AutoSize = true;
                    tctctlbl.Location = new Point(156, 3);
                    tctctlbl.Size = new Size(109, 27);
                    tctctlbl.TabIndex = 2;
                    if (who == "prep")
                        tctctlbl.Text = "Группа";
                    else
                        tctctlbl.Text = "Преподаватель";
                    tctctlbl.TextAlign = ContentAlignment.MiddleCenter;
                    pan.Controls.Add(tctctlbl);

                    Label aulbl = new Label();
                    aulbl.BackColor = Color.Bisque;
                    aulbl.Font = new Font("Microsoft Sans Serif", 7F);
                    aulbl.TextAlign = ContentAlignment.MiddleCenter;
                    aulbl.Anchor = AnchorStyles.None;
                    aulbl.AutoSize = true;
                    aulbl.Location = new Point(8, 3);
                    aulbl.Size = new Size(38, 35);
                    aulbl.TabIndex = 3;
                    aulbl.Margin = new Padding(0);
                    aulbl.Text = "№ аудитории";
                    pan.Controls.Add(aulbl);

                    #endregion

                    #region отризовка строчек
                    for (int row = 1; row < 6; row++)
                    {
                        Label mnlbl = new Label();
                        mnlbl.Anchor = AnchorStyles.None;
                        mnlbl.Location = new Point(15, 8);
                        mnlbl.Size = new Size(100, 26);
                        mnlbl.Font = new Font("Microsoft Sans Serif", 15F);
                        mnlbl.Text = row.ToString();
                        pan.Controls.Add(mnlbl, 0, row);
                  
                        Label lbl = new Label();
                        lbl.Anchor = AnchorStyles.None;
                        lbl.Location = new Point(13, 6);
                        lbl.Size = new Size(100, 26);
                        lbl.Name = pan.Name.Substring(0, 3) + row.ToString() + "lbl";
                        pan.Controls.Add(lbl, 1, row);

                        Label tlbl = new Label();
                        tlbl.Anchor = AnchorStyles.None;
                        tlbl.Location = new Point(137, 6);
                        tlbl.Size = new Size(97, 26);
                        tlbl.Name = pan.Name.Substring(0, 3) + row.ToString() + "tlbl";
                        pan.Controls.Add(tlbl, 2, row);

                        Label clbl = new Label();
                        clbl.Anchor = AnchorStyles.None;
                        clbl.Font = new Font("Microsoft Sans Serif", 8F);
                        clbl.Location = new Point(253, 152);
                        clbl.Size = new Size(25, 13);
                        clbl.Name = pan.Name.Substring(0, 3) + row.ToString() + "clbl";
                        pan.Controls.Add(clbl, 3, row);
                    }
                    #endregion

                }
            }

            #endregion


        }

        public void main_Load(object sender, EventArgs e)
        {
            for (int col = 1; col < 4; col ++)  
                for(int row = 1; row < 6; row++)
                {
                    Control m = monpan.GetControlFromPosition(col, row);
                    Control t = tuepan.GetControlFromPosition(col, row);
                    Control w = wenpan.GetControlFromPosition(col, row);
                    Control h = thupan.GetControlFromPosition(col, row);
                    Control f = fripan.GetControlFromPosition(col, row);
                    Control s = satpan.GetControlFromPosition(col, row);
                    if (m != null) m.Text = "";
                    if (t != null) t.Text = "";
                    if (w != null) w.Text = "";
                    if (h != null) h.Text = "";
                    if (f != null) f.Text = "";
                    if (s != null) s.Text = "";
                }
            


            if (userid != "no")
            {
                user_info = sql.Select("SELECT name, role FROM " + usertype + " WHERE ID = '" + userid + "'");
                welcome.Text = user_info[0];
            

                if (user_info[1] == "admin" || user_info[1] == "changer")
                { 
                    button1.Visible = true;
                    if (user_info[1] == "admin")
                         button1.Text = "Панель администратора";
                    else button1.Text = "Внести изменения";
                }
            }
            string[] parts = grcbx.Text.Split(new char[] { ',' });
            string[] tparts = teachercbx.Text.Split(new char[] { ',' });

            #region Заполнение комбобоксов
           
            if (who == "")
            {
                grcbx.Items.Clear();
                faccbx.Items.Clear();
                teachercbx.Items.Clear();
         
            List<string> teacher_list = sql.Select("SELECT name, ID FROM teachers WHERE ID != 0");

            for (int i = 0; i < teacher_list.Count; i += 2)
                teachercbx.Items.Add(teacher_list[i] + ',' + teacher_list[i + 1]);


            grav = sql.Select("SELECT DISTINCT groupID FROM dotw");
            string cmdtext = "SELECT DISTINCT facID FROM groups WHERE ";
            for (int i = 0; i < grav.Count; i++)
            {
                if (i == 0) cmdtext += "ID ='" + grav[i] + "' ";
                else cmdtext += " OR ID ='" + grav[i] + "' ";
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
                if (fac_list.Contains(fac_list[i + 1]))
                    faccbx.Items.Add(fac_list[i] + ',' + fac_list[i + 1]);
            }
            #endregion

            #region заполнение расписания 
            if ((grcbx.Text != "" && faccbx.Text != "" && who == "fac") || (teachercbx.Text != "" && who == "prep"))
            {
                foreach (Control con in downpan.Controls)
                {
                    if (con is TableLayoutPanel)
                    {
                        TableLayoutPanel pan = (TableLayoutPanel)con;
                       
                        string daytext = pan.Name.Substring(0, 3);
                        TableLayoutControlCollection hos = pan.Controls;

                        for (int less = 1; less < 6; less++)
                        {
                            List<string> list = new List<string>();

                            if (who == "fac")
                                list = sql.Select(
                                    " SELECT subjects.name, teachers.name, classrooms.name" +
                                    " FROM dotw " +
                                        " JOIN lessons    ON lessons.ID    = dotw.s" + less + "ID " +
                                        " JOIN groups     ON groups.ID     = dotw.groupID " +
                                        " JOIN teachers   ON teachers.ID   = lessons.teacherID " +
                                        " JOIN subjects   ON subjects.ID   = lessons.subjID " +
                                        " JOIN classrooms ON classrooms.ID = lessons.classroomID " +
                                        " WHERE dotw.groupID = '" + parts[1] + "' AND dotw.name = '" + daytext + "' ");

                            if (who == "prep")
                                list = sql.Select(
                                    " SELECT subjects.name, groups.name, classrooms.name" +
                                    " FROM dotw " +
                                        " JOIN lessons    ON lessons.ID    = dotw.s" + less + "ID " +
                                        " JOIN groups     ON groups.ID     = dotw.groupID " +
                                        " JOIN teachers   ON teachers.ID   = lessons.teacherID " +
                                        " JOIN subjects   ON subjects.ID   = lessons.subjID " +
                                        " JOIN classrooms ON classrooms.ID = lessons.classroomID " +
                                        " WHERE teachers.ID = '" + tparts[1] + "' AND dotw.name = '" + daytext + "' ");

                            if (list.Count > 0)
                            {
                                pan.Controls.Find(daytext+less.ToString()+"lbl", false)[0].Text = list[0];
                                pan.Controls.Find(daytext+less.ToString()+"tlbl", false)[0].Text = list[1];
                                pan.Controls.Find(daytext+less.ToString()+"clbl", false)[0].Text = list[2];
                            }
                        }

                       
                    }
                    
                }
                
            }


            else if (who != "")
                MessageBox.Show("Выберите всё, что требуется", "Ошибка");
            #endregion

        }

        public static void looooaddd(object sender, EventArgs e)
        {
            main mi = new main();
            mi.main_Load(sender, e);
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
            if (button2.Text == "Войти")
            {
                //AdminTeacher adm = new AdminTeacher();
                //adm.ShowDialog();


                login li = new login();
                li.ShowDialog();
                if (userid != "no")
                {  
                    welcome.Text = username;
                    button2.Text = "Выйти";
                    button4.Visible = true;

                    user_info = sql.Select("SELECT name, role FROM " + usertype + " WHERE ID = '" + userid + "'");
                    welcome.Text = user_info[0];


                    if (user_info[1] == "admin" || user_info[1] == "changer")
                    {
                        button1.Visible = true;
                        if (user_info[1] == "admin")
                            button1.Text = "Панель администратора";
                        else button1.Text = "Внести изменения";
                    }
                }
            }

            else if (button2.Text == "Выйти")
            {
                welcome.Text = "Вы не авторизовались";
                button2.Text = "Войти";
                button1.Visible = false;
                button4.Visible = false;
                userid = "no";
                user_info.Clear();
            }
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
            Admin sus = new Admin(user_info[0]);
            AdminAddSchedule add = new AdminAddSchedule();
            if (button1.Text == "Панель администратора")
                sus.ShowDialog();
            else 
                add.ShowDialog();
     
        }

        private void teachercbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
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
            new Send().ShowDialog();

            who = "";
            main_Load(sender, e);
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void fripan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tuepan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.ShowDialog();
        }
    }
}
