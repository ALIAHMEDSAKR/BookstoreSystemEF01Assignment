using BookstoreSystemEF01Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreSystemEF01Assignment.Configurations
{
    internal class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                    .Property(b => b.Title)
                    .IsRequired()
                    .HasMaxLength(150);
            builder
                    .Property(b => b.Price)
                    .HasColumnType("decimal(8,2)");
            builder
                    .Property(b => b.PublishedDate)
                    .IsRequired(false);
        }
    }
}
