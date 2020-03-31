using GNB.AppCore.Entities;
using GNB.AppCore.Interfaces;
using GNB.AppCore.Services;
using GNB.Infraestructure.Data;
using GNB.Infraestructure.Data.Entities;
using GNB.Infraestructure.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GNBProducts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            // use in-memory database
            ConfigureInMemoryDatabases(services);

            // use real database
            //ConfigureProductionServices(services);
        }

        private void ConfigureInMemoryDatabases(IServiceCollection services)
        {
            // use in-memory database
            services.AddDbContext<GNBProductsContext>(context =>
                context.UseInMemoryDatabase("GNBProducts"));

            ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.Configure<DbInitializerSettings>(Configuration.GetSection("DbInitializerSettings"));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped(typeof(IRepository<IBaseEntity>), typeof(EfRepository<BaseEntity>));
            services.AddScoped(typeof(IRepository<ITransaction>), typeof(EfRepository<EfTransaction>));
            services.AddScoped(typeof(IRepository<ICurrencyExchange>), typeof(EfRepository<EfCurrencyExchange>));
            services.AddScoped<ICurrencyExchange, EfCurrencyExchange>();
            services.AddScoped<ITransaction, EfTransaction>();
            services.AddScoped<ICurrency, Currency>();
            services.AddScoped<ICurrencyExchangeService, CurrencyExchangeService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<DataBaseInitializer>();





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
