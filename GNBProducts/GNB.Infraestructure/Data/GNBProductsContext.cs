using GNB.AppCore.Entities;
using GNB.Infraestructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GNB.Infraestructure.Data
{
    public class GNBProductsContext : DbContext
    {
        public GNBProductsContext(DbContextOptions<GNBProductsContext> options) : base(options)
        {
        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<EfTransaction> Transactions { get; set; }
        public DbSet<EfCurrencyExchange> Rates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
