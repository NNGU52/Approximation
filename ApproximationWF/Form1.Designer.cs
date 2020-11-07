namespace ApproximationWF
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_res = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_maxy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_miny = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_maxx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_minx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.графикFxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикF1xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикYxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_m);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_n);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_b);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_a);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(720, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(58, 111);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(100, 22);
            this.textBox_m.TabIndex = 7;
            this.textBox_m.Text = "30";
            this.textBox_m.Leave += new System.EventHandler(this.textBox_m_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "m";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(58, 83);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 22);
            this.textBox_n.TabIndex = 5;
            this.textBox_n.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "n";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(58, 55);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 22);
            this.textBox_b.TabIndex = 3;
            this.textBox_b.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(58, 27);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 22);
            this.textBox_a.TabIndex = 1;
            this.textBox_a.Text = "-5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_res);
            this.groupBox2.Location = new System.Drawing.Point(720, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // richTextBox_res
            // 
            this.richTextBox_res.Location = new System.Drawing.Point(9, 21);
            this.richTextBox_res.Name = "richTextBox_res";
            this.richTextBox_res.Size = new System.Drawing.Size(218, 259);
            this.richTextBox_res.TabIndex = 0;
            this.richTextBox_res.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_maxy);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_miny);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_maxx);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_minx);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_step);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(720, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки графика";
            // 
            // textBox_maxy
            // 
            this.textBox_maxy.Location = new System.Drawing.Point(168, 77);
            this.textBox_maxy.Name = "textBox_maxy";
            this.textBox_maxy.Size = new System.Drawing.Size(40, 22);
            this.textBox_maxy.TabIndex = 17;
            this.textBox_maxy.Text = "5";
            this.textBox_maxy.Leave += new System.EventHandler(this.textBox_maxy_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "MaxY";
            // 
            // textBox_miny
            // 
            this.textBox_miny.Location = new System.Drawing.Point(58, 77);
            this.textBox_miny.Name = "textBox_miny";
            this.textBox_miny.Size = new System.Drawing.Size(40, 22);
            this.textBox_miny.TabIndex = 15;
            this.textBox_miny.Text = "0";
            this.textBox_miny.Leave += new System.EventHandler(this.textBox_miny_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "MinY";
            // 
            // textBox_maxx
            // 
            this.textBox_maxx.Location = new System.Drawing.Point(168, 49);
            this.textBox_maxx.Name = "textBox_maxx";
            this.textBox_maxx.Size = new System.Drawing.Size(40, 22);
            this.textBox_maxx.TabIndex = 13;
            this.textBox_maxx.Text = "5";
            this.textBox_maxx.Leave += new System.EventHandler(this.textBox_maxx_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "MaxX";
            // 
            // textBox_minx
            // 
            this.textBox_minx.Location = new System.Drawing.Point(58, 49);
            this.textBox_minx.Name = "textBox_minx";
            this.textBox_minx.Size = new System.Drawing.Size(40, 22);
            this.textBox_minx.TabIndex = 11;
            this.textBox_minx.Text = "-5";
            this.textBox_minx.Leave += new System.EventHandler(this.textBox_minx_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "MinX";
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(58, 21);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(100, 22);
            this.textBox_step.TabIndex = 9;
            this.textBox_step.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Step";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(247, 563);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(113, 31);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Вычислить";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(366, 563);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 31);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // chart1
            // 
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(702, 545);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.DoubleClick += new System.EventHandler(this.chart1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикFxToolStripMenuItem,
            this.графикF1xToolStripMenuItem,
            this.графикYxToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 82);
            // 
            // графикFxToolStripMenuItem
            // 
            this.графикFxToolStripMenuItem.Checked = true;
            this.графикFxToolStripMenuItem.CheckOnClick = true;
            this.графикFxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.графикFxToolStripMenuItem.Name = "графикFxToolStripMenuItem";
            this.графикFxToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.графикFxToolStripMenuItem.Text = "График f(x)";
            this.графикFxToolStripMenuItem.CheckedChanged += new System.EventHandler(this.графикFxToolStripMenuItem_CheckedChanged);
            // 
            // графикF1xToolStripMenuItem
            // 
            this.графикF1xToolStripMenuItem.Checked = true;
            this.графикF1xToolStripMenuItem.CheckOnClick = true;
            this.графикF1xToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.графикF1xToolStripMenuItem.Name = "графикF1xToolStripMenuItem";
            this.графикF1xToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.графикF1xToolStripMenuItem.Text = "График f1(x)";
            this.графикF1xToolStripMenuItem.CheckedChanged += new System.EventHandler(this.графикF1xToolStripMenuItem_CheckedChanged);
            // 
            // графикYxToolStripMenuItem
            // 
            this.графикYxToolStripMenuItem.Checked = true;
            this.графикYxToolStripMenuItem.CheckOnClick = true;
            this.графикYxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.графикYxToolStripMenuItem.Name = "графикYxToolStripMenuItem";
            this.графикYxToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.графикYxToolStripMenuItem.Text = "График Y(x)";
            this.графикYxToolStripMenuItem.CheckedChanged += new System.EventHandler(this.графикYxToolStripMenuItem_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 598);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Approximation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox_res;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_maxy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_miny;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_maxx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_minx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem графикFxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикF1xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикYxToolStripMenuItem;


    }
}

