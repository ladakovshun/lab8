using WebApplication8.Models;
using System.Collections.Generic;

namespace WebApplication8.Services

{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
