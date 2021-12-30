using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.IndirectionPatt
{
    class Indirection
    {
        MeasuringDevice indirectionDevice;
        public Indirection(MeasuringDevice ind)
        {
            indirectionDevice = ind;
        }
        public void getMeasurements()
        {
            indirectionDevice.getMeasurement();
        }

    }
}
