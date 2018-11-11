using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class OrderDetails
    {
        private long orderNum;
        private long phone;
        private string goodName;
        private string customerName;
        private double price;
        public OrderDetails(long phone, long orderNum, string goodName, string customerName,double price)
        {
            this.phone = phone;
            this.orderNum = orderNum;
            this.goodName = goodName;
            this.customerName = customerName;
            this.price = price;
        }
        public long getOrderNum()
        {
            return orderNum;
        }
        public long getPhone()
        {
            return phone;
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