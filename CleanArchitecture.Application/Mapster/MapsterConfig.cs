using CleanArchitecture.Enterprise.Entities;
using CleanArchitecture.Enterprise.Models;
using Mapster;

namespace CleanArchitecture.Application.Mapster;

internal static class MapsterConfig
{
    public static void Configure()
    {
        TypeAdapterConfig<FarmEntity, FarmModel>.NewConfig()
            .TwoWays();

        TypeAdapterConfig<CatEntity, CatModel>.NewConfig()
            .TwoWays();
    }
}
