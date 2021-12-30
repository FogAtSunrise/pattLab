using pattLab.VisitorPatt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    interface MeasuringDevice
    {
        void getMeasurement();
        string getName();
        void accept(Visitor v);
    }
}
