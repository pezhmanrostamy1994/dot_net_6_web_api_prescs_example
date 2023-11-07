using EMR.DbContexts;
using EMR.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.  
builder.Services.AddProjectServices();
builder.Services.AddDbContext<EmrDbContext>(options =>
           {
              options.UseSqlite(builder.Configuration["ConnectionStrings:SqlLiteConnectionString"]);
           });
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwaggerDocumentation(app.Environment)
   .UseMiddlewareConfiguration()
   .UseEndpointsConfiguration();

app.Run();
