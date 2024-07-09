using CleanArchitecture.Enterprise.Models;
using CleanArchitecture.Web.DTOs;
using Mapster;

namespace CleanArchitecture.Web.Mapster;

internal static class MapsterConfig
{
    public static void Configure()
    {
        TypeAdapterConfig<CatModel, CatDTO>.NewConfig()
            .TwoWays();

        TypeAdapterConfig<FarmModel, FarmDTO>.NewConfig()
            .TwoWays();
    }
}
