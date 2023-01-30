using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ServerlessContainerDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class RandomController : ControllerBase
{
    private readonly ILogger<RandomController> _logger;

    public RandomController(ILogger<RandomController> logger)
    {
        _logger = logger;
    }

    [Authorize]
    [HttpGet(Name = "GetRandom")]
    public long Get()
    {
        var value = new Random().NextInt64();
        var reminder = new Random().Next() % 10;
        using (_logger.BeginScope("Value {value}", value, reminder))
        {
            if (value % 10 == reminder)
            {
                throw new Exception("Random exception");
            }

            _logger.LogInformation("valid value");
        }

        return value;
    }
}