using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.business_logic
{
    public interface IObserver
    {
        void Update(Weather pWeather);
    }
}
