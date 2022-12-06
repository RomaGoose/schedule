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
            sql.Update("INSERT INTO classrooms (name)" +
                         "VALUES('" + namebx.Text + "')");
            MessageBox.Show("Сохранено");
            AdminClasses_Load(sender, e);

            namebx.Text = "";
            return;
        }
        private void DeleteClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in deletepan.Controls)
            {
                if (control.Location == new Point(50, y))
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
            List<string> list = sql.Select("SELECT name FROM classrooms");
            deletepan.Controls.Clear();

            int y = 30;
            for (int i = 0; i < list.Count; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(100, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i];
                deletepan.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(170, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteClick);
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
