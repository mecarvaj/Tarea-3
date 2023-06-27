using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.business_logic
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private Weather weather;
        
        public WeatherStation() 
        {
            weather = new Weather();
        }
        public void NotifyObservers()
        {
            observers.ForEach(x => x.Update(weather));
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void SetWeatherData(float pTemperature, float pHumidity, float pPressure, float pWind)
        {
            weather.Temperature = pTemperature;
            weather.Humidity = pHumidity;
            weather.AthmosphericPressure = pPressure;
            weather.WindSpeed = pWind;
            NotifyObservers();
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
