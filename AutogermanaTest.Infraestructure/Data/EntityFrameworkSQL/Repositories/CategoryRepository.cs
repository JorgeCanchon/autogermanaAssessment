using AutogermanaTest.Core.Entities;
using AutogermanaTest.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutogermanaTest.Infraestructure.Data.EntityFrameworkSQL.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        private readonly RepositoryContextSqlServer _repositoryContextSqlServer;

        public CategoryRepository(RepositoryContextSqlServer repositoryContextSqlServer)
            : base(repositoryContextSqlServer)
        {
            _repositoryContextSqlServer = repositoryContextSqlServer ?? throw new ArgumentNullException(nameof(repositoryContextSqlServer));
        }
    }
}
