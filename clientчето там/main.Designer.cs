namespace clientчето_там
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teachercbx = new System.Windows.Forms.ComboBox();
            this.presearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stusearch = new System.Windows.Forms.Button();
            this.grcbx = new System.Windows.Forms.ComboBox();
            this.faccbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.downpan = new System.Windows.Forms.Panel();
            this.wenpan = new System.Windows.Forms.TableLayoutPanel();
            this.tuepan = new System.Windows.Forms.TableLayoutPanel();
            this.satpan = new System.Windows.Forms.TableLayoutPanel();
            this.fripan = new System.Windows.Forms.TableLayoutPanel();
            this.thupan = new System.Windows.Forms.TableLayoutPanel();
            this.monpan = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FiltrPanel.SuspendLayout();
            this.downpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.FiltrPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiltrPanel.Controls.Add(this.button3);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.teachercbx);
            this.FiltrPanel.Controls.Add(this.presearch);
            this.FiltrPanel.Controls.Add(this.button2);
            this.FiltrPanel.Controls.Add(this.button1);
            this.FiltrPanel.Controls.Add(this.stusearch);
            this.FiltrPanel.Controls.Add(this.grcbx);
            this.FiltrPanel.Controls.Add(this.faccbx);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 0);
            this.FiltrPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(657, 160);
            this.FiltrPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите группу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(270, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите фамилию препода";
            // 
            // teachercbx
            // 
            this.teachercbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teachercbx.FormattingEnabled = true;
            this.teachercbx.Location = new System.Drawing.Point(269, 38);
            this.teachercbx.Margin = new System.Windows.Forms.Padding(2);
            this.teachercbx.Name = "teachercbx";
            this.teachercbx.Size = new System.Drawing.Size(220, 21);
            this.teachercbx.TabIndex = 14;
            this.teachercbx.SelectedIndexChanged += new System.EventHandler(this.teachercbx_SelectedIndexChanged);
            // 
            // presearch
            // 
            this.presearch.Location = new System.Drawing.Point(269, 63);
            this.presearch.Margin = new System.Windows.Forms.Padding(2);
            this.presearch.Name = "presearch";
            this.presearch.Size = new System.Drawing.Size(86, 28);
            this.presearch.TabIndex = 12;
            this.presearch.Text = "Найти";
            this.presearch.UseVisualStyleBackColor = true;
            this.presearch.Click += new System.EventHandler(this.presearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 47);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Я препод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Я Дамблдор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stusearch
            // 
            this.stusearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stusearch.Location = new System.Drawing.Point(9, 116);
            this.stusearch.Margin = new System.Windows.Forms.Padding(2);
            this.stusearch.Name = "stusearch";
            this.stusearch.Size = new System.Drawing.Size(86, 28);
            this.stusearch.TabIndex = 6;
            this.stusearch.Text = "Найти";
            this.stusearch.UseVisualStyleBackColor = false;
            this.stusearch.Click += new System.EventHandler(this.search_Click);
            // 
            // grcbx
            // 
            this.grcbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grcbx.Enabled = false;
            this.grcbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grcbx.FormattingEnabled = true;
            this.grcbx.Location = new System.Drawing.Point(9, 84);
            this.grcbx.Margin = new System.Windows.Forms.Padding(2);
            this.grcbx.Name = "grcbx";
            this.grcbx.Size = new System.Drawing.Size(161, 28);
            this.grcbx.TabIndex = 4;
            // 
            // faccbx
            // 
            this.faccbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faccbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.faccbx.FormattingEnabled = true;
            this.faccbx.Location = new System.Drawing.Point(7, 31);
            this.faccbx.Margin = new System.Windows.Forms.Padding(2);
            this.faccbx.Name = "faccbx";
            this.faccbx.Size = new System.Drawing.Size(161, 28);
            this.faccbx.TabIndex = 1;
            this.faccbx.SelectedIndexChanged += new System.EventHandler(this.faccbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите факультет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // downpan
            // 
            this.downpan.Controls.Add(this.wenpan);
            this.downpan.Controls.Add(this.tuepan);
            this.downpan.Controls.Add(this.satpan);
            this.downpan.Controls.Add(this.fripan);
            this.downpan.Controls.Add(this.thupan);
            this.downpan.Controls.Add(this.monpan);
            this.downpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downpan.Location = new System.Drawing.Point(0, 160);
            this.downpan.Name = "downpan";
            this.downpan.Size = new System.Drawing.Size(657, 701);
            this.downpan.TabIndex = 1;
            // 
            // wenpan
            // 
            this.wenpan.BackColor = System.Drawing.Color.Bisque;
            this.wenpan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.wenpan.ColumnCount = 3;
            this.wenpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.wenpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.wenpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.wenpan.Location = new System.Drawing.Point(24, 499);
            this.wenpan.Margin = new System.Windows.Forms.Padding(2);
            this.wenpan.Name = "wenpan";
            this.wenpan.RowCount = 5;
            this.wenpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.wenpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.wenpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.wenpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.wenpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.wenpan.Size = new System.Drawing.Size(285, 177);
            this.wenpan.TabIndex = 34;
            // 
            // tuepan
            // 
            this.tuepan.BackColor = System.Drawing.Color.Bisque;
            this.tuepan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tuepan.ColumnCount = 3;
            this.tuepan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tuepan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tuepan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tuepan.Location = new System.Drawing.Point(24, 266);
            this.tuepan.Margin = new System.Windows.Forms.Padding(2);
            this.tuepan.Name = "tuepan";
            this.tuepan.RowCount = 5;
            this.tuepan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tuepan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tuepan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tuepan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tuepan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tuepan.Size = new System.Drawing.Size(285, 177);
            this.tuepan.TabIndex = 33;
            // 
            // satpan
            // 
            this.satpan.BackColor = System.Drawing.Color.Bisque;
            this.satpan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.satpan.ColumnCount = 3;
            this.satpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.satpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.satpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.satpan.Location = new System.Drawing.Point(343, 499);
            this.satpan.Margin = new System.Windows.Forms.Padding(2);
            this.satpan.Name = "satpan";
            this.satpan.RowCount = 5;
            this.satpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.satpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.satpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.satpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.satpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.satpan.Size = new System.Drawing.Size(285, 177);
            this.satpan.TabIndex = 32;
            // 
            // fripan
            // 
            this.fripan.BackColor = System.Drawing.Color.Bisque;
            this.fripan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.fripan.ColumnCount = 3;
            this.fripan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.fripan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.fripan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.fripan.Location = new System.Drawing.Point(343, 266);
            this.fripan.Margin = new System.Windows.Forms.Padding(2);
            this.fripan.Name = "fripan";
            this.fripan.RowCount = 5;
            this.fripan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.fripan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.fripan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.fripan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.fripan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.fripan.Size = new System.Drawing.Size(285, 177);
            this.fripan.TabIndex = 31;
            // 
            // thupan
            // 
            this.thupan.BackColor = System.Drawing.Color.Bisque;
            this.thupan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.thupan.ColumnCount = 3;
            this.thupan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.thupan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.thupan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.thupan.Location = new System.Drawing.Point(343, 34);
            this.thupan.Margin = new System.Windows.Forms.Padding(2);
            this.thupan.Name = "thupan";
            this.thupan.RowCount = 5;
            this.thupan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.thupan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.thupan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.thupan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.thupan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.thupan.Size = new System.Drawing.Size(285, 177);
            this.thupan.TabIndex = 30;
            // 
            // monpan
            // 
            this.monpan.BackColor = System.Drawing.Color.Bisque;
            this.monpan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.monpan.ColumnCount = 3;
            this.monpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.monpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.monpan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.monpan.Location = new System.Drawing.Point(24, 34);
            this.monpan.Margin = new System.Windows.Forms.Padding(2);
            this.monpan.Name = "monpan";
            this.monpan.RowCount = 5;
            this.monpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.monpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.monpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.monpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.monpan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.monpan.Size = new System.Drawing.Size(285, 177);
            this.monpan.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(173, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "ИЛИ";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(606, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 16;
            this.toolTip1.SetToolTip(this.button3, "Обновить");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 861);
            this.Controls.Add(this.downpan);
            this.Controls.Add(this.FiltrPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.downpan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox faccbx;
        private System.Windows.Forms.Button stusearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox grcbx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button presearch;
        private System.Windows.Forms.ComboBox teachercbx;
        private System.Windows.Forms.Panel downpan;
        private System.Windows.Forms.TableLayoutPanel wenpan;
        private System.Windows.Forms.TableLayoutPanel tuepan;
        private System.Windows.Forms.TableLayoutPanel satpan;
        private System.Windows.Forms.TableLayoutPanel fripan;
        private System.Windows.Forms.TableLayoutPanel thupan;
        private System.Windows.Forms.TableLayoutPanel monpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

