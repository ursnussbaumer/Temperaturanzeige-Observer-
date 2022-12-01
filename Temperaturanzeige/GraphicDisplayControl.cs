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
    public partial class GraphicDisplayControl : UserControl, ITemperatureSensorObserver
    {
        public GraphicDisplayControl()
        {
            InitializeComponent();
        }

        void ITemperatureSensorObserver.Update(int temperatureValue)
        {
            panelHeat.Size = new Size(48, temperatureValue);
            panelHeat.Location = new Point(0, 100 - temperatureValue);
        }

        private void GraphicDisplayControl_Load(object sender, EventArgs e)
        {
            panelHeat.Size = new Size(48, 0);
            panelHeat.Location = new Point(0, 0);
        }
    }
}
