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

namespace clientчето_там
{
    #region подсказки типа
    /* авто инкрементирование A_I, чтобы айди сам увеличивался
     * в уадление тоже айди дбавить и удалить запрос длеать по айдишнику тоже
     * айди как тэг добавить в лейбл который за имя отвечает и соответственоо по нему удалить
     * добавить айди предметам, сделать айдисабджект в таблице преподов
     * по рофлу сдлеать преподам айди тоже хотя есть и почта, сделать авто инкремент. см начало
     */
    #endregion

    public struct DotW
    {
        public string Name;
        
        public string Subject1;
        public string Classroom1;
        public string Teacher1;
        
        public string Subject2;
        public string Classroom2;
        public string Teacher2;
        
        public string Subject3;
        public string Classroom3;
        public string Teacher3;

        public string Subject4;
        public string Classroom4;
        public string Teacher4;

        public string Subject5;
        public string Classroom5;
        public string Teacher5;



        public DotW(string _Name, string _Subject1, string _Subject2, string _Subject3, string _Subject4, string _Subject5,
                                  string _Teacher1, string _Teacher2, string _Teacher3, string _Teacher4, string _Teacher5,
                                  string _Classroom1, string _Classroom2, string _Classroom3, string _Classroom4, string _Classroom5)//, TableLayoutPanel _pan)



        {
            Name = _Name;

            Subject1 = _Subject1;
            Classroom1 = _Classroom1;
            Teacher1 = _Teacher1;
            
            Subject2 = _Subject2;
            Classroom2 = _Classroom2;
            Teacher2 = _Teacher2;
            
            Subject3 = _Subject3;
            Classroom3 = _Classroom3;
            Teacher3 = _Teacher3;

            Subject4 = _Subject4;
            Classroom4 = _Classroom4;
            Teacher4 = _Teacher4;

            Subject5 = _Subject5;
            Classroom5 = _Classroom5;
            Teacher5 = _Teacher5;

            //pan = _pan;
        }
    }

    public partial class main : Form
    {
       
        public static List<DotW> dotWs = new List<DotW>();
        /// <summary>
        /// Функция Select-запроса
        /// </summary>
      


        public static List<string> MySelect(string cmdtext)
        {
            List<string> list = new List<string>();

            MySqlCommand cmd = new MySqlCommand(cmdtext, Program.CONN);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {   
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }

            }
            reader.Close();

