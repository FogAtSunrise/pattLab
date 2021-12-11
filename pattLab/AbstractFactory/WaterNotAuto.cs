using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.AbstractFactory
{
    class WaterNotAuto : SampleAnalysisSystem
    {
        public WaterNotAuto() { }

        protected override void createSampleType()
        {
            typeSample = new WaterSampleAnalysis();
        }
        protected override void createСollectType()
        {
            typeCollect = new NotAutoCollection();
        }

        public override SampleAnalysisSystem createAnalisSystem()
        {
            WaterNotAuto newSys = new WaterNotAuto();
            newSys.createSampleType();
            newSys.createСollectType();
            Console.WriteLine("Собран не автоматический анализатор воды \n");
            return newSys;

        }
    }
}
