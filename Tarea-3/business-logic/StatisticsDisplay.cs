using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.business_logic
{
    public class StatisticsDisplay : IObserver
    {
        private Weather? StatisticsConditions;
        public void Update(Weather pStatistics)
        {
            StatisticsConditions = pStatistics;
            Console.WriteLine($"Statistics display: \n" +
                $"\nTemperature: \t{StatisticsConditions.Temperature} %" +
                $"\nHumidity: \t{StatisticsConditions.Humidity} %" +
                $"\nAthmospheric Pressure: \t{StatisticsConditions.AthmosphericPressure} mbar" +
                $"\nWind Speed: \t{StatisticsConditions.WindSpeed} Km/h\n"
                );

        }
    }
}
