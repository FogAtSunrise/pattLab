using pattLab.MeasuringDeviceFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.BuilderPat
{
    class BuilderAnalysisSystemWater : Builder
    {
        WorkingAnalysisSystem system;
        public BuilderAnalysisSystemWater()
        { system = new WorkingAnalysisSystem(); }
        public AnalysisSystem getResult() { return system; }

        public void setNumber(int n) { system.setNum(n); }

       

        public void addBaseDevices()
        {
            system.addDevice(new Thermometer());
            system.addDevice(new Oximeter());
            system.addDevice(new pHmeter());
        }


        public void addAnotherDevice(MeasuringDevice dev) { system.addDevice(dev); }
    }
}
