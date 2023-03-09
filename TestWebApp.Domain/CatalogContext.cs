using Microsoft.EntityFrameworkCore;
using TestWebApp.Domain.Models;

namespace TestWebApp.Domain
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Catalog>()
                .Property(x => x.Id)
                .UseIdentityColumn();
            builder.Entity<Catalog>()
                .HasOne(x => x.Parent)
                .WithMany(x => x.Children)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Catalog>()
                .HasIndex(x => x.Path)
                .IsUnique();
        }

        public DbSet<Catalog> Catalogs => Set<Catalog>();
    }
}
