using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.AbstractFactory
{
    class AirSampleAnalysis: AbstractSampleType
    {
        public AirSampleAnalysis()
        {
            Console.WriteLine("Создан анализатор воздуха");
        }
        public override void prepareSample() { }

        public override void analyzeSample() { }

        public override string getType() { return "анализатор воздуха"; }
    }
}
