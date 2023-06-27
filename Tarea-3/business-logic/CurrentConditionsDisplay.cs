using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.business_logic
{
    public class CurrentConditionsDisplay : IObserver
    {
        private Weather? CurrentConditions;
        public void Update(Weather pCurrentConditions)
        {
            CurrentConditions = pCurrentConditions;
            Console.WriteLine($"Current conditions: \n"+
                $"\nTemperature: \t{CurrentConditions.Temperature}"+
                $"\nHumidity: \t{CurrentConditions.Humidity}"+
                $"\nAthmospheric Pressure: \t{CurrentConditions.AthmosphericPressure}"+
                $"\nWind Speed: \t{CurrentConditions.WindSpeed}\n"
                );

        }
    }
}
