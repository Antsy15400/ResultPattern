using Francisvac.Result;

using Microsoft.AspNetCore.Mvc;
using ResultSample.Services;

namespace ResultSample.Controllers;

[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly WeatherForcastService _service;

    public WeatherForecastController(WeatherForcastService service) => _service = service;

    [HttpGet("{quantity}")]
    public ActionResult Get(int quantity) => _service.GetWeatherForecast(quantity).ToActionResult();
}
