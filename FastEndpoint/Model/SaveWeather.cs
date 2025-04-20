using FastEndpoints;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace FastEndpoint.Model
{
    public class SaveWeather
    {
        public string CityName { get; set; }
        public int CityId { get; set; }
        public int Degree { get; set; }
    }
    public class SaveWeatherValidator : Validator<SaveWeather>
    {
        public void CreateWeatherValidator()
        {
            RuleFor(q => q.CityName).NotEmpty()
                .WithMessage("City name has not defined");
            RuleFor(q => q.CityId).NotEmpty()
                .WithMessage("City id has not defined");
            RuleFor(q => q.Degree).NotEmpty()
                .WithMessage("weather degree has not defined");
        }
    }
}
