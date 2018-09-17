using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入三个数字：");
            string[] numString;
            numString = new string[3];
            double[] num;
            num = new double[3];
            for (int i = 0; i < 3; i++)
            {
                numString[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                num[i] = double.Parse(numString[i]);
            }
            double[] num2;
            num2 = new double[3] { 0,0,0};
            Console.WriteLine("这三个数中，有如下素数：");
            for (int i=0;i < 3;i++)
            {
                if (num[i] == 2)
                    num2[i] = num[i];
                if(num[i] > 2 && num[i] % 1 == 0)
                    for(int j=2;j < num[i];j++)
                    {
                        if((num[i]/j)%1==0)
                        {
                            num2[i] = 0;
                            break;
                        }
                        else
                        {
                            num2[i] = num[i];
                        }
                    }
                if (num2[i] != 0)
                    Console.WriteLine(num2[i]);
            }
        }
    }
}
