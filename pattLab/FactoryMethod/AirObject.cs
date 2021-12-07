using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.FactoryMethod
{
    class AirObject: ObjectMet
    {
        public AirObject() { }
            public override SampleAnalysisSystem createSampleAnalysisSystem(int n)
           {
            
            return new AirSampleAnalysis(n);
        }
    }
}
