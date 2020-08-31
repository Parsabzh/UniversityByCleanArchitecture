using System;
using System.Collections.Generic;
using System.Text;
using Clean.Architecture.Application.Interfaces;
using Clean.Architecture.Application.Services;
using Clean.Architecture.Domain.Interfaces;
using Clean.Architecture.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.Architecture.Infrastructure.IoC
{
   public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<ICourseService, CourseService>();
            service.AddScoped<IUserService, UserService>();

            //Infrastructure Data Layer
            service.AddScoped<ICourseRepository, CourseRepository>();

            service.AddScoped<IUserRepository, IUserRepository>();
        }
    }
}
