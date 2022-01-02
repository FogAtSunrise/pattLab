using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Flyweight
{
    class FlyweightData
    {
        public string chart;
       public string type;
        public FlyweightData(string c, string t)
        {
            chart = c;
            type = t;
        }

        public void printData()
        {
            Console.WriteLine("график: "+chart+"\nтип: "+type);
        }
    }
}
