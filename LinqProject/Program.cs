﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catgeory> categories = new List<Catgeory>
            {
                new Catgeory{CategoryId=1, CategoryName="Bilgisayar"},
                new Catgeory{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=1000, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="ASUS Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitsInStock=6},
                new Product{ProductId=4, CategoryId=2, ProductName="SAMSUMG Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=6000, UnitsInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="APPLE Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };


            Console.WriteLine("*******************Algoritmik********************");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock>3)
                {
                    Console.WriteLine(product.ProductName);
                }
                
            }

            Console.WriteLine("**********************LINQ***********************");
            
            // LINQ
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("**********************GetProducts***********************");

            
            var list= GetProducts(products);
            foreach (var item in list)
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("******************GetProductsLinq*******************");

            var linq=GetProductsLinq(products);
            foreach (var item in linq)
            {
                Console.WriteLine(item.ProductName);
            }


        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }

            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList(); 
        }
    }
}
