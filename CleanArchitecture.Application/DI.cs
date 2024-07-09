using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Mapster;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Enterprise.Models;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class DI
{
    public static void AddApplicationDI(this IServiceCollection services)
    {
        MapsterConfig.Configure();
    }
}
