using pattLab.Flyweight;
using pattLab.Iterator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pattLab.MeasuringDeviceFile;

namespace pattLab
{
   
   
    class WorkingAnalysisSystem : AnalysisSystem, IteratorCollection<MeasuringDevice>
    { 
        FlyweightData data;

        public WorkingAnalysisSystem(int num, string c, string t, List<MeasuringDevice> list)
        {
            data = FlyweightFactory.createFlyweight(c, t);
            listDevices.Clear();
            this.num = num;
            listDevices = list;
            Console.WriteLine("Создана система № "+num);
            data.printData();
        }


        public int num=0;

        public void setNum(int n)
        { num = n; }

       public WorkingAnalysisSystem(int num, List<MeasuringDevice> list)
        {
            listDevices.Clear();
            this.num = num;
            listDevices = list;
        }


        private List<MeasuringDevice> listDevices = new List<MeasuringDevice>();

        public Iterator<MeasuringDevice> createIterator() {
            return new IteratorDevice(listDevices);
        }
        public List<string> getAllMeasurements() {
            Console.WriteLine("\nОпрос приборов системы №" + num);
            List<string> list = new List<string>();
            foreach (MeasuringDevice it in listDevices)
                {
                it.getMeasurement();
                list.Add(it.getName());
                }
            return list;
        }

        public void addDevice(MeasuringDevice newDevice) {
            Console.WriteLine("Добавлено новое устройство в систему №"+num);
            listDevices.Add(newDevice);
        }

        public  WorkingAnalysisSystem() { listDevices.Clear(); }
       
    }
}
