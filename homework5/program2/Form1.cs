using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            //将输入的值赋给变量参数
            double th1, th2, per1, per2, k, color;
            th1 = double.Parse(textBox1.Text);
            th2 = double.Parse(textBox2.Text);
            per1 = double.Parse(textBox3.Text);
            per2 = double.Parse(textBox4.Text);
            k = double.Parse(textBox5.Text);
            string colorString = comboBox1.Text;
            if (colorString == "红色")
            { color = 1; }
            else if (colorString == "绿色")
            { color = 2; }
            else if (colorString == "紫色")
            { color = 3; }
            else if (colorString == "黑色") 
            { color = 4; }
            else 
            { color = 5; }
            double th0 = -Math.PI / 2;

            drawCayleyTree(200 ,310,10, th1, th2,100 , th0, per1, per2, k, color);

            
        }
        private void drawCayleyTree(double x0,double y0,int n,double th1,double th2,double leng,double th,
            double per1,double per2,double k,double color)
        {
            if(n == 0){return;}

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1,color);

            drawCayleyTree(x1, y1, n - 1, th1, th2, per1 * leng, th + th1, per1, per2, k, color);
            drawCayleyTree(x1, y1, n - 1, th1, th2, per2 * leng, th - th2, per1, per2, k, color);
        }
        void drawLine(double x0,double y0,double x1,double y1,double color)
        {
            if(color == 1) { graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);}
            if (color == 2) { graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1); }
            if (color == 3) { graphics.DrawLine(Pens.Purple, (int)x0, (int)y0, (int)x1, (int)y1); }
            if (color == 4) { graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1); }
            if (color == 5) { graphics.DrawLine(Pens.Pink, (int)x0, (int)y0, (int)x1, (int)y1); }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
        }
    }
}
