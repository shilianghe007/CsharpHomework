using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService os = new OrderService();
        [TestMethod()]
        public void ExportTest()
        {
            os.Export();
        }

        [TestMethod()]
        public void ImportTest()
        {
            os.Import();
        }

        [TestMethod()]
        public void addOrderTest()
        {
            os.addOrder(9);
        }

        [TestMethod()]
        public void addGoodNameTest()
        {
            os.addGoodName("aaa");
        }

        [TestMethod()]
        public void addCustomerNameTest()
        {
            os.addCustomerName("aaa");
        }

        [TestMethod()]
        public void addPriceTest()
        {
            os.addPrice(23);
        }

        [TestMethod()]
        public void addPeopleTest()
        {
            os.addPeople(new Person());
        }

        [TestMethod()]
        public void deleteNumTest()
        {
            os.deleteNum(2);
        }

        [TestMethod()]
        public void deleteGoodNameTest()
        {
            os.deleteGoodName(2);
        }

        [TestMethod()]
        public void deleteCustomerNameTest()
        {
            os.deleteCustomerName(2);
        }

        [TestMethod()]
        public void deletePriceTest()
        {
            os.deletePrice(1);
        }

        [TestMethod()]
        public void changeNumTest()
        {
            os.changeNum(1, 2);
        }

        [TestMethod()]
        public void changeGoodNameTest()
        {
            os.changeGoodName("d", "a");
        }

        [TestMethod()]
        public void changeCustomerNameTest()
        {
            os.changeCustomerName("s", "f");
        }

        [TestMethod()]
        public void searchByNumTest()
        {
            os.searchByNum(4);
        }

        [TestMethod()]
        public void searchByGoodNameTest()
        {
            os.searchByGoodName("ds");
        }

        [TestMethod()]
        public void searchByCustomerNameTest()
        {
            os.searchByCustomerName("dw");
        }

        [TestMethod()]
        public void searchByPriceTest()
        {
            os.searchByPrice(2);
        }
    }
}