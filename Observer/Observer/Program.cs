using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            weatherData.SetMeasurement(80, 65, 30.4f);
            weatherData.RegisterObserver(currentConditionDisplay);
            weatherData.SetMeasurement(80, 65, 30.4f);
            weatherData.Remove(currentConditionDisplay);
            weatherData.SetMeasurement(80, 65, 30.4f);
        }
    }
}
