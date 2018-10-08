using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderService
    {
        public List<int> Nums = new List<int>();
        public List<string> goodName = new List<string>();
        public List<string> customerName = new List<string>();
        //增加
        public void addOrder(int num)
        {
            Nums.Add(num);
        }
        public void addGoodName(string name)
        {
            goodName.Add(name);
        }
        public void addCustomerName(string name)
        {
            customerName.Add(name);
        }
        //删除
        public void deleteNum(int num)
        {
            Nums.Remove(Nums[num]);
        }
        public void deleteGoodName(int num)
        {
            string goodname = goodName[num];
            goodName.Remove(goodname);
        }
        public void deleteCustomerName(int num)
        {
            string customername = customerName[num];
            customerName.Remove(customername);
        }
        //修改
        public bool changeNum(int oldNum, int newNum)
        {
            bool N = true;
            for(int i=0;i < Nums.Count;i++)
            {
                if(Nums[i]==oldNum)
                {
                    Nums[i] = newNum;
                    N = true;
                }
                else
                {
                    if(i == Nums.Count - 1)
                    {
                        N = false;
                    }
                }
            }
            return N;
        }
        public bool changeGoodName(string oldGoodName,string newGoodName)
        {
            bool N = true;
            for (int i = 0; i < goodName.Count; i++)
            {
                if (goodName[i] == oldGoodName)
                {
                    goodName[i] = newGoodName;
                    N = true;
                }
                else
                {
                    if (i == goodName.Count - 1)
                    {
                        N = false;
                    }
                }
            }
            return N;
        }
        public bool changeCustomerName(string oldCustomerName, string newCustomerName)
        {
            bool N = true;
            for (int i = 0; i < customerName.Count; i++)
            {
                if (customerName[i] == oldCustomerName)
                {
                    customerName[i] = newCustomerName;
                    N = true;
                }
                else
                {
                    if (i == customerName.Count - 1)
                    {
                        N = false;
                    }
                }
            }
            return N;
        }
        //查询目标的下标
        public int searchByNum(int Num)
        {
            int flag = 0;
            for(int i=0;i<Nums.Count;i++)
            {
                if (Nums[i] == Num)
                {
                    flag = i;
                }
                else
                {
                    if (i == Nums.Count - 1)
                    {
                        Exception e0 = new Exception();
                        throw e0;
                    }
                }
                    
            }
            return flag;
        }
        public int searchByGoodName(string gN)
        {
            int flag = 0;
            for (int i = 0; i < goodName.Count; i++)
            {
                if (goodName[i] == gN)
                {
                    flag = i;
                }
                else
                {
                    if (i == Nums.Count - 1)
                    {
                        Exception e1 = new Exception();
                        throw e1;
                    }
                }
            }
            return flag;
        }
        public int searchByCustomerName(string cN)
        {
            int flag = 0;
            for (int i = 0; i < customerName.Count; i++)
            {
                if (customerName[i] == cN)
                {
                    flag = i;
                }
                else
                {
                    if (i == Nums.Count - 1)
                    {
                        Exception e2 = new Exception();
                        throw e2;
                    }
                }
            }
            return flag;
        }
    }
}
