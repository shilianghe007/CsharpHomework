using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace program1
{
    [Serializable]
    public class Person
    {
        public Person() { }
        public int num { set; get; }
        public string goodName { set; get; }
        public string customerName { set; get; }
        public double prices { set; get; }
        public Person (int num,string goodName,string customerName,double prices)
        {
            this.num = num;
            this.goodName = goodName;
            this.customerName = customerName;
            this.prices = prices;
        }
    }
    public class OrderService
    {
        public List<int> Nums = new List<int>();
        public List<string> goodName = new List<string>();
        public List<string> customerName = new List<string>();
        public List<double> prices = new List<double>();
        public List<Person> peoples = new List<Person>();
        //序列化
        public void Export()
        {
            int i = 0;
            foreach (int num in Nums)
            {
                addPeople(new Person(num, goodName[i], customerName[i], prices[i]));
                i++;
            }

            //BinaryFormatter bf = new BinaryFormatter();

            XmlSerializer xs = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                xs.Serialize(fs, peoples);
            }
            Console.WriteLine("已成功序列化！");
        }
        //反序列化
        public void Import()
        {
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Person>));
                List<Person> pl = (List<Person>)xs.Deserialize(fs);
                int i = 0;
                foreach(Person people in pl)
                {
                    Nums[i] = people.num;
                    goodName[i] = people.goodName;
                    customerName[i] = people.customerName;
                    prices[i] = people.prices;
                    i++;
                }
                Console.WriteLine("载入成功！");
            }
        }
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
        public void addPrice(double price)
        {
            prices.Add(price);
        }
        public void addPeople(Person people)
        {
            peoples.Add(people);
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
        public void deletePrice(int num)
        {
            double price = prices[num];
            prices.Remove(price);
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
                    break;
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
                    break;
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
                    break;
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
        public int searchByPrice(double Pri)
        {
            int flag = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                if (prices[i] == Pri)
                {
                    flag = i;
                    break;
                }
                else
                {
                    if (i == prices.Count - 1)
                    {
                        Exception e0 = new Exception();
                        throw e0;
                    }
                }

            }
            return flag;
        }
    }
}
