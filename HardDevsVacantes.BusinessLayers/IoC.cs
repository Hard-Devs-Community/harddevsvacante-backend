using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using HardDevsVacantes.DataModel.Context;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HardDevsVacantes.BusinessLayers
{
	public static class IoC
	{

        public static IServiceCollection AddBusinnesLayers(this IServiceCollection services)
        {

            return services;

        }
       

    }
}

