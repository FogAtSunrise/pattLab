using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.AbstractFactory
{
    class AirAuto : SampleAnalysisSystem
    {
        public AirAuto() { }


        protected override void createSampleType() {
            typeSample = new AirSampleAnalysis();
        }
        protected override void createСollectType() {
            typeCollect = new AutoCollection();
        }

        public override SampleAnalysisSystem createAnalisSystem()
        {
            AirAuto newSys = new AirAuto();
            newSys.createSampleType();
            newSys.createСollectType();
            Console.WriteLine("Собран автоматический анализатор воздуха \n");
            return newSys;

        }

    }
}
