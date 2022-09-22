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

namespace clientчето_там
{
    public struct DotW
    {
        public string Name;
        
        public string Subject1;
        public int Classroom1;
        public string Teacher1;
        
        public string Subject2;
        public int Classroom2;
        public string Teacher2;
        
        public string Subject3;
        public int Classroom3;
        public string Teacher3;

        public string Subject4;
        public int Classroom4;
        public string Teacher4;

        public Label lbl;
        public TableLayoutPanel pan;


        public DotW(string _Name, string _Subject1, string _Subject2, string _Subject3, string _Subject4, 
                                  string _Teacher1, string _Teacher2, string _Teacher3, string _Teacher4,
                                   int _Classroom1,  int _Classroom2,  int _Classroom3,  int _Classroom4)



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
        }
    }

    public partial class main : Form
    {
        public static List<DotW> dotWs = new List<DotW>();

        public main()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines("../../pictures/bd.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                DotW day = new DotW (parts[0], parts[1], parts[2], parts[3], parts[4],
                                               parts[5], parts[6], parts[7], parts[8],
                                               Convert.ToInt32(parts[9]), Convert.ToInt32(parts[10]), Convert.ToInt32(parts[11]), Convert.ToInt32(parts[12]));
                dotWs.Add(day);
            }


            foreach (DotW day in dotWs)
            {
                int x = 0;
                int y = 0;
                int f = 0;
               /* for (int i = 0; i < 15; i++)
                {
                    day.lbl.Anchor = AnchorStyles.None;
                    day.lbl.Location = new Point(60 + x, 58 + y);
                    day.lbl.Name = day.Name + i;
                    day.lbl.Size = new Size(51, 16);
                    day.lbl.TabIndex = 1;
                    day.lbl.Text = day.;
                    

                    y += 43;

                    if (y == 43 * 4 && f == 0)
                    {
                        y = 0;
                        x = 171;
                        f = 1;
                    }

                    if (y == 43 * 4 && f == 1)
                    {
                        y = 0;
                        x = 114;
                        f = 0;
                    }
                }*/
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
