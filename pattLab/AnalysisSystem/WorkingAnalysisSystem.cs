using pattLab.IndirectionPatt;
using pattLab.Iterator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    
   
using typeDevice = Indirection;
    class WorkingAnalysisSystem : AnalysisSystem, IteratorCollection<typeDevice>
    {

        public int num=0;


        public WorkingAnalysisSystem(int num)
        {
            listDevices.Clear();
            this.num = num;
           
        }
        public WorkingAnalysisSystem(int num, List<typeDevice> list)
        {
            listDevices.Clear();
            this.num = num;
            listDevices = list;
        }


        private List<typeDevice> listDevices = new List<typeDevice>();

        public Iterator<typeDevice> createIterator() {
            return new IteratorDevice(listDevices);
        }
        public List<string> getAllMeasurements() {
            List<string> list = new List<string>();
            foreach (typeDevice it in listDevices)
                {
                it.getMeasurements();
                
                }
            return list;
        }

        public void addDevice(typeDevice newDevice) {
            Console.WriteLine("Добавлено новое устройство в систему №"+num);
            listDevices.Add(newDevice);
        }

        public  WorkingAnalysisSystem() { listDevices.Clear(); }
       
    }
}
