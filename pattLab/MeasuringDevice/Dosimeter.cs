using pattLab.VisitorPatt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    class Dosimeter : MeasuringDevice
    {Random rnd = new Random();
        private string name = "Дозиметр";
        public string getName() { return name; }
        public void getMeasurement()
        {
            Console.WriteLine("Показания дозиметра получены");
        }
        private float indic = 0;
        public void getDeviations()
        {
            getMeasurement();
            float last = indic;
            
            indic = rnd.Next(0, 2);
            Console.WriteLine("Разность: " + Math.Abs(last - indic)+ " мкЗв/час");

        }
        public void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
