using System.Text.Json;
using AIAgentTest1.Models;

namespace AIAgentTest1.Services
{
    public class CoordinatesService
    {
        /// <summary>
        /// Service that solve location name to GPS coordinates
        /// </summary>
        /// <param name="location">Location name</param>
        /// <returns>Coordinates</returns>
        public static async Task<Coordinates?> GetCoordinatesAsync(string location)
        {
            string url = $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(location)}&count=1&language=it&format=json";

            using HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.GetAsync(url).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode) return null;

            string json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            GeoResponse? data = JsonSerializer.Deserialize<GeoResponse>(json, options);

            if (data?.results == null || data.results.Length == 0) return null;

            var r = data.results[0];
            return new Coordinates
            {
                Name = r.name,
                Country = r.country,
                Latitude = r.latitude,
                Longitude = r.longitude
            };
        }
    }
}
