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
namespace homework7
{
    public partial class Form1 : Form
    {
        public OrderService os = new OrderService();
        Person p = new Person(1, "a", "b", 10);
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
    }
}
