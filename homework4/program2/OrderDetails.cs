using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderDetails
    {
        private int orderNum;
        private string goodName;
        private string customerName;
        public OrderDetails(int orderNum, string goodName, string customerName)
        {
            this.orderNum = orderNum;
            this.goodName = goodName;
            this.customerName = customerName;
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
    }
}
