using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.AbstractFactory
{
    class WaterSampleAnalysis: AbstractSampleType
    {
        public WaterSampleAnalysis()
        {
            Console.WriteLine("Создан анализатор воды");
        }
        public override void prepareSample() { }

        public override void analyzeSample() { }

        public override string getType() { return "анализатор воды"; }
    }
}
