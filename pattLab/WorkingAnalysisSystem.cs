using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    
   
using typeDevice = MeasuringDevice;
    class WorkingAnalysisSystem : AnalysisSystem
    {
        

	private List<typeDevice> listDevices = new List<typeDevice>();

        public void getAllMeasurements() {
            foreach(typeDevice it in listDevices)
                {
                it.getMeasurement();
            }
        }

        public void addDevice(MeasuringDevice newDevice) {
            listDevices.Add(newDevice);
        }

        public  WorkingAnalysisSystem() { listDevices.Clear(); }
       
    }
}
