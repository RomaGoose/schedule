namespace clientчето_там
{
    partial class AdminTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addpan = new System.Windows.Forms.Panel();
            this.loginbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.subj2cbx = new System.Windows.Forms.ComboBox();
            this.subj1cbx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.namebx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addpan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addpan
            // 
            this.addpan.AutoScroll = true;
            this.addpan.Controls.Add(this.loginbx);
            this.addpan.Controls.Add(this.label8);
            this.addpan.Controls.Add(this.subj2cbx);
            this.addpan.Controls.Add(this.subj1cbx);
            this.addpan.Controls.Add(this.button1);
            this.addpan.Controls.Add(this.label6);
            this.addpan.Controls.Add(this.label2);
            this.addpan.Controls.Add(this.label5);
            this.addpan.Controls.Add(this.namebx);
            this.addpan.Controls.Add(this.label4);
            this.addpan.Controls.Add(this.passbx);
            this.addpan.Controls.Add(this.label3);
            this.addpan.Controls.Add(this.mailbx);
            this.addpan.Controls.Add(this.label7);
            this.addpan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addpan.Location = new System.Drawing.Point(0, 301);
            this.addpan.Margin = new System.Windows.Forms.Padding(2);
            this.addpan.Name = "addpan";
            this.addpan.Size = new System.Drawing.Size(784, 260);
            this.addpan.TabIndex = 1;
            this.addpan.Paint += new System.Windows.Forms.PaintEventHandler(this.addpan_Paint);
            // 
            // loginbx
            // 
            this.loginbx.Location = new System.Drawing.Point(174, 46);
            this.loginbx.Margin = new System.Windows.Forms.Padding(2);
            this.loginbx.Name = "loginbx";
            this.loginbx.Size = new System.Drawing.Size(140, 20);
            this.loginbx.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Введите логин...";
            // 
            // subj2cbx
            // 
            this.subj2cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subj2cbx.FormattingEnabled = true;
            this.subj2cbx.Location = new System.Drawing.Point(175, 180);
            this.subj2cbx.Margin = new System.Windows.Forms.Padding(2);
            this.subj2cbx.Name = "subj2cbx";
            this.subj2cbx.Size = new System.Drawing.Size(139, 21);
            this.subj2cbx.TabIndex = 27;
            // 
            // subj1cbx
            // 
            this.subj1cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subj1cbx.FormattingEnabled = true;
            this.subj1cbx.Location = new System.Drawing.Point(174, 149);
            this.subj1cbx.Margin = new System.Windows.Forms.Padding(2);
            this.subj1cbx.Name = "subj1cbx";
            this.subj1cbx.Size = new System.Drawing.Size(140, 21);
            this.subj1cbx.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(331, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Добавить";
            this.toolTip1.SetToolTip(this.button1, "Изменить");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Выберите второй предмет...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добавить учителя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Введите почту...";
            // 
            // namebx
            // 
            this.namebx.Location = new System.Drawing.Point(174, 78);
            this.namebx.Margin = new System.Windows.Forms.Padding(2);
            this.namebx.Name = "namebx";
            this.namebx.Size = new System.Drawing.Size(140, 20);
            this.namebx.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Выберите предмет...";
            // 
            // passbx
            // 
            this.passbx.Location = new System.Drawing.Point(175, 114);
            this.passbx.Margin = new System.Windows.Forms.Padding(2);
            this.passbx.Name = "passbx";
            this.passbx.Size = new System.Drawing.Size(140, 20);
            this.passbx.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Введите пароль...";
            // 
            // mailbx
            // 
            this.mailbx.Location = new System.Drawing.Point(175, 220);
            this.mailbx.Margin = new System.Windows.Forms.Padding(2);
            this.mailbx.Name = "mailbx";
            this.mailbx.Size = new System.Drawing.Size(140, 20);
            this.mailbx.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Введите имя...";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pan
            // 
            this.pan.AutoScroll = true;
            this.pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan.Location = new System.Drawing.Point(0, 44);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(784, 257);
            this.pan.TabIndex = 2;
            this.pan.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label9.Location = new System.Drawing.Point(326, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Почта";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 44);
            this.panel1.TabIndex = 5;
            // 
            // AdminTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.addpan);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminTeacher";
            this.Text = "AdminTeacher";
            this.Load += new System.EventHandler(this.AdminTeacher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminTeacher_KeyDown);
            this.addpan.ResumeLayout(false);
            this.addpan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel addpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox namebx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox subj2cbx;
        private System.Windows.Forms.ComboBox subj1cbx;
        private System.Windows.Forms.TextBox loginbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}