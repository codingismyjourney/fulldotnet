using ConECommerce.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ConECommerce.Model;

namespace ConECommerce.dataapp
{
    class productmanagement
    {
        public void AddProduct()
        {
            ConECommerceContext context = new ConECommerceContext();

            Product obj_Product = new Product();

            Console.WriteLine("Please Add Product's Name : - ");
            obj_Product.Name = Console.ReadLine();

            Console.WriteLine("Please Add Product's Price : - ");
            obj_Product.Price = Convert.ToInt16(Console.ReadLine());

            context.Add(obj_Product);
            context.SaveChanges();
        }

        public void DisplayProduct()
        {
            ConECommerceContext context = new ConECommerceContext();


            var products = context.Products;

            foreach (Product p in products)
            {
                Console.WriteLine("Product Id = {0}", p.Id);
                Console.WriteLine("Product Name = {0}", p.Name);
                Console.WriteLine("Product Price = {0}", p.Price);
            }
        }

        public void UpDateProduct()
        {
            ConECommerceContext context = new ConECommerceContext();

            var product = context.Products.Single(p => p.Name == "Parle G");

            product.Price = 50;

            context.SaveChanges();

            DisplayProduct();
        }

        public void RemoveData()
        {
            ConECommerceContext context = new ConECommerceContext();

            var product = context.Products.Single(p => p.Id == 6);

            context.Remove(product);

            context.SaveChanges();

            DisplayProduct();
        }

    }
}
