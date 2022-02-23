using AutogermanaTest.Core.Entities;
using AutogermanaTest.Core.Interfaces.Repositories;
using AutogermanaTest.Core.Interfaces.UsesCases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutogermanaTest.Core.UsesCases
{
    public class ProductInteractor : IProductInteractor
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductInteractor(IRepositoryWrapper repositoryWrapper)
        {
            var _repositoryWrapper = repositoryWrapper ?? throw new ArgumentNullException(nameof(repositoryWrapper));
            _productRepository = _repositoryWrapper.ProductRepository;
            _categoryRepository = _repositoryWrapper.CategoryRepository;
        }

        public bool DeleteProduct(int id)
        {
            var product = GetProductById(id);
            product.SetEstado(false);
            return UpdateProduct(product);
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.FindByCondition(item => item.Estado).ToList();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.FindByCondition(item => item.ID == id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return _productRepository.FindByCondition(item => item.Estado).Include(x => x.Category).ToList();
        }

        public bool InsertProduct(Product product)
        {
            var response = _productRepository.Create(product);
            return response.ID > 0;
        }

        public bool UpdateProduct(Product product)
        {
            product.SetEstado(true);
            return EntityState.Modified == _productRepository.Update(product, "ID");
        }
    }
}
