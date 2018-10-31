using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class OrderDetails
    {
        private int orderNum;
        private string goodName;
        private string customerName;
        private double price;
        public OrderDetails(int orderNum, string goodName, string customerName,double price)
        {
            this.orderNum = orderNum;
            this.goodName = goodName;
            this.customerName = customerName;
            this.price = price;
        }
        public int getOrderNum()
        {
            return orderNum;
        }
        public string getGoodName()
        {
            return goodName;
        }
        public string getCustomerName()
        {
            return customerName;
        }
        public double getPrice()
        {
            return price;
        }
    }
}