using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.FactoryMethod
{
    abstract class ObjectMet
    {
        public abstract SampleAnalysisSystem createSampleAnalysisSystem(int n);

    }
}
