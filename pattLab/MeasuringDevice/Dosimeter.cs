using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    class Dosimeter : MeasuringDevice
    {
        private string name = "Дозиметр";
        public string getName() { return name; }
        public void getMeasurement()
        {
            Console.WriteLine("Показания дозиметра получены");
        }
    }
}
