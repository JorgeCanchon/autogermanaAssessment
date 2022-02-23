using AutogermanaTest.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutogermanaTest.Infraestructure.Data.EntityConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("categoria", "dbo");
            entityTypeBuilder.HasKey(propiedad => new { propiedad.ID });
            entityTypeBuilder.Property(propiedad => propiedad.ID).HasColumnName("idcategoria");
            entityTypeBuilder.Property(propiedad => propiedad.Nombre).HasColumnName("nombre");
            entityTypeBuilder.Property(propiedad => propiedad.Descripcion).HasColumnName("descripcion");
            entityTypeBuilder.Property(propiedad => propiedad.Estado).HasColumnName("estado");
        }
    }
}
