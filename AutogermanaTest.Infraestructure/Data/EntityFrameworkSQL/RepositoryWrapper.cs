using AutogermanaTest.Core.Interfaces.Repositories;
using AutogermanaTest.Infraestructure.Data.EntityFrameworkSQL.Repositories;
using System;

namespace AutogermanaTest.Infraestructure.Data.EntityFrameworkSQL
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        public IProductRepository productRepository;
        public ICategoryRepository categoryRepository;

        private readonly RepositoryContextSqlServer _repositoryContextSqlServer;

        public RepositoryWrapper(RepositoryContextSqlServer repositoryContextSqlServer)
        {
            _repositoryContextSqlServer = repositoryContextSqlServer ?? throw new ArgumentNullException(nameof(repositoryContextSqlServer));
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (productRepository == null)
                    return productRepository = new ProductRepository(_repositoryContextSqlServer);
                return productRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                    return categoryRepository = new CategoryRepository(_repositoryContextSqlServer);
                return categoryRepository;
            }
        }
    }
}
