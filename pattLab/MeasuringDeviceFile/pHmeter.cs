﻿using pattLab.VisitorPatt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.MeasuringDeviceFile
{
    class pHmeter : MeasuringDevice
    {
        Random rnd = new Random();
        private string name = "pH-метр";
        public string getName() { return name; }
        public void getMeasurement()
        {
            Console.WriteLine("Показания pH-метра получены");
        }
        private float indic = 0;
        public void getDeviations()
        {
            getMeasurement();
            float last = indic;

            indic = rnd.Next(0, 2);
            Console.WriteLine("Разность: " + Math.Abs(last - indic) + " %");

        }
        public void accept(Visitor v)
        {

        }

        
    }
}
