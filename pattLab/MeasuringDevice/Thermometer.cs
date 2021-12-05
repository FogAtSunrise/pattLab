using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    class Thermometer : MeasuringDevice
    {
        private string name = "Термометр";

        public string getName() { return name; }
        public void getMeasurement()
        {
            Console.WriteLine("Показания термометра получены");
        }
    }
}