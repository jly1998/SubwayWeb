using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Graph : Form
    {
        ALGraph algraph = new ALGraph();
        Lines L = new Lines();
        int LineNum = 0;

        public Graph()
        {
            InitializeComponent();            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBox_Arc.Text)) && (!string.IsNullOrEmpty(textBoxLine.Text)) && (!string.IsNullOrEmpty(textBoxLineNum.Text))) 
            {
                int line = Convert.ToInt32(textBoxLine.Text);
                int num = Convert.ToInt32(textBoxLineNum.Text);
                string[] strs = textBox_Arc.Lines[0].Split(' ');
                int i;

                L.AddLine(line, num, strs);

                for (i = 0; i < num - 1; i++) 
                {
                    
                    algraph.AddArc(strs[i], strs[i+1], line);
                    
                }
                

                textBox_Arc.Text = "";
                textBoxLine.Text = "";
                textBoxLineNum.Text = "";
                textBox_algraph.Text = L.printLines();
            }
            
        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_algraph_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string temp = "";
            temp += L.printLines();
            temp += "\r\n\r\n换乘站信息：\r\n";
            temp += algraph.GetTrans();
            textBox_algraph.Text = temp;
            
        }

        private void textBox_DFS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttondfs_Click(object sender, EventArgs e)
        {
            string begin = textBoxBegin.Text;
            string end = textBoxEnd.Text;
            textBox_Search.Text = algraph.shortestPath(begin, end);

        }
        private void buttonbfs_Click(object sender, EventArgs e)
        {
           
        }

        private void AddVexB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_vex.Text))
            {
                algraph.AddVex(textBox_vex.Text);
                textBox_vex.Text = "";
                textBox_algraph.Text = algraph.Print();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxBegin_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
