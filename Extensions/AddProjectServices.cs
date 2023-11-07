
namespace EMR.Extensions;

public static class ProjectServiceExtensions
{
    // Existing extension methods...

    public static IServiceCollection AddProjectServices(this IServiceCollection services)
    {
        services.AddControllers()
        .AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        })
        .AddNewtonsoftJson();//AddNewtonsoftJson replace wit .netJson

        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        // Add CORS configuration
        services.AddCorsConfiguration();

        // Configure API Versioning
        ServiceExtensions.ConfigureServices(services);

        // Add dependency injection setup
        services.AddDependencyInjectionSetup();

        // Add any other services that your application needs

        return services;
    }
}

