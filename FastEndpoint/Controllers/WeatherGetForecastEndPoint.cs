using FastEndpoints;

namespace FastEndpoint.Controllers;

public class WeatherGetForecastEndPoint : EndpointWithoutRequest<string>
{
    public override void Configure()
    {
        Get("/WeatherForecast/{id}");
        AllowAnonymous();
    }
    public override async Task HandleAsync(CancellationToken ct)
    {
        var cityId = Route<string>("id");
        await SendAsync($"City Id :{cityId}", cancellation: ct);
    }
}
