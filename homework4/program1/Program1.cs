using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clock;

namespace homework4
{
    //定义一个委托，申明事件处理函数的格式 
    public delegate void ClickHandler(object sender, EventArgs args);


    class Program1
    {
        static void Main(string[] args)
        {
            int h = 0, m = 0, s = 0;
            Console.WriteLine("请输入你想要设置的闹钟时间的小时，例如：08");
            try {
                h = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("请输入你想要设置的闹钟时间的分钟，例如：20");
            try
            {
                m = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("请输入你想要设置的闹钟时间的秒数，例如：30");
            try
            {
                s = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ClassClock clock0 = new ClassClock(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            clock0.setClock(h, m, s);
            clock0.OnClick += new ClickHandler(clock0.runClock); //添加一个委托实例    

            bool b = true;

            while (b)
            {
                if(DateTime.Now.Hour == clock0.getHour() && DateTime.Now.Minute == clock0.getMinute() && DateTime.Now.Second == clock0.getSecond())
                {
                    b = false;
                    clock0.Click();
                }
            }
        }
               
    }
}

