using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace clothes_backend.Entities.Dal
{
    public class Stock
    {
        public int productID { get; set; }
        public int attriID { get; set; }


        public Product? product { get; set; }
        public Attri? attri { get; set; }


    }

    public class StockConfig : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> b)
        {
            b.ToTable("Stock");
            b.HasKey(x => new { x.productID, x.attriID });

            b.HasOne(t=>t.product)
                .WithMany(x=>x.stocks)
                .HasForeignKey(t=>t.productID)
                .HasPrincipalKey(x=>x.id)
                .OnDelete(DeleteBehavior.Cascade);
            b.HasOne(t => t.attri)
                .WithMany(x => x.stocks)
                .HasForeignKey(t => t.attriID)
                .HasPrincipalKey(x => x.id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
