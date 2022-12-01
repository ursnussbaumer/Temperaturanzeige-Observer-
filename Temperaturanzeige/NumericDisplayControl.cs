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
    public partial class NumericDisplayControl : UserControl, ITemperatureSensorObserver
    {
        public NumericDisplayControl()
        {
            InitializeComponent();
        }

        void ITemperatureSensorObserver.Update(int temperatureValue)
        {
            textBoxValue.Text = temperatureValue.ToString();
        }

        private void NumericDisplayControl_Load(object sender, EventArgs e)
        {
            textBoxValue.Text = "0";
        }
    }
}
