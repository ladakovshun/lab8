using WebApplication8.Models;
using System;
using System.Collections.Generic;

namespace WebApplication8.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ID = 1, Name = "Phone Samsung Galaxy A31", Price = 599.99m, CreatedDate = DateTime.Now.AddDays(-10) },
                new Product { ID = 2, Name = "Headphones JBL710", Price = 199.99m, CreatedDate = DateTime.Now.AddDays(-5) },
                new Product { ID = 3, Name = "Case for Samsung Galaxy A31", Price = 29.99m, CreatedDate = DateTime.Now }
            };
        }
    }
}
