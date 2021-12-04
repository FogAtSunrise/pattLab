using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Decorator
{
    class AnalysisSystemWithReport : DecoratorAnalysisSystem
    {
        private List<string> listMeasurement;
        public AnalysisSystemWithReport(AnalysisSystem a) : base(a)
        { listMeasurement = analysisSystem.getAllMeasurements(); }
   

    public void generateReport()
    {

        Console.WriteLine("\nОтчет\nБыли проделаны измерения посредством следующих приборов:");
        foreach (string str in listMeasurement)
        {
            Console.WriteLine(str);
        }
        }
    }
}
