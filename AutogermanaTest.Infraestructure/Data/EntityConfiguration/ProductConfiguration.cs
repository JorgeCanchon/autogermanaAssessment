using AutogermanaTest.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutogermanaTest.Infraestructure.Data.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("producto", "dbo");
            entityTypeBuilder.HasKey(propiedad => new { propiedad.ID });
            entityTypeBuilder.Property(propiedad => propiedad.ID).HasColumnName("idproducto");
            entityTypeBuilder.Property(propiedad => propiedad.CodigoCategoria).HasColumnName("idcategoria");
            entityTypeBuilder.Property(propiedad => propiedad.Codigo).HasColumnName("codigo");
            entityTypeBuilder.Property(propiedad => propiedad.Nombre).HasColumnName("nombre");
            entityTypeBuilder.Property(propiedad => propiedad.PrecioVenta).HasColumnName("precio_venta");
            entityTypeBuilder.Property(propiedad => propiedad.Stock).HasColumnName("stock");
            entityTypeBuilder.Property(propiedad => propiedad.Descripcion).HasColumnName("descripcion");
            entityTypeBuilder.Property(propiedad => propiedad.Imagen).HasColumnName("imagen");
            entityTypeBuilder.Property(propiedad => propiedad.Estado).HasColumnName("estado").HasDefaultValue(true);

        }
    }
}
