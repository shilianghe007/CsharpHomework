using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using program1;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace homework7
{
    public partial class Form1 : Form
    {
        public OrderService os = new OrderService();
        Person p = new Person(20181111001,13277035523, "电脑", "slh", 5000);
        public Form1()
        {
            os.addPeople(p);
            InitializeComponent();
            bindingSource1.DataSource = os.peoples;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(this).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            os.peoples.RemoveAt(i);
            bindingSource1.DataSource = new Person();
            bindingSource1.DataSource = os.peoples;
            //new Form3(this).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Form2(this).ShowDialog();
            int i = dataGridView1.CurrentRow.Index;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form3(this).ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            os.Export();

            XmlDocument doc = new XmlDocument();
            doc.Load("order.xml");

            XPathNavigator nav = doc.CreateNavigator();
            nav.MoveToRoot();

            XslCompiledTransform xt = new XslCompiledTransform();
            xt.Load("aaa.xslt");

            FileStream outFileStream = File.OpenWrite("order.html");
            XmlTextWriter writer =
                new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
            xt.Transform(nav, null, writer);
        }
    }
}
