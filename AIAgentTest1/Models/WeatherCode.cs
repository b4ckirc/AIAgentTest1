namespace AIAgentTest1.Models
{
    /// <summary>
    /// Weather codes according to Open-Meteo / WMO Weather Interpretation Codes.
    /// </summary>
    public enum WeatherCode
    {
        /// <summary>0 – Clear sky</summary>
        ClearSky = 0,

        /// <summary>1 – Mainly clear</summary>
        MainlyClear = 1,

        /// <summary>2 – Partly cloudy</summary>
        PartlyCloudy = 2,

        /// <summary>3 – Overcast</summary>
        Overcast = 3,

        /// <summary>45 – Fog</summary>
        Fog = 45,

        /// <summary>48 – Depositing rime fog</summary>
        DepositingRimeFog = 48,

        /// <summary>51 – Light drizzle</summary>
        LightDrizzle = 51,

        /// <summary>53 – Moderate drizzle</summary>
        ModerateDrizzle = 53,

        /// <summary>55 – Dense drizzle</summary>
        DenseDrizzle = 55,

        /// <summary>56 – Light freezing drizzle</summary>
        LightFreezingDrizzle = 56,

        /// <summary>57 – Dense freezing drizzle</summary>
        DenseFreezingDrizzle = 57,

        /// <summary>61 – Slight rain</summary>
        SlightRain = 61,

        /// <summary>63 – Moderate rain</summary>
        ModerateRain = 63,

        /// <summary>65 – Heavy rain</summary>
        HeavyRain = 65,

        /// <summary>66 – Light freezing rain</summary>
        LightFreezingRain = 66,

        /// <summary>67 – Heavy freezing rain</summary>
        HeavyFreezingRain = 67,

        /// <summary>71 – Slight snowfall</summary>
        SlightSnowFall = 71,

        /// <summary>73 – Moderate snowfall</summary>
        ModerateSnowFall = 73,

        /// <summary>75 – Heavy snowfall</summary>
        HeavySnowFall = 75,

        /// <summary>77 – Snow grains / ice crystals</summary>
        SnowGrains = 77,

        /// <summary>80 – Slight rain showers</summary>
        SlightRainShowers = 80,

        /// <summary>81 – Moderate rain showers</summary>
        ModerateRainShowers = 81,

        /// <summary>82 – Violent rain showers</summary>
        ViolentRainShowers = 82,

        /// <summary>85 – Slight snow showers</summary>
        SlightSnowShowers = 85,

        /// <summary>86 – Heavy snow showers</summary>
        HeavySnowShowers = 86,

        /// <summary>95 – Thunderstorm (slight or moderate)</summary>
        ThunderstormSlightOrModerate = 95,

        /// <summary>96 – Thunderstorm with slight hail</summary>
        ThunderstormWithSlightHail = 96,

        /// <summary>99 – Thunderstorm with heavy hail</summary>
        ThunderstormWithHeavyHail = 99
    }
}
