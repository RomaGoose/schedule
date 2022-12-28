using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clientчето_там
{
    public partial class AdminFacultiesGrs : Form
    {
        public AdminFacultiesGrs()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminFacultiesGrs_Load(object sender, EventArgs e)
        {
            List<string> faclist = sql.Select("SELECT name, ID FROM faculties");
            List<string> grlist = sql.Select("SELECT name, facID, ID FROM groups WHERE ID != '0'");

            grpan.Controls.Clear();
            facpan.Controls.Clear();
            comboBox1.Items.Clear();
            for (int i = 0; i < faclist.Count; i += 2)
                comboBox1.Items.Add(faclist[i] + "," + faclist[i + 1]);
            
            
            facpan.Controls.Clear();

            int fy = 10;
            for (int i = 0; i < faclist.Count; i += 2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(30, fy);
                lbl.Size = new Size(250, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Visible = true;
                lbl.Name = "lbl" + i + "fac";
                lbl.Text = faclist[i];
                lbl.Tag = faclist[i+1];
                facpan.Controls.Add(lbl);

                System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
                tb.Location = new Point(30, fy);
                tb.Size = new Size(250, 20);
                tb.Font = new Font("Microsoft Sans Serif", 12);
                tb.Name = "tb" + i;
                tb.Visible = false;
                tb.Text = faclist[i];
                tb.Tag = faclist[i + 1];
                facpan.Controls.Add(tb);

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                pb.Load("../../pictures/change.png");
                pb.Click += new EventHandler(UpdateFacClick);
                pb.Location = new Point(310, fy);
                pb.Size = new Size(30, 30);
                pb.Tag = faclist[i + 1];
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                toolTip1.SetToolTip(pb, "Изменить");
                facpan.Controls.Add(pb);

                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Location = new Point(350, fy);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteFacClick);
                btn.Tag = faclist[i + 1];
                btn.Text = "Удалить";
                facpan.Controls.Add(btn);

                fy += 30;
            }

            int gy = 10;
            for (int i = 0; i < grlist.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(10, gy);
                lbl.Size = new Size(160, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Visible = true;
                lbl.Name = "lbl" + i + "gr";
                lbl.Text = grlist[i];
                lbl.Tag = grlist[i + 2];
                grpan.Controls.Add(lbl);

                System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
                tb.Location = new Point(10, gy);
                tb.Size = new Size(160, 20);
                tb.Font = new Font("Microsoft Sans Serif", 12);
                tb.Name = "tb" + i + "g";
                tb.Visible = false;
                tb.Text = grlist[i];
                tb.Tag = grlist[i + 2];
                grpan.Controls.Add(tb);

                Label lbl2 = new Label();
                lbl2.Location = new Point(170, gy);
                lbl2.Size = new Size(160, 20);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Visible = true;
                lbl2.Tag = grlist[i + 2];
                lbl2.Name = "lbl2" + i + "gr";
                for (int fac = 0; fac < faclist.Count; fac += 2)
                {
                    if (grlist[i + 1] == faclist[fac + 1])
                        lbl2.Text = faclist[fac];
                }
                grpan.Controls.Add(lbl2);

                System.Windows.Forms.ComboBox cbx = new System.Windows.Forms.ComboBox();
                cbx.Visible = false;
                cbx.Name = "cbx" + i;
                cbx.Location = new Point(170, gy);
                cbx.Size = new Size(160, 20);
                cbx.Font = new Font("Microsoft Sans Serif", 12);
                cbx.Tag = grlist[i + 2];
                cbx.DropDownStyle = ComboBoxStyle.DropDownList;
                for (int j =0; j < faclist.Count; j+=2)
                    cbx.Items.Add(faclist[j] + ',' + faclist[j+1]);

                for (int fac = 0; fac < faclist.Count; fac += 2)
                    if (faclist[fac + 1] == grlist[i + 1])
                        cbx.SelectedIndex = fac / 2;
                grpan.Controls.Add(cbx);

                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                pb.Load("../../pictures/change.png");
                pb.Click += new EventHandler(UpdateGrClick);
                pb.Location = new Point(340, gy);
                pb.Tag = grlist[i + 2];
                pb.Size = new Size(30, 30);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                toolTip1.SetToolTip(pb, "Изменить");
                grpan.Controls.Add(pb);

                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Location = new Point(380, gy);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Tag = grlist[i + 2];
                btn.Click += new EventHandler(DeleteGrClick);
                btn.Text = "Удалить";
                grpan.Controls.Add(btn);

                gy += 30;
            }
        }
        private void DeleteFacClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            int y = btn.Location.Y;
            object tag = btn.Tag;
            foreach (Control control in facpan.Controls)
            {
                if (control.Location.X == 30 && control.Tag == tag)
                {
                    sql.Select("DELETE FROM faculties WHERE ID = '" + control.Tag + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminFacultiesGrs_Load(sender, e);
                    return;
                }
            }
        }
        private void DeleteGrClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            int y = btn.Location.Y;
            object tag = btn.Tag;
          
            foreach (Control control in grpan.Controls)
            {
                if (control.Location.X == 30 && control.Tag == tag)
                {
                    sql.Select("DELETE FROM groups WHERE name = '" + control.Text + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminFacultiesGrs_Load(sender, e);
                    return;
                }
            }
        }
        private void AddFacClick(object sender, EventArgs e)
        {
            if (facnametb.Text == "")
                MessageBox.Show("Заполните поле", "Обшибка");
            else
            {
                sql.Select("INSERT INTO faculties (name) VALUES('" + facnametb.Text + "')");
                MessageBox.Show("Сохранено", "Успешно");
            }
           

            facnametb.Text = "";

            AdminFacultiesGrs_Load(sender, e);
        }
        private void AddGrClick(object sender, EventArgs e)
        {
            string[] parts = comboBox1.Text.Split(new char[] { ',' });

            if (groupnametb.Text == "" || comboBox1.Text == "")
                MessageBox.Show("Заполните поля", "Обшибка");

             if (!(groupnametb.Text == "") && !(comboBox1.Text == ""))
             {
                sql.Select("INSERT INTO groups (name, facID) VALUES('" + groupnametb.Text + "','" + parts[1] +"')");
                MessageBox.Show("Сохранено", "Успешно");
             }

            groupnametb.Text = "";

            AdminFacultiesGrs_Load(sender, e);

        }
        private void UpdateFacClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            object tag = btn.Tag;
            foreach (Control control in facpan.Controls)
            {
                if (control.Location.X == 30 && control.Tag == tag)
                {
                    control.Location = new Point(30, y);
                    if (control.Name.StartsWith("tb"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
            }
            btn.Load("../../pictures/save.png");
            btn.Click += new EventHandler(SaveFacClick);
            toolTip1.SetToolTip(btn, "Сохранить");
        }
        private void UpdateGrClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            object tag = btn.Tag;
            foreach (Control control in grpan.Controls)
            {
                if (control.Location.X == 10 && control.Tag == tag)
                {
                    control.Location = new Point(10, y);
                    if (control.Name.StartsWith("tb"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
                if (control.Location.X == 170 && control.Tag == tag)
                {
                    control.Location = new Point(170, y);
                    if (control.Name.StartsWith("cbx"))
                        control.Visible = true;
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = false;
                }
            }
            btn.Load("../../pictures/save.png");
            btn.Click += new EventHandler(SaveGrClick);
            toolTip1.SetToolTip(btn, "Сохранить");
        }
        private void SaveFacClick(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            foreach (Control control in facpan.Controls)
            {
                if (control.Location == new Point(30, y))
                {
                    if (control.Name.StartsWith("tb"))
                    {
                        control.Visible = false;
                        sql.Update("UPDATE faculties SET name='" + control.Text + "' WHERE ID ='" + control.Tag + "'");
                        MessageBox.Show("Сохранено");

                    }
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = true;
                }
            }
            btn.Load("../../pictures/change.png");
            btn.Click += new EventHandler(UpdateFacClick);
            AdminFacultiesGrs_Load(sender, e);

        }
        private void SaveGrClick(object sender, EventArgs e)
        {

            PictureBox btn = (PictureBox)sender;
            int y = btn.Location.Y;
            foreach (Control control in facpan.Controls)
            {
                if (control.Location == new Point(10, y))
                {
                    if (control.Name.StartsWith("tb"))
                    {
                        control.Visible = false;
                        sql.Update("UPDATE groups SET name='" + control.Text + "' WHERE ID ='" + control.Tag + "'");
                    }
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = true;
                }
                if (control.Location == new Point(170, y))
                {
                    if (control.Name.StartsWith("cbx"))
                    {
                        control.Visible = false;
                        sql.Update("UPDATE groups SET facID ='" + control.Text.Last() + "' WHERE ID ='" + control.Tag + "'");
                        MessageBox.Show("Сохранено", "Успешно");
                    }
                    if (control.Name.StartsWith("lbl"))
                        control.Visible = true;
                }
            }
            btn.Load("../../pictures/change.png");
            btn.Click += new EventHandler(UpdateGrClick);
            AdminFacultiesGrs_Load(sender, e);

        }

        private void grpan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
