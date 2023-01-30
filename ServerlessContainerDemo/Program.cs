using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;
using NLog.Extensions.Logging;
using ServerlessContainerDemo.Auth;
using ServerlessContainerDemo.OpenAPI.Filters;
using NLog;
using NLog.Web;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Debug);
    builder.Host.UseNLog();

    builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.EnableAnnotations();
        c.SwaggerDoc("v1", new OpenApiInfo() {Title = "Serverless Container Demo", Version = "v1"});
        c.OperationFilter<YcExtensionsFilter>();
    });

    builder.Services.AddAuthentication("BasicAuthentication")
        .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>
            ("BasicAuthentication", null);
    builder.Services.AddAuthorization();


    var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
    builder.WebHost.UseKestrel(
        serverOptions => { serverOptions.ListenAnyIP(int.Parse(port)); });

    var app = builder.Build();

// Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

// app.UseHttpsRedirection();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}