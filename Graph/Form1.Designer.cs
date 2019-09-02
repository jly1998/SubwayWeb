namespace Graph
{
    partial class Graph
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_vex = new System.Windows.Forms.TextBox();
            this.AddArcB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Arc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_algraph = new System.Windows.Forms.TextBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLineNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLine = new System.Windows.Forms.TextBox();
            this.AddVexB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxBegin = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_vex
            // 
            this.textBox_vex.Location = new System.Drawing.Point(29, 44);
            this.textBox_vex.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_vex.Name = "textBox_vex";
            this.textBox_vex.Size = new System.Drawing.Size(149, 28);
            this.textBox_vex.TabIndex = 0;
            // 
            // AddArcB
            // 
            this.AddArcB.Location = new System.Drawing.Point(29, 582);
            this.AddArcB.Margin = new System.Windows.Forms.Padding(4);
            this.AddArcB.Name = "AddArcB";
            this.AddArcB.Size = new System.Drawing.Size(112, 34);
            this.AddArcB.TabIndex = 1;
            this.AddArcB.Text = "添加路径";
            this.AddArcB.UseVisualStyleBackColor = true;
            this.AddArcB.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "站点名称（一次仅能输入一个）：";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox_Arc
            // 
            this.textBox_Arc.Location = new System.Drawing.Point(29, 240);
            this.textBox_Arc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Arc.Multiline = true;
            this.textBox_Arc.Name = "textBox_Arc";
            this.textBox_Arc.Size = new System.Drawing.Size(285, 319);
            this.textBox_Arc.TabIndex = 3;
            this.textBox_Arc.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "相邻站点用空格分割（结束回车）";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox_algraph
            // 
            this.textBox_algraph.Location = new System.Drawing.Point(25, 44);
            this.textBox_algraph.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_algraph.Multiline = true;
            this.textBox_algraph.Name = "textBox_algraph";
            this.textBox_algraph.Size = new System.Drawing.Size(313, 515);
            this.textBox_algraph.TabIndex = 6;
            this.textBox_algraph.TextChanged += new System.EventHandler(this.TextBox_algraph_TextChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(29, 409);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(259, 57);
            this.textBox_Search.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 582);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "显示换乘站信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxLineNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxLine);
            this.panel1.Controls.Add(this.AddVexB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_vex);
            this.panel1.Controls.Add(this.textBox_Arc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddArcB);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 651);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "线路站点数：";
            // 
            // textBoxLineNum
            // 
            this.textBoxLineNum.Location = new System.Drawing.Point(193, 160);
            this.textBoxLineNum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLineNum.Name = "textBoxLineNum";
            this.textBoxLineNum.Size = new System.Drawing.Size(121, 28);
            this.textBoxLineNum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "线路编号：";
            // 
            // textBoxLine
            // 
            this.textBoxLine.Location = new System.Drawing.Point(29, 160);
            this.textBoxLine.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLine.Name = "textBoxLine";
            this.textBoxLine.Size = new System.Drawing.Size(112, 28);
            this.textBoxLine.TabIndex = 6;
            this.textBoxLine.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // AddVexB
            // 
            this.AddVexB.Location = new System.Drawing.Point(202, 44);
            this.AddVexB.Margin = new System.Windows.Forms.Padding(4);
            this.AddVexB.Name = "AddVexB";
            this.AddVexB.Size = new System.Drawing.Size(112, 34);
            this.AddVexB.TabIndex = 5;
            this.AddVexB.Text = "添加站点";
            this.AddVexB.UseVisualStyleBackColor = true;
            this.AddVexB.Click += new System.EventHandler(this.AddVexB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_algraph);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(367, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 651);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "站点邻接链表信息/线路信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxEnd);
            this.groupBox2.Controls.Add(this.textBoxBegin);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.textBox_Search);
            this.groupBox2.Location = new System.Drawing.Point(739, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 651);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "路径规划";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(44, 287);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 31);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "显示路径";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttondfs_Click);
            // 
            // textBoxBegin
            // 
            this.textBoxBegin.Location = new System.Drawing.Point(29, 169);
            this.textBoxBegin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBegin.Name = "textBoxBegin";
            this.textBoxBegin.Size = new System.Drawing.Size(162, 28);
            this.textBoxBegin.TabIndex = 13;
            this.textBoxBegin.TextChanged += new System.EventHandler(this.textBoxBegin_TextChanged);
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(276, 169);
            this.textBoxEnd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(149, 28);
            this.textBoxEnd.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "出发站：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "到达站：";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Graph";
            this.Text = "Graph";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public bool IsNumber(string str)
        {
            bool yes = true;
            char ch;
            int t = 0, len;
            len = str.Length;
            if (string.IsNullOrEmpty(str)) yes = false;
            else
            {
                for(int i=0;i<len;i++)
                {
                    ch = char.Parse(str.Substring(i, 1));
                    if (ch == '.') t++;
                    if(!char.IsDigit(ch) && ch!= '.')
                    {
                        yes = false;
                        break;
                    }
                }
            }
            return yes;
        }

        private System.Windows.Forms.TextBox textBox_vex;
        private System.Windows.Forms.Button AddArcB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Arc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_algraph;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button AddVexB;
        private System.Windows.Forms.TextBox textBoxLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLineNum;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxBegin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

