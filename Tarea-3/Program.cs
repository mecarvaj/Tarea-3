using Tarea_3.business_logic;

namespace Tarea_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create weather station
            var weatherStation = new WeatherStation();

            // Create display devices
            var currentConditionsDisplay = new CurrentConditionsDisplay();
            var statisticsDisplay = new StatisticsDisplay();

            // Register display devices as observers
            weatherStation.RegisterObserver(currentConditionsDisplay);
            weatherStation.RegisterObserver(statisticsDisplay);

            // Simulate weather changes
            weatherStation.SetWeatherData(35.1f,55.4f,1011,15.3f);
            weatherStation.SetWeatherData(29.1f,86.4f,1011,18.3f);
            

            // Note the display updates
            // TODO: Observe the display devices showing the updated weather data
        }
    }
}