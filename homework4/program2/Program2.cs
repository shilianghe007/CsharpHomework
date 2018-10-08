using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program2;
namespace program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            while(true)
            {
                Console.WriteLine("欢迎来到订单管理平台，请输入你想进入的服务：1.查询订单 2.修改订单 3.删除订单 4.增加订单 5.离开");
                int i = Int32.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("你想通过什么方式查询？ 1.订单号 2.商品名称 3.用户名称");
                        int j = Int32.Parse(Console.ReadLine());
                        switch (j)
                        {
                            case 1:
                                Console.WriteLine("请输入你想查询的订单号:");
                                int num0 = Int32.Parse(Console.ReadLine());
                                try
                                {
                                    int flag0 = orderService.searchByNum(num0);
                                    Console.WriteLine("已查到：" + orderService.Nums[flag0] + orderService.goodName[flag0] + orderService.customerName[flag0]);
                                }
                                catch(Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                            case 2:
                                Console.WriteLine("请输入你想查询的商品名称:");
                                string goodName = Console.ReadLine();
                                try
                                {
                                    int flag1 = orderService.searchByGoodName(goodName);
                                    Console.WriteLine("已查到：" + orderService.Nums[flag1] + orderService.goodName[flag1] + orderService.customerName[flag1]);
                                }
                                catch(Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                            case 3:
                                Console.WriteLine("请输入你想查询的用户名称:");
                                string customerName = Console.ReadLine();
                                try
                                {
                                    int flag2 = orderService.searchByCustomerName(customerName);
                                    Console.WriteLine("已查到：" + orderService.Nums[flag2] + orderService.goodName[flag2] + orderService.customerName[flag2]);
                                }
                                catch(Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("你想修改什么值？ 1.订单号 2.商品名称 3.用户名称");
                        int k = Int32.Parse(Console.ReadLine());
                        switch (k)
                        {
                            case 1:
                                Console.WriteLine("请输入你想修改的旧订单号:");
                                int num0 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("请输入你想修改的新订单号:");
                                int num1 = Int32.Parse(Console.ReadLine());
                                orderService.changeNum(num0, num1);
                                Console.WriteLine("OK！");
                                break;
                            case 2:
                                Console.WriteLine("请输入你想修改的旧商品名称:");
                                string goodName = Console.ReadLine();
                                Console.WriteLine("请输入你想修改的新商品名称:");
                                string goodName1 = Console.ReadLine();
                                orderService.changeGoodName(goodName, goodName1);
                                Console.WriteLine("OK！");
                                break;
                            case 3:
                                Console.WriteLine("请输入你想修改的旧用户名称:");
                                string customerName = Console.ReadLine();
                                Console.WriteLine("请输入你想修改的新用户名称:");
                                string customerName1 = Console.ReadLine();
                                orderService.changeCustomerName(customerName, customerName1);
                                Console.WriteLine("OK！");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("请输入你想删除的订单号：");
                        int num = Int32.Parse(Console.ReadLine());
                        int flag = orderService.searchByNum(num);
                        orderService.deleteNum(flag);
                        orderService.deleteGoodName(flag);
                        orderService.deleteCustomerName(flag);
                        break;
                    case 4:
                        Console.WriteLine("请输入你想添加的订单的订单号：");
                        int hao = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("请输入你想添加的订单的商品名称：");
                        string shangming = Console.ReadLine();
                        Console.WriteLine("请输入你想添加的订单的用户名称：");
                        string yongming = Console.ReadLine();
                        orderService.addOrder(hao);
                        orderService.addGoodName(shangming);
                        orderService.addCustomerName(yongming);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
