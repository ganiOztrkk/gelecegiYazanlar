using CampingApp.Infrastructure.data;
using CampingApp.Infrastructure.repositories;
using CampingApp.Infrastructure.Repositories;
using CampingApp.Services;
using Microsoft.EntityFrameworkCore;

namespace CampingApp.Mvc.extensions
{
    public static class IocExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<IUserRepository, EfUserRepository>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
