using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.FactoryMethod
{
    class WaterObject : ObjectMet
    {
        public WaterObject() { }
        public override SampleAnalysisSystem createSampleAnalysisSystem(int n)
        {
            return new WaterSampleAnalysis(n);
        }
    }
}
