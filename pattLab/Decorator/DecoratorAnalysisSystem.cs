using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Decorator
{
    class DecoratorAnalysisSystem: AnalysisSystem
    {
        protected AnalysisSystem analysisSystem;
        public DecoratorAnalysisSystem(AnalysisSystem a)
        {
            analysisSystem = a;
        }
        public  List<string> getAllMeasurements() {return analysisSystem.getAllMeasurements(); }
    }
}
