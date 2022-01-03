using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pattLab.MeasuringDeviceFile;
namespace pattLab.Iterator
{
    class IteratorDevice: Iterator<MeasuringDevice> 
    {
        private List<MeasuringDevice> list;
        private int current;

        public IteratorDevice(List<MeasuringDevice> list)
        {
            this.list = list;
            current = 0;
        }

        public void getNext()
        {
            if (hasNext())
                current++;
        }

        public bool hasNext() { return current < list.Count; }

        public MeasuringDevice getCurrent() {
            Console.WriteLine("iteratir = "+ current);
                return list[current]; }
    }
}
