using AutogermanaTest.Core.Entities;
using AutogermanaTest.Infraestructure.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutogermanaTest.Infraestructure.Data.EntityFrameworkSQL
{
    public class RepositoryContextSqlServer : DbContext
    {
        public RepositoryContextSqlServer()
        {

        }

        public RepositoryContextSqlServer(DbContextOptions options)
            : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            if (modelBuilder != null)
            {
                modelBuilder.HasAnnotation("Sqlite:Autoincement", true)
                    .HasAnnotation("MySql:ValueGeneratedOnAdd", true)
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
               
                modelBuilder.Entity<Category>()
                    .HasOne(p => p.Product)
                    .WithOne(c => c.Category)
                    .HasForeignKey<Product>(p => p.CodigoCategoria);

                modelBuilder.ApplyConfiguration(new ProductConfiguration());
                modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            }
        }
    }
}
