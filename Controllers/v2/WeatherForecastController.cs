using Microsoft.AspNetCore.Mvc;

namespace APIVersionDemo.Controllers.v2;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("2.0")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public string Get() => "This is Data From version 2.0";
}
