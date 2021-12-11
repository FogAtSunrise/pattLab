using pattLab.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    //система анализа пробы
    abstract class SampleAnalysisSystem
    {
        private List<int> listIndicators;
        private int numb;
     
        public SampleAnalysisSystem()
        { }
        
        public SampleAnalysisSystem(string t, int n)
        { type = t;
            numb = n;
        }

        private void collectSample() { }
        private void prepareSample() { }
        private void analyzeSample() { }

        //лб 6
        public void getResultsOfAnalysis() { Console.WriteLine("Анализ пробы проведен, показатели получены"); }

        //Factory method
        private string type;

        public void getResults() { Console.WriteLine("Результат устройства №"+numb+" для анализа пробы:"+type); }


        //абстрактная фабрика (p.s. было бы логичней сделать в отдельной ветке, но мой перфикционизм не согласен дробить тесты по веткам)
        protected AbstractCollectType typeCollect;
        protected AbstractSampleType typeSample;
        protected virtual void createSampleType() { }
        protected virtual void createСollectType() { }

        public abstract SampleAnalysisSystem createAnalisSystem();

        public void getResult() { Console.WriteLine("Результат: анадизатор по ТИПУ ОТБОРА = " + typeCollect.getTypeCollect() + " ПО ТИПУ ПРОБЫ = " + typeSample.getType()); }
      
    }
}
