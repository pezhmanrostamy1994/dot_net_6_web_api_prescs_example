namespace EMR.Extensions;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        return app;
    }

    public static IApplicationBuilder UseMiddlewareConfiguration(this IApplicationBuilder app)
    {
        // Add middleware configurations here
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();

        // Any other middlewares
        return app;
    }

    public static IApplicationBuilder UseEndpointsConfiguration(this IApplicationBuilder app)
    {
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            // Map other endpoints if needed
        });

        return app;
    }
}

