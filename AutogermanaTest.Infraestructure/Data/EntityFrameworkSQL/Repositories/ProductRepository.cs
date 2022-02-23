using AutogermanaTest.Core.Entities;
using AutogermanaTest.Core.Interfaces.Repositories;
using System;

namespace AutogermanaTest.Infraestructure.Data.EntityFrameworkSQL.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly RepositoryContextSqlServer _repositoryContextSqlServer;
        public ProductRepository(RepositoryContextSqlServer repositoryContextSqlServer)
            : base(repositoryContextSqlServer)
        {
            _repositoryContextSqlServer = repositoryContextSqlServer ?? throw new ArgumentNullException(nameof(repositoryContextSqlServer));
        }
    }
}
