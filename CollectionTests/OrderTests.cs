using System.Collections.Generic;
using System.Linq;
using Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void GetOrdersTest()
        {
            var service = new ServiceAccounting();
            var orders = service.GetOrders();
            Assert.AreEqual(2, orders.Count());
        }

        [TestMethod]
        public void GetByNameTest()
        {
            var service = new ServiceAccounting();
            var names = new List<string>() { "Мука", "Вода" };
            var materials = service.GetMaterialByName(names);
            Assert.AreEqual(2, materials.Count());
        }

        [TestMethod]
        public void GetSumCollectionTest()
        {
            var service = new ServiceAccounting();
            var orders = service.GetSumCollection();
        }

        [TestMethod]
        public void MinElementCollectionTest()
        {
            var service = new ServiceAccounting();
            var orders = service.MinElementCollection();
        }

        [TestMethod]
        public void MaxElementCollectionTest()
        {
            var service = new ServiceAccounting();
            var orders = service.MaxElementCollection();
        }

        [TestMethod]
        public void CountStringElementCollectionTest()
        {
            var service = new ServiceAccounting();
            var orders = service.CountStringElementCollection();
        }

        [TestMethod]
        public void CountElementCollectionTest()
        {
            var service = new ServiceAccounting();
            var orders = service.CountElementCollection(); }

        [TestMethod]
        public void AverageCollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.AverageCollection();
        }

        [TestMethod]
        public void ElementAt_StringCollectionTest()
        {
            var service = new ServiceAccounting();
            var name = service.ElementAt_StringCollection();
        }

        [TestMethod]
        public void ElementAt_CollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.ElementAt_Collection();
        }

        [TestMethod]
        public void ElementAtOrDefault_CollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.ElementAtOrDefault_Collection();
        }

        [TestMethod]
        public void ElementAtOrDefault_StringCollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.ElementAtOrDefault_StringCollection();
        }

        [TestMethod]
        public void FirstElementCollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.FirstElementCollection();
        }

        [TestMethod]
        public void FirstElementConditionalCollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.FirstElementConditionalCollection();
        }

        [TestMethod]
        public void FirstOrDefaultElementCollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.FirstOrDefaultElementCollection();
        }

        [TestMethod]
        public void LastElementCollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.LastElementCollection();
        }

        [TestMethod]
        public void LasrOrDefaultCollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.LasrOrDefaultCollection();
        }

        [TestMethod]
        public void LasrOrDefaultConditionalCollectionTest()
        {
            var service = new ServiceAccounting();
            var element = service.LasrOrDefaultConditionalCollection();
        }

        [TestMethod]
        public void SingleCollectionTest()
        {
            var service = new ServiceAccounting();
            service.SingleCollection();
        }

        [TestMethod]
        public void SingleElementCollectionTest()
        {
            var service = new ServiceAccounting();
            service.SingleElementCollection();
        }

        [TestMethod]
        public void SingleNullCollectionTest()
        {
            var service = new ServiceAccounting();
            service.SingleNullCollection();
        }

        [TestMethod]
        public void OrderBySmpleNumbersCollectionTest()
        {
            var service = new ServiceAccounting();
            service.OrderBySmpleNumbersCollection();
        }

        [TestMethod]
        public void DateTimeCollectionTest()
        {
            var service = new ServiceAccounting();
            service.DateTimeCollection();
        }

        [TestMethod]
        public void OrderByDescendingStringCollectionTest()
        {
            var service = new ServiceAccounting();
            service.OrderByDescendingStringCollection();
        }

        [TestMethod]
        public void OrderByDescendingCollectionTest()
        {
            var service = new ServiceAccounting();
            service.OrderByDescendingCollection();
        }

    }
}

