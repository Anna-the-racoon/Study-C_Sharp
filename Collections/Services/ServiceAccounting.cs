using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Collections
{
    public class ServiceAccounting
    {
        public IList<Order> Orders { get; set; }
        public IList<Material> Materials { get; set; }

        public ServiceAccounting()
        {
            Orders = new List<Order>();
            Materials = new List<Material>();

            var material1 = new Material()
            {
                Id = 1,
                Name = "Мука",
                Quantity = 10,
                Price = 60,
                OrderId = 2
            };
            var material2 = new Material()
            {
                Id = 2,
                Name = "Лен",
                Quantity = 100,
                Price = 30,
                OrderId = 1
            };
            var material3 = new Material()
            {
                Id = 3,
                Name = "Древесина",
                Quantity = 50,
                Price = 800,
                OrderId = 1
            };
            var material4 = new Material()
            {
                Id = 4,
                Name = "Вода",
                Quantity = 900,
                Price = 70,
                OrderId = 1
            };

            var order1 = new Order() { Id = 1, Number = "001" };
            var order2 = new Order() { Id = 2, Number = "002" };
            var order3 = new Order() { Id = 3, Number = "003" };
            var order4 = new Order() { Id = 4, Number = "004" };
            var order5 = new Order() { Id = 5, Number = "005" };

            Materials.Add(material1);
            Materials.Add(material2);
            Materials.Add(material3);
            Materials.Add(material4);

            order1.Materials.Add(material4);
            order1.Materials.Add(material2);

            order2.Materials.Add(material3);
            order2.Materials.Add(material1);

            Orders.Add(order1);
            Orders.Add(order2);
        }

        public IEnumerable<Order> GetOrders()
        {
            return Orders;
        }
        public IEnumerable<Material> GetMaterials()
        {
            return Materials;
        }

        public IEnumerable<Material> GetMaterialByName(List<string> names)
        {
            var newMaterials = Materials.Where(p => names.Contains(p.Name));
            return newMaterials;
        }
        public int GetSumCollection()
        {
            int[] quantity = { 2, 3, 5, 6, 9, 6, 5, 7 };
            var result = quantity.Sum();
            return result;
        }

        public int MinElementCollection()
        {
            int[] elements = { 2, 3, 5, 6, 9, 6, 5, 7 };
            var minElement = elements.Min();
            return minElement;
        }
        public int MaxElementCollection()
        {
            int[] elements = { 2, 3, 5, 6, 9, 6, 5, 7 };
            var maxElement = elements.Max();
            return maxElement;
        }

        public int CountStringElementCollection()
        {
            string[] names = { "Anna", "Artyom", "Alexandr", "Irina", "Alexey" };
            var countElement = names.Count();
            return countElement;
        }
        public int CountElementCollection()
        {
            int[] numbers = { 2, 3, 5, 6, 9, 6, 5, 7 };
            var countElement = numbers.Count();
            return countElement;
        }

        public float AverageCollection()
        {
            int[] numbers = { 2, 3, 5, 6, 9, 6, 5, 7 };
            float averageElement = (float)numbers.Average();
            return averageElement;
        }

        public string ElementAt_StringCollection()
        {
            string[] names = { "Anna", "Artyom", "Alexandr", "Irina", "Alexey" };
            var elementPosition = names.ElementAt(3);
            return elementPosition;
        }
        public int ElementAt_Collection()
        {
            int[] numbers = { 2, 3, 5, 6, 9, 6, 5, 7 };
            var elementPosition = numbers.ElementAt(5);
            return elementPosition;
        }

        public bool ElementAtOrDefault_Collection()
        {
            string[] names = { "Anna", "Artyom", "Alexandr", "Irina", "Alexey" };
            var elementPosition = names.ElementAtOrDefault(3);
            var isNull = elementPosition == null;
            return isNull;
        }
        public string ElementAtOrDefault_StringCollection()
        {
            string[] names = { "Anna", "Artyom", "Alexandr", "Irina", "Alexey" };
            var elementPosition = names.ElementAtOrDefault(3);
            return elementPosition;
        }

        public int FirstElementCollection()
        {
            var rand = new Random();
            int[] number = new int[10];
            for (int ctr = 0; ctr <= 10; ctr++)
            {
                Console.Write("{0,10:N0}", rand.Next(1, 50));
            }

            var firstElement = number.First();
            return firstElement;
        }

        public string FirstElementConditionalCollection()
        {
            string[] names = { "Anna", "Artyom", "Alexandr", "Irina", "Alexey" };
            var condition = names.First(c => c.Contains("t"));
            //condition = names.First(p => p.StartsWith("I"));
            //condition = names.First(p => p.Length==4);
            return condition;
        }

        public int FirstOrDefaultElementCollection()
        {
            var rand = new Random();
            int[] number = new int[10];
            for (int ctr = 0; ctr <= 10; ctr++)
            {
                Console.Write("{0,10:N0}", rand.Next(1, 50));
            }

            var firstElement = number.FirstOrDefault();
            return firstElement;
        }

        public int LastElementCollection()
        {
            var rand = new Random();
            int[] number = new int[10];
            for (int ctr = 0; ctr <= 10; ctr++)
            {
                Console.Write("{0,10:N0}", rand.Next(1, 50));
            }

            var lastElement = number.Last();
            return lastElement;
        }

        public bool LasrOrDefaultCollection()
        {
            int[] numbers = new int[10];
            var lastElement = numbers.LastOrDefault();
            return lastElement == null;
        }

        public bool LasrOrDefaultConditionalCollection()
        {
            string[] names = { "Anna", "Artyom", "Alexandr", "Irina", "Alexey" };
            var lastElement = names.LastOrDefault(p => p.Length == 5);
            return lastElement == null;
        }

        public void SingleCollection()
        {
            string[] names = { "Anna", "Artyom", "Alexandr", "Irina", "Alexey" };

            try
            {
                var singleElement = names.Single();
            }
            catch (Exception)
            {

                Console.WriteLine("В коллекции содержится больше, чем один элемент");
            }
        }

        public void SingleElementCollection()
        {
            string[] names = { "Programmer" };

            try
            {
                var singleElement = names.Single();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public void SingleNullCollection()
        {
            string[] names = { };

            try
            {
                var singleElement = names.Single();
            }
            catch (Exception)
            {

                Console.WriteLine("В коллекции не содержится ни одного элемента");
            }
        }

        //Order By
        public void OrderBySmpleNumbersCollection()
        {
            int[] numbers = { 2, 3, 5, 6, 9, 6, 5, 7 };
            numbers.OrderBy(n => n);
        }

        public void DateTimeCollection()
        {
            var date = new DateTime[]
            {
                new DateTime(2020,02,14),
                new DateTime(2020, 05, 02),
                new DateTime(2020, 08, 22)
            };
            date.GroupBy(n => n);
        }

        public void OrderByDescendingStringCollection()
        {
            string[] names = { "Anna", "Artyom", "Alexandr", "Irina", "Alexey" };
            names.OrderByDescending(p => p);
        }
        public void OrderByDescendingCollection()
        {
            int[] numbers = { 2, 3, 5, 6, 9, 6, 5, 7 };
            numbers.OrderByDescending(p => p);
        }

    }
}
