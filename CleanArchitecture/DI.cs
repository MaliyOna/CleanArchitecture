using CleanArchitecture.Interface;

namespace CleanArchitecture.Web;

public static class DI
{
    public static void AddWebDI(this IServiceCollection services, string connectionString)
    {
        services.AddInfrastructureDI(connectionString);
    }
}
