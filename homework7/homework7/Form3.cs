using program1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace homework7
{
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = -1;
            string keyWorld = textBox1.Text;           
            for(int i = 0;i<checkedListBox1.Items.Count;i++)
            {
                if(checkedListBox1.GetItemChecked(i))
                {
                    num = i;
                    break;
                }
            }

            if (num == 0)
            {
                int a = Int32.Parse(keyWorld);
                //var orderList = from n in form1.os.Nums where n == a select n;
                int flag0 = -1;
                for (int i = 0; i < form1.os.peoples.Count;i++)
                {
                    if(a == form1.os.peoples[i].num)
                    {
                        flag0 = i;
                        break;
                    }
                }
                if(flag0 != -1)
                {
                    textBox2.Text = "已查到：" + form1.os.peoples[flag0].num + "号订单  商品名为" +
                    form1.os.peoples[flag0].goodName + "  买家为"
                    + form1.os.peoples[flag0].customerName + "  价格是" + form1.os.peoples[flag0].prices + "元";
                }
                else {textBox2.Text = "sorry~ I don't find your order~"; }
            }
            else if(num == 1)
            {
                string goodName = keyWorld;
                var orderList = from n in form1.os.goodName where n == goodName select n;
                int flag1 = -1;
                for(int i = 0; i < form1.os.peoples.Count; i++)
                {
                    if(goodName == form1.os.peoples[i].goodName)
                    {
                        flag1 = i;
                        break;
                    }
                }
                if (flag1 != -1)
                {
                    textBox2.Text = "已查到：" + form1.os.peoples[flag1].num + "号订单  商品名为" +
                    form1.os.peoples[flag1].goodName + "  买家为"
                    + form1.os.peoples[flag1].customerName + "  价格是" + form1.os.peoples[flag1].prices + "元";
                }
                else { textBox2.Text = "sorry~ I don't find your order~"; }
            }
            else if(num == 2)
            {
                string customerName = keyWorld;
                var orderList = from n in form1.os.customerName where n == customerName select n;
                int flag2 = -1;
                for (int i = 0; i < form1.os.peoples.Count; i++)
                {
                    if (customerName == form1.os.peoples[i].customerName)
                    {
                        flag2 = i;
                        break;
                    }
                }
                if (flag2 != -1)
                {
                    textBox2.Text = "已查到：" + form1.os.peoples[flag2].num + "号订单  商品名为" +
                    form1.os.peoples[flag2].goodName + "  买家为"
                    + form1.os.peoples[flag2].customerName + "  价格是" + form1.os.peoples[flag2].prices + "元";
                }
                else { textBox2.Text = "sorry~ I don't find your order~"; }
            }
            else
            {
                textBox2.Text = "sorry~ I don't find your order~";
            }
            //form1.os.deletePeople(person);
            //form1.bindingSource1.DataSource = new Person();
            //form1.bindingSource1.DataSource = form1.os.peoples;
            //this.Close();
        }
    }
}
