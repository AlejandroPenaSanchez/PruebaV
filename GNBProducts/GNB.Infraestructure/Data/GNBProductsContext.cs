using GNB.AppCore.Entities;
using GNB.AppCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GNB.Infraestructure.Data
{
    public class GNBProductsContext : DbContext
    {
        public GNBProductsContext(DbContextOptions<GNBProductsContext> options) : base(options)
        {
        }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ITransaction> Transactions { get; set; }
        public DbSet<ICurrencyExchange> Rates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
