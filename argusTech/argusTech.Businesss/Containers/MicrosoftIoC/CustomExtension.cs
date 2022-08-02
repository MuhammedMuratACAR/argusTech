using argusTech.Business.Concrete;
using argusTech.Business.Interfaces;
using argusTech.Business.ValidationRules.FluentValidation;
using argusTech.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using argusTech.DataAccess.Interfaces;
using argusTech.DTO.DTOs.UserDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace argusTech.Business.Containers.MicrosoftIoC
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserRepository>();

            services.AddTransient<IValidator<UserAddDto>, UserAddValidator>();
        }
    }
}
