using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program1;

namespace program1
{
    class Order
    {
        List<OrderDetails> orders;
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
