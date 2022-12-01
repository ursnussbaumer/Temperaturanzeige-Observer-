using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturanzeige
{
    public partial class TemperatureSensorControl : UserControl, ITemperaturSensorSubject
    {
    

        public TemperatureSensorControl()
        {
            InitializeComponent();
        }



        List<ITemperatureSensorObserver> _observers = new List<ITemperatureSensorObserver>();



        #region ITemperatureSensorSubject members

        public void Attach(ITemperatureSensorObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Detach(ITemperatureSensorObserver observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (ITemperatureSensorObserver observer in _observers)
                observer.Update(trackBar.Value);
        }
       

        #endregion 

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.Notify();


        }

 
    }
}
