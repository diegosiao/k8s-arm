namespace Kubernetes.Sbc.Europe.Weather
{
    public class WeatherForecast
    {
        public string? Continent => "Europe";

        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
