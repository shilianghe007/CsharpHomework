using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program2;

namespace program2
{
    class Order
    {
        List<OrderDetails> orders;
        private int num = 0;
        public Order()
        {
            orders = new List<OrderDetails>();
        }
        public void addNewOrder(OrderDetails anOrder)
        {
            orders.Add(anOrder);
        }

    }
}
