﻿using System;
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


    public partial class main : Form
    {
       
        /// <summary>
        /// Функция Select-запроса
        /// </summary>
      
        public main()
        {
            InitializeComponent();
            //List<string> list = sql.Select("SELECT name, subject1, subject2, subject3, subject4, subject5, " +
            //                                          "Teacher1, Teacher2, Teacher3, Teacher4, Teacher5, " +
            //                                          "Classroom1, Classroom2, Classroom3, Classroom4, Classroom5 FROM fullday");

            List<string> teacher_list = sql.Select("SELECT name FROM teachers");

            for (int i = 0; i < teacher_list.Count; i++)
                teachercbx.Items.Add(teacher_list[i]);
            
            List<string> fac_list = sql.Select("SELECT name, ID FROM faculties");

            for (int i = 0; i < fac_list.Count; i += 2)
                faccbx.Items.Add(fac_list[i] + ',' + fac_list[i+1]);

         }

        private void main_Load(object sender, EventArgs e)
        {/*
            if (grcbx.Text != "" && faccbx.Text != "")
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

                    string[] parts = grcbx.Text.Split(new char[] { ',' });
                    List<string> daylist = sql.Select("SELECT s1ID, s2ID, s3ID, s4ID, s5ID FROM dotw WHERE name ='" + daytext + "', groupID ='" + parts[1] + "'");

                    foreach (TableLayoutPanel pan in downpan.Controls)
                    {
                        if (pan.Name == daytext + "pan")
                        {
                            int col = 0;
                            int row = 0;

                            //List<string> sublist = sql.Select("SELECT teachers.name, subjects.name, classrooms.name ");

                            Label lbl = new Label();
                            lbl.Anchor = AnchorStyles.None;
                            lbl.Location = new Point(13, 6);
                            lbl.Name = "label79";
                            lbl.Size = new Size(100, 26);
                            lbl.Text = "защита от темных искусств предм";
                            pan.Controls.Add(lbl, col, row);

                            Label tlbl = new Label();
                            tlbl.Anchor = AnchorStyles.None;
                            tlbl.Font = new Font("Microsoft Sans Serif", 8F);
                            tlbl.Location = new Point(253, 152);
                            tlbl.Name = "label78";
                            tlbl.Size = new Size(25, 13);
                            tlbl.Text = "102";
                            pan.Controls.Add(tlbl, col + 1, row);

                            Label clbl = new Label();
                            clbl.Anchor = AnchorStyles.None;
                            clbl.Location = new Point(137, 6);
                            clbl.Name = "label69";
                            clbl.Size = new Size(97, 26);
                            clbl.Text = "учитель типа мегадлинное имя";
                            pan.Controls.Add(clbl, col + 2, row);
                        }
                    }
                }

            }*/
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
        }

        private void faccbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            grcbx.Items.Clear();
            grcbx.Enabled = true;
            string[] parts = faccbx.Text.Split(new char[] { ',' });

            List<string> gr_list = sql.Select("SELECT name, ID FROM groups WHERE facID ='" + parts[1] + "'");

            for (int i = 0; i < gr_list.Count; i += 2)
                grcbx.Items.Add(gr_list[i] + ',' + gr_list[i + 1]);

        }
    }
}
