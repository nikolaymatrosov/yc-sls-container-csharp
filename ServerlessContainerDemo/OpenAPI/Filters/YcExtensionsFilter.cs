using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ServerlessContainerDemo.OpenAPI.Filters;

public class YcExtensionsFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Extensions.Add("x-yc-apigateway-integration", new OpenApiObject()
        {
            ["type"] = new OpenApiString("serverless_containers"),
            ["container_id"] = new OpenApiString("${container_id}"),
            ["service_account_id"] = new OpenApiString("${container_service_account_id}"),
        });
    }
}