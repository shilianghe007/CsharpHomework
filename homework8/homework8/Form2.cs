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
using homework7;
using System.Text.RegularExpressions;

namespace homework7
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private bool IsRepeat(long number)
        {
            bool b = false;
            foreach(Person p in form1.os.peoples)
            {
                if(p.num == number)
                {
                    b = true;
                    break;
                }
            }
            return b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string pattern1 = "^[1-2][0-9]{3}[0-1][0-9][0-3][0-9]{4}$";
            string pattern2 = "^[0-9]{11}$";
            Regex regex1 = new Regex(pattern1);
            Regex regex2 = new Regex(pattern2);
            long num = long.Parse(textBox1.Text);
            if (regex1.IsMatch(textBox1.Text) && regex2.IsMatch(textBox5.Text) && !IsRepeat(num))
                {
                    long phone = long.Parse(textBox5.Text);
                    string name1 = textBox2.Text;
                    string name2 = textBox3.Text;
                    double price = double.Parse(textBox4.Text);
                    Person person = new Person(num, phone, name1, name2, price);
                    form1.os.addPeople(person);
                    form1.bindingSource1.DataSource = new Person();
                    form1.bindingSource1.DataSource = form1.os.peoples;
                    this.Close();
                }
                else
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
