using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.FactoryMethod
{
    class WaterSampleAnalysis : SampleAnalysisSystem
    {
        public WaterSampleAnalysis(int n) : base(" воды", n)
        {
            Console.WriteLine("Создан анализатор воды");
        }
    }
}
