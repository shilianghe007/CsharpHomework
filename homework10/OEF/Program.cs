using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome!");
            OrderService orderService = new OrderService();
            List<OrderDetail> details = new List<OrderDetail>() {
                new OrderDetail("1", "computer", 10.0, 20),
                new OrderDetail("2", "iPad", 2.0, 100)
            };
            Order order = new Order("001", "slh", DateTime.Now, details);

            orderService.Add(order);

            Order order2 = new Order("002", "slh", DateTime.Now, details);
            orderService.Update(order2);


            List<Order> orders = orderService.QueryByCustormer("slh");
            orders.ForEach(
              o => Console.WriteLine($"{o.Id},{o.Customer}"));

        }
    }
}
