using AIAgentTest1.Models;

namespace AIAgentTest1.Helpers
{
    public static class WeatherCodeHelper
    {
        /// <summary>
        /// Converts the numeric weather code from the API to the WeatherCode enum
        /// </summary>
        /// <param name="code">Weather code</param>
        /// <returns>Weather enum</returns>
        public static WeatherCode? FromInt(int code)
        {
            return Enum.IsDefined(typeof(WeatherCode), code)
                ? (WeatherCode)code
                : null;
        }

        /// <summary>
        /// Returns a human-readable English description for the specified weather code
        /// </summary>
        /// <param name="code">Weather enum code</param>
        /// <returns>Weather description</returns>
        public static string GetDescription(WeatherCode code)
        {
            return code switch
            {
                WeatherCode.ClearSky => "Clear sky",
                WeatherCode.MainlyClear => "Mainly clear",
                WeatherCode.PartlyCloudy => "Partly cloudy",
                WeatherCode.Overcast => "Overcast",
                WeatherCode.Fog => "Fog",
                WeatherCode.DepositingRimeFog => "Depositing rime fog",
                WeatherCode.LightDrizzle => "Light drizzle",
                WeatherCode.ModerateDrizzle => "Moderate drizzle",
                WeatherCode.DenseDrizzle => "Dense drizzle",
                WeatherCode.LightFreezingDrizzle => "Light freezing drizzle",
                WeatherCode.DenseFreezingDrizzle => "Dense freezing drizzle",
                WeatherCode.SlightRain => "Slight rain",
                WeatherCode.ModerateRain => "Moderate rain",
                WeatherCode.HeavyRain => "Heavy rain",
                WeatherCode.LightFreezingRain => "Light freezing rain",
                WeatherCode.HeavyFreezingRain => "Heavy freezing rain",
                WeatherCode.SlightSnowFall => "Slight snowfall",
                WeatherCode.ModerateSnowFall => "Moderate snowfall",
                WeatherCode.HeavySnowFall => "Heavy snowfall",
                WeatherCode.SnowGrains => "Snow grains or ice crystals",
                WeatherCode.SlightRainShowers => "Slight rain showers",
                WeatherCode.ModerateRainShowers => "Moderate rain showers",
                WeatherCode.ViolentRainShowers => "Violent rain showers",
                WeatherCode.SlightSnowShowers => "Slight snow showers",
                WeatherCode.HeavySnowShowers => "Heavy snow showers",
                WeatherCode.ThunderstormSlightOrModerate => "Thunderstorm: slight or moderate",
                WeatherCode.ThunderstormWithSlightHail => "Thunderstorm with slight hail",
                WeatherCode.ThunderstormWithHeavyHail => "Thunderstorm with heavy hail",
                _ => "Unknown weather condition"
            };
        }
    }
}
