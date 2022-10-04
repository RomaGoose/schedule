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

namespace clientчето_там
{
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

        // public Label lbl;
        //public TableLayoutPanel pan;


        public DotW(string _Name, string _Subject1, string _Subject2, string _Subject3, string _Subject4,
                                  string _Teacher1, string _Teacher2, string _Teacher3, string _Teacher4,
                                  string _Classroom1, string _Classroom2, string _Classroom3, string _Classroom4)//, TableLayoutPanel _pan)



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

            //pan = _pan;
        }
    }

    public partial class main : Form
    {
        const string connection_string = "SslMode=none;Server=localhost;Database=schedule;Uid=root;";
        
        public static List<DotW> dotWs = new List<DotW>();

        public main()
        {
            InitializeComponent();


            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT name, subject1, subject2, subject3, subject4, Teacher1, Teacher2, Teacher3, Teacher4, Classroom1, Classroom2, Classroom3, Classroom4 FROM fullday", conn);
            DbDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string name = reader.GetValue(0).ToString();
                string subject1 = reader.GetValue(1).ToString();
                string subject2 = reader.GetValue(2).ToString();
                string subject3 = reader.GetValue(3).ToString();
                string subject4 = reader.GetValue(4).ToString();
                string teacher1 = reader.GetValue(5).ToString();
                string teacher2 = reader.GetValue(6).ToString();
                string teacher3 = reader.GetValue(7).ToString();
                string teacher4 = reader.GetValue(8).ToString();
                string classroom1 = reader.GetValue(9).ToString();
                string classroom2 = reader.GetValue(10).ToString();
                string classroom3 = reader.GetValue(11).ToString();
                string classroom4 = reader.GetValue(12).ToString();


                DotW day = new DotW(name, subject1, subject2, subject3, subject4,
                                          teacher1, teacher2, teacher3, teacher4,
                                          classroom1, classroom2, classroom3, classroom4);
                dotWs.Add(day);
            }
            reader.Close();

            conn.Close();



            foreach (DotW day in dotWs)
            {

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
    }
}
