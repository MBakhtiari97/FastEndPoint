using FastEndpoint.Model;
using FastEndpoints;

namespace FastEndpoint.Controllers;

public class WeatherForecastEndPoint : Endpoint<SaveWeather, string>
{
    public override void Configure()
    {
        Post("/WeatherForecast");
        AllowAnonymous();
    }
    public override async Task HandleAsync(SaveWeather weatherData, CancellationToken ct)
    {
        var cityId = Route<string>("id");
        await SendAsync($"City id :{weatherData.CityId} , City name :{weatherData.CityName} , Weather degree :{weatherData.Degree} ", cancellation: ct);
    }
}
