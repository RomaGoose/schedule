using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientчето_там
{
    public partial class prepodForm : Form
    {
        List<string> unmess;
        List<string> mess;
        //                                      [0]    [1]   [2]     [3]  [4]
        public prepodForm()
        {
            InitializeComponent();
            // ПОЗЖЕ = БОЛЬШЕЕЕ
          
         
        }

        private void prepodForm_Load(object sender, EventArgs e)
        {
            double width = this.Width - 16;
            panel1.Controls.Clear(); 
            
            main.userid = "12"; //dsfjs;lodkfjas;djkhfa;lskdjfa;lksdjf;lksjdf;lakjsd;lfkajsd;lkfja;lsdkjf;
            main.usertype = "teachers"; 

            unmess = sql.Select("SELECT theme, text, students.name, groups.name, time, messages.ID FROM `messages` " +
                                    " JOIN students ON messages.studID = students.ID" +
                                    " JOIN groups ON groups.ID = students.groupID" +
                                    " WHERE `teachID` = " + main.userid + " AND `read` = 0 ORDER BY time ASC");
            mess = sql.Select("SELECT theme, text, students.name, groups.name, time, messages.ID FROM `messages` " +
                                      " JOIN students ON messages.studID = students.ID" +
                                      " JOIN groups ON groups.ID = students.groupID" +
                                      " WHERE `teachID` = " + main.userid + " AND `read` = 1 ORDER BY time ASC");


            for (int i = 0; i < mess.Count; i += 6)
            {
                Panel pan = new Panel();
                //pan.BackColor = SystemColors.Window;
                pan.BorderStyle = BorderStyle.FixedSingle;
                pan.Dock = DockStyle.Top;
                pan.Location = new Point(0, 0);
                pan.Name = "panel" + i.ToString();
                pan.Click += new EventHandler(PanelClick);
                pan.Height = 52;
                pan.Tag = mess[i + 5];
                pan.TabIndex = 27;
                panel1.Controls.Add(pan);

                Label flbl = new Label();
                flbl.AutoSize = true;
                flbl.Text = "От: " + mess[i + 2] + " из " + mess[i + 3];
                flbl.Font = new Font("Microsoft Sans Serif", 12.75F);
                flbl.Location = new Point((int)(0.016 * width), 14);
                pan.Controls.Add(flbl);

                Label tlbl2 = new Label();
                tlbl2.AutoSize = true;
                tlbl2.Text = "Тема: " + mess[i];
                tlbl2.Font = new Font("Microsoft Sans Serif", 12.75F);
                tlbl2.Location = new Point((int)(0.37 * width), 14);
                pan.Controls.Add(tlbl2);

                Label mlbl3 = new Label();
                mlbl3.AutoSize = true;
                mlbl3.Text = mess[i + 4];
                mlbl3.Font = new Font("Microsoft Sans Serif", 12.75F);
                mlbl3.Location = new Point((int)(0.67 * width), 14);
                pan.Controls.Add(mlbl3);

                Button btn = new Button();
                btn.Location = new Point((int)(0.89 * width), 9);
                btn.Click += new EventHandler(DeleteClick);
                btn.Size = new Size(100, 30);
                btn.BackColor = SystemColors.ControlLight;
                btn.Font = new Font("Microsoft Sans Serif", 12.75F);
                btn.Text = "Удалить";
                pan.Controls.Add(btn);
            }

            for (int i = 0; i < unmess.Count; i += 6)
            {
                Panel pan = new Panel();
              //  pan.BackColor = SystemColors.Window;
                pan.BorderStyle = BorderStyle.FixedSingle;
                pan.Dock = DockStyle.Top;
                pan.Location = new Point(0, 0);
                pan.Click += new EventHandler(PanelClick);
                pan.Name = i.ToString();
                pan.Height = 52;
                pan.Tag = unmess[i + 5];
                pan.TabIndex = 27;
                panel1.Controls.Add(pan);

                Label flbl = new Label();
                flbl.AutoSize = true;
                flbl.Text = "От: " + unmess[i + 2] + " из " + unmess[i + 3];
                flbl.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold);
                flbl.Location = new Point(16, 14);
                pan.Controls.Add(flbl);

                Label tlbl2 = new Label();
                tlbl2.AutoSize = true;
                tlbl2.Text = "Тема: " + unmess[i];
                tlbl2.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold);
                tlbl2.Location = new Point(370, 14);
                pan.Controls.Add(tlbl2);

                Label mlbl3 = new Label();
                mlbl3.AutoSize = true;
                mlbl3.Text = unmess[i + 4];
                mlbl3.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold);
                mlbl3.Location = new Point(670, 14);
                mlbl3.Name = "time" + i.ToString();
                pan.Controls.Add(mlbl3);

                Button btn = new Button();
                btn.Location = new Point(890, 9);
                btn.BackColor = SystemColors.ControlLight;
                btn.Click += new EventHandler(DeleteClick);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12.75F);
                btn.Text = "Удалить";
                pan.Controls.Add(btn);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prepodForm_Load(sender, e);
        }
        private void DeleteClick(object sender, EventArgs e)
        {
            prepodForm_Load(sender, e);
        }
        private void PanelClick(object sender, EventArgs e)
        {
            Panel pan = (Panel)sender;
            Send.messid = pan.Tag as string;
            new Send().ShowDialog();

            foreach (Control con in pan.Controls)
                if (con.Name == "time" + pan.Name)
                {
                    string time = DateTime.ParseExact(con.Text, "G", new CultureInfo("ru")).ToString("yyyy.MM.dd HH:mm:ss");

                    sql.Update("UPDATE `messages` SET `read`=1, time='" + time + "' WHERE ID = " + Send.messid);

                }
            //sql.Update("UPDATE messages SET read = '1' WHERE ID = '" + Send.messid + "'");
            prepodForm_Load(sender, e);
        }

        private void prepodForm_SizeChanged(object sender, EventArgs e)
        {
            prepodForm_Load(sender, e);

        }

    }
}
