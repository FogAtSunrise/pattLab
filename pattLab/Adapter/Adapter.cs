﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    //адаптер для подведения системы анализа пробы под интерфейс измерительного прибора
    class Adapter : MeasuringDevice
    {
        private string name = "SampleAnalysisSystem";

        SampleAnalysisSystem adaptable;

        public string getName() { return name; }
        public Adapter(SampleAnalysisSystem s)
        {
            adaptable = s;
        }
        public void setAdaptable(SampleAnalysisSystem s)
        {
            adaptable = s;
        }
        public void getMeasurement()
        {
            adaptable.getResultsOfAnalysis();
        }
    }
}
