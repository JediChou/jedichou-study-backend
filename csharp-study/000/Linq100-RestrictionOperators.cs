using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStudy
{
    public partial class Linq100
    {
        #region Restriction Operators

        /// <summary>
        /// Linq100-example 1
        /// </summary>
        /// <returns></returns>
        public static int[] Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var query =
                from elt in numbers
                where elt < 5
                select elt;
            return query.ToArray();
        }

        /// <summary>
        /// Linq100-example 2
        /// </summary>
        /// <returns></returns>
        public static List<Product> Linq2()
        {
            var products = new List<Product>
                {
                    new Product("Beer", 20),
                    new Product("LaoGanMa", 0),
                    new Product("Pen", 0)
                };

            var query =
                from product in products
                where product.UnitIsStock == 0
                select product;

            return query.ToList();
        }

        /// <summary>
        /// Linq100-example 3
        /// </summary>
        /// <returns></returns>
        public static List<Product> Linq3()
        {
            var products = new List<Product>
                {
                    new Product("Beer", 20, 30),
                    new Product("LaoGanMa", 0, 20),
                    new Product("Pen", 0, 5)
                };

            var query =
                from product in products
                where product.UnitIsStock == 0 && product.Price > 5
                select product;

            return query.ToList();
        }

        public class Product
        {
            public string Name { get; set; }
            public int UnitIsStock { get; set; }
            public int Price { get; set; }

            public Product(string name, int unit)
            {
                Name = name;
                UnitIsStock = unit;
            }

            public Product(string name, int unit, int price)
            {
                Name = name;
                UnitIsStock = unit;
                Price = price;
            }
        }

        /// <summary>
        /// Linq100-example 4
        /// </summary>
        /// <returns></returns>
        public static List<Customer> Linq4()
        {
            var customer1 = new Customer("Factory", "Foxconn");
            customer1.AddOrder(new Order("10001", new DateTime(2015, 1, 2)));
            customer1.AddOrder(new Order("10002", new DateTime(2015, 1, 3)));

            var customer2 = new Customer("Provider", "Microsoft");
            customer2.AddOrder(new Order("10003", new DateTime(2015, 2, 2)));
            customer2.AddOrder(new Order("10004", new DateTime(2015, 2, 3)));

            var customers = new List<Customer>
                {
                    customer1,
                    customer2
                };

            var query =
                from customer in customers
                where customer.CompanyName == "Foxconn"
                select customer;

            return query.ToList();
        }

        public class Customer
        {
            public string CustomerId { get; set; }
            public string CompanyName { get; set; }
            public List<Order> Orders { get; set; }

            public Customer(string id, string name)
            {
                CustomerId = id;
                CompanyName = name;
                Orders = new List<Order>();
            }

            public void AddOrder(Order order)
            {
                if (order != null)
                    Orders.Add(order);
            }
        }

        public class Order
        {
            public string OrderId { get; set; }
            public DateTime OrderDate { get; set; }

            public Order(string id, DateTime date)
            {
                OrderId = id;
                OrderDate = date;
            }
        }

        /// <summary>
        /// Linq100-exmaple 5
        /// </summary>
        /// <returns></returns>
        public static string[] Linq5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var query = digits.Where((digit, index) => digit.Length < index);
            return query.ToArray();
        }

        #endregion
    }
}