            return list;
        }
        /*
        private void Search_Click(object sender, EventArgs e)
        {
            HotelsPanel.Controls.Clear();
            string command = "SELECT Name, City, Rating, Image, ID FROM hotels WHERE 1";
            if (CityComboBox.Text != "")
                command += " AND City = '" + CityComboBox.Text + "'";
            if (RatingComboBox.Text != "")
                command += " AND Rating >= '" + RatingComboBox.Text + "'";
            List<string> otels = MySelect(command);
        }*/
            public static void MyUpdate(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, Program.CONN);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }



        public main()
        {
            InitializeComponent();
            //List<string> list = MySelect("SELECT name, subject1, subject2, subject3, subject4, subject5, " +
            //                                          "Teacher1, Teacher2, Teacher3, Teacher4, Teacher5, " +
            //                                          "Classroom1, Classroom2, Classroom3, Classroom4, Classroom5 FROM fullday");

            List<string> teacher_list = MySelect("SELECT name FROM teachers");

            for (int i = 0; i < teacher_list.Count; i++)
                teachercbx.Items.Add(teacher_list[i]);
            
            List<string> fac_list = MySelect("SELECT name, ID FROM faculties");

            for (int i = 0; i < fac_list.Count; i += 2)
                faccbx.Items.Add(fac_list[i] + ',' + fac_list[i+1]);

            List<string> gr_list = MySelect("SELECT name, ID FROM groups");

            for (int i = 0; i < gr_list.Count; i += 2)
                grcbx.Items.Add(gr_list[i] + ',' + gr_list[i + 1]);


            //"SELECT name, subject1, subject2, subject3, subject4, subject5, Teacher1, Teacher2, Teacher3, Teacher4, Teacher5, Classroom1, Classroom2, Classroom3, Classroom4, Classroom5 FROM fullday"

            /* for (int i =0; i < list.Count; i+=16)
             {

                 DotW day = new DotW(list[i], list[i+1], list[i+2], list[i+3], list[i+4], list[i+5],
                                              list[i+6], list[i+7], list[i+8], list[i+9], list[i+10],
                                              list[i+11], list[i+12], list[i+13], list[i+14], list[i+15]);
                 dotWs.Add(day);

             }


             int x;
             for (int i = 1; i < 16; i++)
             {
                 if (i < 6) x = 0;
                 else if (i > 5 && i < 11) x = 1;
                 else x = 2;

                 Label label = new Label();
                 label.Anchor = AnchorStyles.None;
                 label.Size = new Size(126, 32);
                 label.Location = new Point(3, 0);
                 label.Text = list[i];
                 label.TextAlign = ContentAlignment.MiddleCenter;
                 monpan.Controls.Add(label, x, i - x * 5 - 1);
             }*/





            foreach (DotW day in dotWs)
            {
                

                /*
                #region str1
                Label label1 = new Label();
                label1.Anchor = AnchorStyles.None;
                label1.Name = day.Name + "subj1";
                label1.Size = new Size(126, 32);
                label1.TabIndex = 0;
                label1.Text = day.Subject1;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(label1);

                Label prep1 = new Label();
                prep1.Anchor = AnchorStyles.None;
                prep1.Name = day.Name + "prep1";
                prep1.Size = new Size(126, 32);
                prep1.TabIndex = 1;
                prep1.Text = day.Teacher1;
                prep1.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(prep1);

                Label cls1 = new Label();
                cls1.Font = new Font("Microsoft Sans Serif", 4F);
                cls1.Anchor = AnchorStyles.None;
                cls1.Name = day.Name + "cls1";
                cls1.Size = new Size(40, 17);
                cls1.TabIndex = 2;
                cls1.Text = Convert.ToString(day.Classroom1);
                cls1.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(cls1);
                #endregion

                #region str2
                Label label2 = new Label();
                label2.Anchor = AnchorStyles.None;
                label2.Name = day.Name + "subj2";
                label2.Size = new Size(126, 32);
                label2.TabIndex = 3;
                label2.Text = day.Subject2;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(label2);

                Label prep2 = new Label();
                prep2.Anchor = AnchorStyles.None;
                prep2.Name = day.Name + "prep2";
                prep2.Size = new Size(126, 32);
                prep2.TabIndex = 4;
                prep2.Text = day.Teacher2;
                prep2.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(prep2);

                Label cls2 = new Label();
                cls1.Font = new Font("Microsoft Sans Serif", 5F);
                cls2.Anchor = AnchorStyles.None;
                cls2.Name = day.Name + "cls2";
                cls2.Size = new Size(40, 17);
                cls2.TabIndex = 5;
                cls2.Text = Convert.ToString(day.Classroom2);
                cls2.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(cls2);
                #endregion

                #region str3
                Label label3 = new Label();
                label3.Anchor = AnchorStyles.None;
                label3.Name = day.Name + "subj3";
                label3.Size = new Size(126, 32);
                label3.TabIndex = 6;
                label3.Text = day.Subject3;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(label3);

                Label prep3 = new Label();
                prep3.Anchor = AnchorStyles.None;
                prep3.Name = day.Name + "prep3";
                prep3.Size = new Size(126, 32);
                prep3.TabIndex = 7;
                prep3.Text = day.Teacher3;
                prep3.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(prep3);

                Label cls3 = new Label();
                cls1.Font = new Font("Microsoft Sans Serif", 6F);
                cls3.Anchor = AnchorStyles.None;
                cls3.Name = day.Name + "cls3";
                cls3.Size = new Size(40, 17);
                cls3.TabIndex = 8;
                cls3.Text = Convert.ToString(day.Classroom3);
                cls3.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(cls3);
                #endregion

                #region str4
                Label label4 = new Label();
                label4.Anchor = AnchorStyles.None;
                label4.Name = day.Name + "subj4";
                label4.Size = new Size(126, 32);
                label4.TabIndex = 9;
                label4.Text = day.Subject4;
                label4.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(label4);

                Label prep4 = new Label();
                prep4.Anchor = AnchorStyles.None;
                prep4.Name = day.Name + "prep4";
                prep4.Size = new Size(126, 32);
                prep4.TabIndex = 10;
                prep4.Text = day.Teacher4;
                prep4.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(prep4);

                Label cls4 = new Label();
                cls1.Font = new Font("Microsoft Sans Serif", 7F);
                cls4.Anchor = AnchorStyles.None;
                cls4.Name = day.Name + "cls4";
                cls4.Size = new Size(40, 17);
                cls4.TabIndex = 11;
                cls4.Text = Convert.ToString(day.Classroom4);
                cls4.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(cls4);
                #endregion

                #region str5
                Label label5 = new Label();
                label5.Anchor = AnchorStyles.None;
                label5.Name = day.Name + "subj5";
                label5.Size = new Size(126, 32);
                label5.TabIndex = 9;
                label5.Text = day.Subject5;
                label5.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(label5);

                Label prep5 = new Label();
                prep5.Anchor = AnchorStyles.None;
                prep5.Name = day.Name + "prep5";
                prep5.Size = new Size(126, 32);
                prep5.TabIndex = 10;
                prep5.Text = day.Teacher5;
                prep5.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(prep5);

                Label cls5 = new Label();
                cls1.Font = new Font("Microsoft Sans Serif", 7F);
                cls5.Anchor = AnchorStyles.None;
                cls5.Name = day.Name + "cls5";
                cls5.Size = new Size(50, 17);
                cls5.TabIndex = 11;
                cls5.Text = Convert.ToString(day.Classroom5);
                cls5.TextAlign = ContentAlignment.MiddleCenter;
                monpan.Controls.Add(cls5);
                #endregion
               */
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FiltrBut_Click(object sender, EventArgs e)
        {
            if (FiltrPanel.Size.Height == 49)
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, 138);
            else
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, 49);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login li = new login();
            li.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

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
            Admin sus = new Admin();
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
    }
}
