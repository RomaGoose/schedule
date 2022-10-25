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
    public partial class AdminSubject : Form
    {
        public AdminSubject()
        {
            InitializeComponent();
        }


        private void AdminSubject_Load(object sender, EventArgs e)
        {
            List<string> list = main.MySelect("SELECT name FROM subjects");
            deletepan.Controls.Clear();

            int y = 30;
            for (int i = 0; i < list.Count; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(250, 20);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i];
                deletepan.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(350, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteHotelClick);
                btn.Text = "Удалить";
                deletepan.Controls.Add(btn);

                y += 30;
            }
        }


        private void DeleteHotelClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in deletepan.Controls)
            {
                if (control.Location == new Point(50, y))
                {
                    main.MyUpdate("DELETE FROM subjects WHERE name = '" + control.Text + "'");
                    MessageBox.Show("Низвёл до атомов");
                    AdminSubject_Load(sender, e);
                    return;
                }
            }
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            main.MyUpdate("INSERT INTO subjects (name)" +
                          "VALUES('" + namebx.Text +  "')");
            MessageBox.Show("Сохранено");
            AdminSubject_Load(sender, e);

            namebx.Text = " ";
            return;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
