using System;
using System.Collections.Generic;


namespace OOPExcercises
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string name, double price)
        {
            products.Add(new Product(name, price));
        }

        public void RemoveProduct(string name)
        {
            products.RemoveAll(product => product.Name == name);
        }

        public double TotalPrice()
        {
            double total = 0;
            foreach (var p in products)
                total += p.Price;
            return total;
        }
    }
}
