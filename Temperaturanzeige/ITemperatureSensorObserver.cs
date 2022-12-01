using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturanzeige
{
    public interface ITemperatureSensorObserver
    {
        void Update(int temperatureValue);
    }
}
