using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pattLab.MeasuringDeviceFile;
using System.Threading.Tasks;

namespace pattLab.BuilderPat
{
    class BuilderAnalysisSystemAir : Builder
    {
        WorkingAnalysisSystem system;
        public BuilderAnalysisSystemAir()
        { system = new WorkingAnalysisSystem(); }
       public AnalysisSystem getResult() { return system; }

        public void setNumber(int n) { system.setNum(n); }

        public void addBaseDevices() { system.addDevice(new Thermometer());
                                        system.addDevice(new Barometer());
                                         }

        public void addAnotherDevice(MeasuringDevice dev) { system.addDevice(dev); }
    }
}
