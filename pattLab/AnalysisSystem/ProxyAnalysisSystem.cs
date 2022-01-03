using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pattLab.MeasuringDeviceFile;
namespace pattLab
{
    class ProxyAnalysisSystem : AnalysisSystem
    {
        private WorkingAnalysisSystem Prox;


        public void addDevice(MeasuringDevice newDevice) { Prox.addDevice(newDevice); }
        public List<string> getAllMeasurements() { Prox.getAllMeasurements();
            return new List<string>(); }
        public ProxyAnalysisSystem(WorkingAnalysisSystem newSystem) { Prox = newSystem; }
    }
}
