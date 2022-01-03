using pattLab.VisitorPatt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.MeasuringDeviceFile
{
    class Thermometer : MeasuringDevice
    {
        private string name = "Термометр";
        Random rnd = new Random();
        public string getName() { return name; }
        public void getMeasurement()
        {
            Console.WriteLine("Показания термометра получены");
            
        }

        private int indic = 0;
        public void getDeviations()
        {
            getMeasurement();
            int last = indic;
            
            indic = rnd.Next(-30, 30);
            Console.WriteLine("Разность: " + Math.Abs(last-indic)+" С");
            
        }
        public void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}