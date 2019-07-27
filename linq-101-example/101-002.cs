using System; using System.Linq; 
using System.Collections.Generic;
class P { static void Main() {
	var products = new List<Product>();
	products.Add(new Product(1));
	products.Add(new Product(2));
	products.Add(new Product(3));
	products.Add(new Product(4));
	products.Add(new Product(5));

	// This sample uses where to find all products
	// that are out of stock.
	var results = 
		from product in products
		where product.UnitsInStock == 3
		select product;

	foreach(var elt in results)
		Console.WriteLine(elt + ", " + elt.UnitsInStock);
}}
class Product {
	public int UnitsInStock;
	public Product(int unit) { UnitsInStock = unit; }
}
