using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    class ProxyAnalysisSystem : AnalysisSystem
    {
        private WorkingAnalysisSystem Prox;


        public void addDevice(MeasuringDevice newDevice) { Prox.addDevice(newDevice); }
        public void getAllMeasurements() { Prox.getAllMeasurements(); }
        public ProxyAnalysisSystem(WorkingAnalysisSystem newSystem) { Prox = newSystem; }
    }
}
