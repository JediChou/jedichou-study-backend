// File: MockDatabaseRepositoryUsingMoq.cs 
// Description: How to use Moq to execute unit test.


using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqRepositorySample;

namespace MoqRepositorySample
{
    public interface IProductRepository
    {
        IList<Product> FindAll();
        Product FindByName(string productName);
        Product FindById(int productId);
        bool Save(Product target);
    }
	
	public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}

namespace MoqRepositoryTest
{
    /// <summary>
    /// ProductRepositoryTest 的摘要说明
    /// </summary>
    [TestClass]
    public class ProductRepositoryTest
    {
        ///<summary>
        /// Our Mock Products Repository for use in testing
        ///</summary>
        public readonly IProductRepository MockProductsRepository;

        /// <summary>
        /// 获取或设置测试上下文，该上下文提供
        /// 有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// 测试用例的构造函数，又来生成一个预定义的数据集合
        /// </summary>
        public ProductRepositoryTest()
        {
            // Create some mock products to play with
            IList<Product> products = new List<Product>
                {
                    new Product { ProductId = 1, Name = "C# Unleashed", Description = "Short description here", Price = 49.99},
                    new Product { ProductId = 2, Name = "ASP.Net Unleashed", Description = "Short description here", Price = 59.99},
                    new Product { ProductId = 3, Name = "Silverlight Unleashed", Description = "Short description here", Price = 29.99}
                };

            // Mock the Products Repository using Moq
            var mockProductRepository = new Mock<IProductRepository>();

            // Return all the products
            mockProductRepository.Setup(mr => mr.FindAll()).Returns(products);

            // return a product by Id
            mockProductRepository.Setup(mr => mr.FindById(It.IsAny<int>())).Returns((int i) => products.Single(x => x.ProductId == i));

            // return a product by Name
            mockProductRepository.Setup(mr => mr.FindByName(It.IsAny<string>())).Returns((string s) => products.Single(x => x.Name == s));

            // Allows us to test saving a product
            mockProductRepository.Setup(mr => mr.Save(It.IsAny<Product>())).Returns(
                (Product target) =>
                {
                    var now = DateTime.Now;

                    if (target.ProductId.Equals(default(int)))
                    {
                        target.DateCreated = now;
                        target.DateModified = now;
                        target.ProductId = products.Count() + 1;
                        products.Add(target);
                    }
                    else
                    {
                        var original = products.Single(q => q.ProductId == target.ProductId);

                        if (original == null)
                        {
                            return false;
                        }

                        original.Name = target.Name;
                        original.Price = target.Price;
                        original.Description = target.Description;
                        original.DateModified = now;
                    }

                    return true;
                });

            // Complete the setup of our Mock Product Repository
            MockProductsRepository = mockProductRepository.Object;
        }

        ///<summary>
        /// Can we return a product By Id?
        ///</summary>
        [TestMethod]
        public void CanReturnProductById()
        {
            // Try finding a product by id
            var testProduct = MockProductsRepository.FindById(2);
            Assert.IsNotNull(testProduct); // Test if null
            Assert.IsInstanceOfType(testProduct, typeof(Product)); // Test type
            Assert.AreEqual("ASP.Net Unleashed", testProduct.Name); // Verify it is the right product
        }

        ///<summary>
        /// Can we return a product By Name?
        ///</summary>
        [TestMethod]
        public void CanReturnProductByName()
        {
            // Try finding a product by Name
            var testProduct = MockProductsRepository.FindByName("Silverlight Unleashed");
            Assert.IsNotNull(testProduct); // Test if null
            Assert.IsInstanceOfType(testProduct, typeof(Product)); // Test type
            Assert.AreEqual(3, testProduct.ProductId); // Verify it is the right product
        }

        ///<summary>
        /// Can we return all products?
        ///</summary>
        [TestMethod]
        public void CanReturnAllProducts()
        {
            // Try finding all products
            var testProducts = MockProductsRepository.FindAll();
            Assert.IsNotNull(testProducts); // Test if null
            Assert.AreEqual(3, testProducts.Count); // Verify the correct Number
        }

        ///<summary>
        /// Can we insert a new product?
        ///</summary>
        [TestMethod]
        public void CanInsertProduct()
        {
            // Create a new product, not I do not supply an id
            var newProduct = new Product { Name = "Pro C#", Description = "Short description here", Price = 39.99 };

            var productCount = MockProductsRepository.FindAll().Count;
            Assert.AreEqual(3, productCount); // Verify the expected Number pre-insert

            // try saving our new product
            MockProductsRepository.Save(newProduct);

            // demand a recount
            productCount = MockProductsRepository.FindAll().Count;
            Assert.AreEqual(4, productCount); // Verify the expected Number post-insert

            // verify that our new product has been saved
            Product testProduct = MockProductsRepository.FindByName("Pro C#");
            Assert.IsNotNull(testProduct); // Test if null
            Assert.IsInstanceOfType(testProduct, typeof(Product)); // Test type
            Assert.AreEqual(4, testProduct.ProductId); // Verify it has the expected productid
        }

        ///<summary>
        /// Can we update a prodict?
        ///</summary>
        [TestMethod]
        public void CanUpdateProduct()
        {
            // Find a product by id
            var testProduct = MockProductsRepository.FindById(1);

            // Change one of its properties
            testProduct.Name = "C# 3.5 Unleashed";

            // Save our changes.
            MockProductsRepository.Save(testProduct);

            // Verify the change
            Assert.AreEqual("C# 3.5 Unleashed", MockProductsRepository.FindById(1).Name);
        }
    }
}