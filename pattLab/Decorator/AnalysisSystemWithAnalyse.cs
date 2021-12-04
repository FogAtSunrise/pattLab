using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Decorator
{
    class AnalysisSystemWithAnalyse : DecoratorAnalysisSystem
    {
        private List<string> listMeasurement;
        private List<int> listNormMeasurement;
        public AnalysisSystemWithAnalyse(AnalysisSystem a):base(a)
        { listMeasurement = analysisSystem.getAllMeasurements(); }

        public void analyseMeasurements()
        {
            
            Console.WriteLine("\nАнализ текущих показателей\n");
            foreach (string str in listMeasurement)
            {
                Console.WriteLine("Отклонение показателей "+str+"а равно "+str.Length+"%");
            }
           
        }
    }
}
