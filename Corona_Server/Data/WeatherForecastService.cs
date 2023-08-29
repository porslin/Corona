// this is the class file that is returning the data 
namespace Corona_Server.Data
{
    public class WeatherForecastService
    {
        // creating an array of string with different weathers
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        // calling the getweather forecast based on the datetime in the parameter, it creates a new weather forecast object and it creates 5 obj, returns them  and randomly selects on of the summaries 
        // so the return type here is an array of the weatherforecast class which has the properties as stated in that class
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}