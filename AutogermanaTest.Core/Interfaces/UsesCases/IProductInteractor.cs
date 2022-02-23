using AutogermanaTest.Core.Entities;
using System.Collections.Generic;

namespace AutogermanaTest.Core.Interfaces.UsesCases
{
    public interface IProductInteractor
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        bool InsertProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
        List<Category> GetCategories();
    }
}
