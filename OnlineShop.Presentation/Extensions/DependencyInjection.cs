using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Application;
using OnlineShop.Infrastructure;

namespace OnlineShop.Presentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            // Add DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Add services
            services.AddScoped<ICategoryService, CategoryService>();
            //services.AddScoped<IErrorLogService, ErrorLogService>();

            //// Add repositories
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IErrorLogRepository, ErrorLogRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Add logging
            services.AddLogging(logging => logging.AddConsole());

            

            return services;
        }
    }
}