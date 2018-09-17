using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入三个数字：");
            string[] numString;
            numString = new string[3];
            int[] num;
            num = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numString[i] = Console.ReadLine();
            }

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    num[i] = int.Parse(numString[i]);
                };
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            //输出数组中最大的数
            int numMax = -2000;
            foreach(int nums in num)
            {
                if(numMax == -2000)
                {
                    numMax = nums;
                }
                else
                {
                    if(nums > numMax)
                    {
                        numMax = nums;
                    }
                }
            }
            Console.WriteLine("数组中最大的数是：" + numMax);

            //输出数组中最小的数
            int numMin = -2000;
            foreach (int nums in num)
            {
                if (numMin == -2000)
                {
                    numMin = nums;
                }
                else
                {
                    if (nums < numMin)
                    {
                        numMin = nums;
                    }
                }
            }
            Console.WriteLine("数组中最小的数是：" + numMin);

            //输出数组的平均值
            int numAll = 0;
            foreach(int nums in num)
            {
                numAll += nums;
            }
            double numAverage;
            numAverage = (double)numAll / num.Length;
            Console.WriteLine("数组的平均值是：" + numAverage);
            Console.WriteLine("数组的元素和是：" + numAll);

        }
    }
}
