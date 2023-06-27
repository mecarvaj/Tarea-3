using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.business_logic
{
    public class Weather
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float AthmosphericPressure { get; set; }
        public float WindSpeed { get; set; }

        public Weather() { }
        public Weather(float pTemperature, float pHumidity, float pAthmosphericPressure , float pWindSpeed) 
        {
            Temperature = pTemperature;
            Humidity = pHumidity;
            AthmosphericPressure = pAthmosphericPressure;
            WindSpeed = pWindSpeed;
        }

    }
}
