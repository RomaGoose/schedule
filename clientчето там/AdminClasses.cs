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
    public partial class AdminClasses : Form
    {
        public AdminClasses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namebx.Text != "")
            {
                sql.Select("INSERT INTO classrooms (name) VALUES('" + namebx.Text + "')");
                MessageBox.Show("Сохранено");
            }
            else MessageBox.Show("Заполните поле");
            AdminClasses_Load(sender, e);
            namebx.Text = "";
        }
        private void DeleteClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            object tag = btn.Tag;
            foreach (Control control in deletepan.Controls)
            {
                if (control.Location.X == 50 && control.Tag == tag)
                {
                    sql.Select("DELETE FROM classrooms WHERE name = '" + control.Text + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminClasses_Load(sender, e);
                    return;
                }
            }
        }

        private void AdminClasses_Load(object sender, EventArgs e)
        {
            List<string> list = sql.Select("SELECT name, ID FROM classrooms WHERE ID != '0'");
            deletepan.Controls.Clear();

            int y = 10;
            for (int i = 0; i < list.Count; i+=2)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(100, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i];
                lbl.Tag = list[i + 1];
                deletepan.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(170, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteClick);
                btn.Tag = list[i + 1];
                btn.Text = "Удалить";
                deletepan.Controls.Add(btn);

                y += 30;
            }
        }

        private void AdminClasses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
