namespace clientчето_там
{
    partial class AdminSubject
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
            this.addpan = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.namebx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletepan
            // 
            this.deletepan.AutoScroll = true;
            this.deletepan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletepan.Location = new System.Drawing.Point(0, 38);
            this.deletepan.Name = "deletepan";
            this.deletepan.Size = new System.Drawing.Size(800, 336);
            this.deletepan.TabIndex = 0;
            // 
            // addpan
            // 
            this.addpan.Controls.Add(this.button1);
            this.addpan.Controls.Add(this.label3);
            this.addpan.Controls.Add(this.namebx);
            this.addpan.Controls.Add(this.label2);
            this.addpan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addpan.Location = new System.Drawing.Point(0, 380);
            this.addpan.Name = "addpan";
            this.addpan.Size = new System.Drawing.Size(800, 243);
            this.addpan.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(619, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите название прeдмета...";
            // 
            // namebx
            // 
            this.namebx.Location = new System.Drawing.Point(17, 74);
            this.namebx.Name = "namebx";
            this.namebx.Size = new System.Drawing.Size(162, 22);
            this.namebx.TabIndex = 1;
            this.namebx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добавить предмет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Удалить предмет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addpan);
            this.Controls.Add(this.deletepan);
            this.Name = "AdminSubject";
            this.Text = "AdminSubject";
            this.Load += new System.EventHandler(this.AdminSubject_Load);
            this.addpan.ResumeLayout(false);
            this.addpan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel deletepan;
        private System.Windows.Forms.Panel addpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namebx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}