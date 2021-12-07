using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.FactoryMethod
{
    class ObjectMet
    {
        public virtual SampleAnalysisSystem createSampleAnalysisSystem(int n) { return new SampleAnalysisSystem(); }

    }
}
