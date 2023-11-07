namespace EMR.Extensions;

using EMR.Services;
using EMR.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;


public static class ServiceExtensions
{
    // Configure CORS
    public static IServiceCollection AddCorsConfiguration(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin()
                                  .AllowAnyMethod()
                                  .AllowAnyHeader());
        });

        return services;
    }
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new ApiVersion(1, 0); // ورژن پیش‌فرض
            options.AssumeDefaultVersionWhenUnspecified = true; // استفاده از ورژن پیش‌فرض اگر ورژن مشخص نشده باشد
            options.ReportApiVersions = true; // گزارش ورژن‌های موجود در پاسخ‌ها
            options.ApiVersionReader = new UrlSegmentApiVersionReader(); // خواندن ورژن از URL
        });

    }

    // Configure dependency injection for your services
    public static IServiceCollection AddDependencyInjectionSetup(this IServiceCollection services)
    {
        // AddScoped, AddTransient, or AddSingleton services here
        services.AddScoped<IInsuranceService, InsuranceService>();

        return services;
    }

}

