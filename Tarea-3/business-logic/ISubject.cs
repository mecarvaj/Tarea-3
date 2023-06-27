using Microsoft.Win32;
using System;

namespace Tarea_3.business_logic
{
    public interface ISubject
    {

        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
        void SetWeatherData(float temperature, float humidity, float pressure, float wind);
    }
}