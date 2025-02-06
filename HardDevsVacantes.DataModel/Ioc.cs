using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HardDevsVacantes.DataModel.Context;

namespace HardDevsVacantes.DataModel
{
	public static class Ioc
    {
        public static IServiceCollection AddDataModel(this IServiceCollection services, IConfiguration configuration)
        {
      
            services.AddDbContext<MainDbContext>(opt =>
                opt.UseSqlite(configuration.GetConnectionString("MainDatabase"),
                b => b.MigrationsAssembly("HardDevsVacantes.DataModel")));

            return services;


        }


    }
}


