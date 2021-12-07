using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.FactoryMethod
{
    class AirSampleAnalysis: SampleAnalysisSystem
    {
        public AirSampleAnalysis(int n):base(" воздуха", n)
        {
            Console.WriteLine("Создан анализатор воздуха" );
        }
    }
}
