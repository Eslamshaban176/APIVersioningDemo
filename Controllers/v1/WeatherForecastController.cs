using Microsoft.AspNetCore.Mvc;

namespace APIVersionDemo.Controllers.v1;

[ApiController]
[Route("api/[controller]")]
[ApiVersion("1.0")]
//[ApiVersion("1.0", Deprecated = true)]
public class WeatherForecastController : ControllerBase
{
        [HttpGet]
        public string Get() => "This is Data From version 1.0";
}
