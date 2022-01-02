using pattLab.Flyweight;
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
        FlyweightData data;

        public WorkingAnalysisSystem(int num, string c, string t, List<typeDevice> list)
        {
            data = FlyweightFactory.createFlyweight(c, t);
            listDevices.Clear();
            this.num = num;
            listDevices = list;
            Console.WriteLine("Создана система № "+num);
            data.printData();
        }


        public int num=0;

        

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
            Console.WriteLine("\nОпрос приборов системы №" + num);
            List<string> list = new List<string>();
            foreach (typeDevice it in listDevices)
                {
                it.getMeasurement();
                list.Add(it.getName());
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
