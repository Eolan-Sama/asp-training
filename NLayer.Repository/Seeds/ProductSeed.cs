using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Price = 100, Stock = 20 , CreatedDate = DateTime.Now , Name = "Uclu Kalem"  },
                new Product { Id = 2, CategoryId = 1, Price = 200, Stock = 30, CreatedDate = DateTime.Now, Name = "Tukenmez Kalem" },
                new Product { Id = 3, CategoryId = 1, Price = 450, Stock = 12, CreatedDate = DateTime.Now, Name = "Pilot Kalem" },
                new Product { Id = 4, CategoryId = 2, Price = 300, Stock = 45, CreatedDate = DateTime.Now, Name = "Karamazov Kardesler" }, 
                new Product { Id = 5, CategoryId = 2, Price = 450, Stock = 35, CreatedDate = DateTime.Now, Name = "Satranc" }, 
                new Product { Id = 6, CategoryId = 3, Price = 250, Stock = 60, CreatedDate = DateTime.Now, Name = "Cizgili Defter" }
            );
        }
    }
}
