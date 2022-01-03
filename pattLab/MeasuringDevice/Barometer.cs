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
        Random rnd = new Random();
        public string getName() { return name; }
        public void getMeasurement() { Console.WriteLine("Показания барометра получены"); 
            }
        private int indic = 0;
        public void getDeviations()
        {
            getMeasurement();
            int last = indic;
            
            indic = rnd.Next(50, 900);
            Console.WriteLine("Разность: " + Math.Abs(last - indic)+" мм рт. ст.");

        }
        public void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
