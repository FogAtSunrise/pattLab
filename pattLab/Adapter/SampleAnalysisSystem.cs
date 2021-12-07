using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    //система анализа пробы
    class SampleAnalysisSystem
    {
        private string type;
        private int numb;
        public SampleAnalysisSystem()
        { }
        public SampleAnalysisSystem(string t, int n)
        { type = t;
            numb = n;
        }
        private List<int> listIndicators;

        private void collectSample() { }
        private void prepareSample() { }
        private void analyzeSample() { }

        //это относится к лб 6
        public void getResultsOfAnalysis() { Console.WriteLine("Анализ пробы проведен, показатели получены"); }

        //лб 8
        public void getResults() { Console.WriteLine("Результат устройства №"+numb+" для анализа пробы:"+type); }

    }
}
