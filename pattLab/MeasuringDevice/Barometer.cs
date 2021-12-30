using pattLab.VisitorPatt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    class Barometer: MeasuringDevice
    {
        private string name = "Барометр";

        public string getName() { return name; }
        public void getMeasurement() { Console.WriteLine("Показания барометра получены"); 
            }
        public void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
