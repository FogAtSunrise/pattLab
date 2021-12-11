using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.AbstractFactory
{
    class WaterAuto : SampleAnalysisSystem
    {
        public WaterAuto() { }


        protected override void createSampleType()
        {
            typeSample = new WaterSampleAnalysis();
        }
        protected override void createСollectType()
        {
            typeCollect = new AutoCollection();
        }

        public override SampleAnalysisSystem createAnalisSystem()
        {
            WaterAuto newSys = new WaterAuto();
            newSys.createSampleType();
            newSys.createСollectType();
            Console.WriteLine("Собран автоматический анализатор воды \n");
            return newSys;

        }

    }
}
