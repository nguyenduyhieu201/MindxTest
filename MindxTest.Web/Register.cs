using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MindxTest.Infrastructure.Infrastructure;
using MindxTest.Infrastructure.Repositories;
using MindxTest.Service.Service;

namespace MindxTest.Web
{
    public static class Register
    {
        public static void RegisterModule(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IDbFactory, DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IResumeRepository, ResumeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IResumeService, ResumeService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}