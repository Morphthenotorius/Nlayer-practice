using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolver
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessService(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();

            services.AddScoped<ICategoryDAL,EFCategoryDAL>();
            services.AddScoped<ICategoryService,CategoryManager>();
            return services;
        }
    }
}
