using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Enterprise.Entities;
using CleanArchitecture.Enterprise.Models;
using CleanArchitecture.Infrastructure.Repositories;
using CleanArchitecture.Interface;
using CleanArchitecture.Web.Mapster;
using Mapster;

namespace CleanArchitecture.Web;

public static class DI
{
    public static void AddWebDI(this IServiceCollection services, string connectionString)
    {
        services.AddMapster();
        MapsterConfig.Configure();

        services.AddScoped<IGenericRepository<CatEntity>, GenericRepository<CatEntity>>();
        services.AddScoped<IGenericRepository<FarmEntity>, GenericRepository<FarmEntity>>();

        services.AddScoped<IGenericService<CatModel>, GenericService<CatModel, CatEntity>>();
        services.AddScoped<IGenericService<FarmModel>, GenericService<FarmModel, FarmEntity>>();

        services.AddInfrastructureDI(connectionString);
    }
}
