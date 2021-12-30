using pattLab.IndirectionPatt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Iterator
{
    class IteratorDevice: Iterator<Indirection> 
    {
        private List<Indirection> list;
        private int current;

        public IteratorDevice(List<Indirection> list)
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

        public Indirection getCurrent() {
            Console.WriteLine("iteratir = "+ current);
                return list[current]; }
    }
}
