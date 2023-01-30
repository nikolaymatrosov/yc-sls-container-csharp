using NLog;

namespace ServerlessContainerDemo.Middleware;

using System.Net;
using System.Text.Json;

public class GlobalErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public GlobalErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        Logger log = LogManager.GetCurrentClassLogger();
        
        string message = exception.Message;
        string stackTrace = exception.StackTrace ?? String.Empty;


        var exceptionResult = JsonSerializer.Serialize(new {error = message, stackTrace});

        log.Error(exception, "global handler");

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = 500;

        return context.Response.WriteAsync(exceptionResult);
    }
}