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
            this.deletepan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addpan = new System.Windows.Forms.Panel();
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
            this.loginbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletepan
            // 
            this.deletepan.AutoScroll = true;
            this.deletepan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletepan.Location = new System.Drawing.Point(0, 45);
            this.deletepan.Name = "deletepan";
            this.deletepan.Size = new System.Drawing.Size(800, 221);
            this.deletepan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удалить учителя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.addpan.Location = new System.Drawing.Point(0, 272);
            this.addpan.Name = "addpan";
            this.addpan.Size = new System.Drawing.Size(800, 322);
            this.addpan.TabIndex = 1;
            // 
            // subj2cbx
            // 
            this.subj2cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subj2cbx.FormattingEnabled = true;
            this.subj2cbx.Location = new System.Drawing.Point(233, 222);
            this.subj2cbx.Name = "subj2cbx";
            this.subj2cbx.Size = new System.Drawing.Size(184, 24);
            this.subj2cbx.TabIndex = 27;
            // 
            // subj1cbx
            // 
            this.subj1cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subj1cbx.FormattingEnabled = true;
            this.subj1cbx.Location = new System.Drawing.Point(232, 183);
            this.subj1cbx.Name = "subj1cbx";
            this.subj1cbx.Size = new System.Drawing.Size(186, 24);
            this.subj1cbx.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(613, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Введите Ваш второй предмет...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добавить учителя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Введите Вашу почту...";
            // 
            // namebx
            // 
            this.namebx.Location = new System.Drawing.Point(232, 96);
            this.namebx.Name = "namebx";
            this.namebx.Size = new System.Drawing.Size(185, 22);
            this.namebx.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Введите Ваш предмет...";
            // 
            // passbx
            // 
            this.passbx.Location = new System.Drawing.Point(233, 140);
            this.passbx.Name = "passbx";
            this.passbx.Size = new System.Drawing.Size(185, 22);
            this.passbx.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Введите Ваш пароль...";
            // 
            // mailbx
            // 
            this.mailbx.Location = new System.Drawing.Point(233, 271);
            this.mailbx.Name = "mailbx";
            this.mailbx.Size = new System.Drawing.Size(185, 22);
            this.mailbx.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Введите Ваше имя...";
            // 
            // loginbx
            // 
            this.loginbx.Location = new System.Drawing.Point(232, 56);
            this.loginbx.Name = "loginbx";
            this.loginbx.Size = new System.Drawing.Size(185, 22);
            this.loginbx.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Введите Ваш логин...";
            // 
            // AdminTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addpan);
            this.Controls.Add(this.deletepan);
            this.Name = "AdminTeacher";
            this.Text = "AdminTeacher";
            this.Load += new System.EventHandler(this.AdminTeacher_Load);
            this.addpan.ResumeLayout(false);
            this.addpan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel deletepan;
        private System.Windows.Forms.Label label1;
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
    }
}