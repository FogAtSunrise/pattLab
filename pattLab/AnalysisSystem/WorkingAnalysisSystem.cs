using pattLab.Iterator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    
   
using typeDevice = MeasuringDevice;
    class WorkingAnalysisSystem : AnalysisSystem, IteratorCollection<typeDevice>
    {
        

	private List<typeDevice> listDevices = new List<typeDevice>();

        public Iterator<typeDevice> createIterator() {
            return new IteratorDevice(listDevices);
        }
        public List<string> getAllMeasurements() {
            List<string> list = new List<string>();
            foreach (typeDevice it in listDevices)
                {
                it.getMeasurement();
                list.Add(it.getName());
                }
            return list;
        }

        public void addDevice(typeDevice newDevice) {
            listDevices.Add(newDevice);
        }

        public  WorkingAnalysisSystem() { listDevices.Clear(); }
       
    }
}
