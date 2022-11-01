namespace clientчето_там
{
    partial class aut
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
            this.passtb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.pass2tb = new System.Windows.Forms.TextBox();
            this.mailtb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.subj2cbx = new System.Windows.Forms.ComboBox();
            this.subj1cbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.logintb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(13, 151);
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(185, 22);
            this.passtb.TabIndex = 4;
            this.passtb.TextChanged += new System.EventHandler(this.passtb_TextChanged);
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(12, 63);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(186, 22);
            this.nametb.TabIndex = 3;
            // 
            // pass2tb
            // 
            this.pass2tb.Location = new System.Drawing.Point(12, 195);
            this.pass2tb.Name = "pass2tb";
            this.pass2tb.Size = new System.Drawing.Size(186, 22);
            this.pass2tb.TabIndex = 5;
            // 
            // mailtb
            // 
            this.mailtb.Location = new System.Drawing.Point(12, 341);
            this.mailtb.Name = "mailtb";
            this.mailtb.Size = new System.Drawing.Size(186, 22);
            this.mailtb.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(12, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите Ваше имя...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите Ваш пароль...";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Подтвердите Ваш пароль...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите Вашу почту...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выберите Ваш предмет...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Вберите Ваш второй предмет...";
            // 
            // subj2cbx
            // 
            this.subj2cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subj2cbx.FormattingEnabled = true;
            this.subj2cbx.Location = new System.Drawing.Point(13, 292);
            this.subj2cbx.Name = "subj2cbx";
            this.subj2cbx.Size = new System.Drawing.Size(185, 24);
            this.subj2cbx.TabIndex = 29;
            // 
            // subj1cbx
            // 
            this.subj1cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subj1cbx.FormattingEnabled = true;
            this.subj1cbx.Location = new System.Drawing.Point(13, 242);
            this.subj1cbx.Name = "subj1cbx";
            this.subj1cbx.Size = new System.Drawing.Size(185, 24);
            this.subj1cbx.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Введите Ваш логин...";
            // 
            // logintb
            // 
            this.logintb.Location = new System.Drawing.Point(12, 107);
            this.logintb.Name = "logintb";
            this.logintb.Size = new System.Drawing.Size(186, 22);
            this.logintb.TabIndex = 30;
            // 
            // aut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 420);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.logintb);
            this.Controls.Add(this.subj2cbx);
            this.Controls.Add(this.subj1cbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailtb);
            this.Controls.Add(this.pass2tb);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.nametb);
            this.Name = "aut";
            this.Text = "aut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox pass2tb;
        private System.Windows.Forms.TextBox mailtb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox subj2cbx;
        private System.Windows.Forms.ComboBox subj1cbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox logintb;
    }
}