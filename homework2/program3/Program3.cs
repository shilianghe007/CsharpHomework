using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int[] nums;
            nums = new int[99];
            //为数组赋初值
            for(int i = 0;i < 99;i++)
            {
                nums[i] = i + 2;
            }
            //for(int i = 0;i < 99;i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //一个个去除
            int ereaser = 0;
            for(int i = 2;i < 101;i++)
            {
                for(int j = 2;j < 51;j++)
                {
                    for(int k = 0;k < 99;k++)
                    {
                        if(i*j == nums[k])
                        {
                            for(int m = k;m < 98;m++)
                            {
                                nums[m] = nums[m + 1];                            
                            }
                            nums[98] = 2;
                            ereaser++;
                        }
                    }
                }
            }
            Console.WriteLine("2-100内的所有素数：");
            for(int i = 0;i < 99 - ereaser;i++)
            {
                Console.WriteLine(nums[i] );
            }
        }
    }
}
