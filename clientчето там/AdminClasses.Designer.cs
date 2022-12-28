namespace clientчето_там
{
    partial class AdminClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.deletepan = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.namebx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addpan = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Удалить аудиторию";
            // 
            // deletepan
            // 
            this.deletepan.AutoScroll = true;
            this.deletepan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deletepan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletepan.Location = new System.Drawing.Point(0, 36);
            this.deletepan.Margin = new System.Windows.Forms.Padding(2);
            this.deletepan.Name = "deletepan";
            this.deletepan.Size = new System.Drawing.Size(292, 267);
            this.deletepan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите номер аудитории...";
            // 
            // namebx
            // 
            this.namebx.Location = new System.Drawing.Point(13, 60);
            this.namebx.Margin = new System.Windows.Forms.Padding(2);
            this.namebx.Name = "namebx";
            this.namebx.Size = new System.Drawing.Size(122, 20);
            this.namebx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добавить ";
            // 
            // addpan
            // 
            this.addpan.Controls.Add(this.button1);
            this.addpan.Controls.Add(this.label3);
            this.addpan.Controls.Add(this.namebx);
            this.addpan.Controls.Add(this.label2);
            this.addpan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addpan.Location = new System.Drawing.Point(0, 303);
            this.addpan.Margin = new System.Windows.Forms.Padding(2);
            this.addpan.Name = "addpan";
            this.addpan.Size = new System.Drawing.Size(292, 197);
            this.addpan.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(11, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 36);
            this.panel1.TabIndex = 6;
            // 
            // AdminClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletepan);
            this.Controls.Add(this.addpan);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "AdminClasses";
            this.Text = "AdminClasses";
            this.Load += new System.EventHandler(this.AdminClasses_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminClasses_KeyDown);
            this.addpan.ResumeLayout(false);
            this.addpan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel deletepan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namebx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel addpan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}