using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;
using ServerlessContainerDemo.Auth;
using ServerlessContainerDemo.OpenAPI.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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