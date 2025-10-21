using System.ComponentModel;
using System.Text.Json;
using AIAgentTest1.Helpers;
using AIAgentTest1.Models;

namespace AIAgentTest1.Services
{
    public static class MeteoService
    {
        /// <summary>
        /// Service that call weather forecast API
        /// </summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lon">Longitude</param>
        /// <returns>Weather forecast of the location</returns>
        private static async Task<WeatherResponse?> GetCurrentWeatherAsync(double lat, double lon)
        {
            string url = $"https://api.open-meteo.com/v1/forecast?latitude={lat.ToString().Replace(',','.')}&longitude={lon.ToString().Replace(',', '.')}&current_weather=true";

            using HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.GetAsync(url).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode) return null;

            string json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            WeatherResponse? data = JsonSerializer.Deserialize<WeatherResponse>(json, options);

            return data;
        }

        /// <summary>
        /// Service that returns the weather of the input location
        /// </summary>
        /// <param name="location">Location</param>
        /// <returns>Weather of the location</returns>
        [Description("Get the weather for a given location.")]
        public static async Task<string> GetCurrentWeatherByCityAsync([Description("The location to get the weather for.")] string location)
        {
            var coordinates = await CoordinatesService.GetCoordinatesAsync(location).ConfigureAwait(false);

            if (coordinates == null)
            {
                return $"Location '{location}' not found.";
            }

            var weather = await GetCurrentWeatherAsync(coordinates.Latitude, coordinates.Longitude).ConfigureAwait(false);

            if(weather == null || weather.current_weather == null || weather.current_weather_units == null)
            {
                return "The weather for the location is not available";
            }

            var weatherText = $"The weather in {location} is {WeatherCodeHelper.GetDescription(weather.current_weather.WeatherCode)}, the temperature is {weather.current_weather.Temperature} {weather.current_weather_units.temperature} and the wind speed is {weather.current_weather.WindSpeed} {weather.current_weather_units.windspeed}.";

            return weatherText;            
        }

    }
}
