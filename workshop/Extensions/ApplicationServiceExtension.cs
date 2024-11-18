using Microsoft.EntityFrameworkCore;
using workshop.Entities;
using workshop.Interfaces;
using workshop.Repositories;
using workshop.Services;
using AutoMapper;
using workshop.Helpers;

namespace workshop.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<mvcPortalContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserServices, UserServices>();
            //services.AddScoped<IUserServices, UserServices>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            
            return services;
        }
    }
}
