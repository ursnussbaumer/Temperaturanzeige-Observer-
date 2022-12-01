using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturanzeige
{
    public interface ITemperaturSensorSubject
    {
        void Attach(ITemperatureSensorObserver observer);
        void Detach(ITemperatureSensorObserver observer);
        void Notify();
    }
}
