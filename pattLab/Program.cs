using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pattLab
{
    class Program
    {
       public void test1()
        {
            //создаю две системы анализа
            WorkingAnalysisSystem firstSystem = new WorkingAnalysisSystem();
            WorkingAnalysisSystem secondSystem = new WorkingAnalysisSystem();

            //добавляю в первую систему термометр и барометр
            firstSystem.addDevice(new Thermometer());
            firstSystem.addDevice(new Barometer());

            //добавляю во вторую дозиметр, термометр и барометр
            secondSystem.addDevice(new Dosimeter());
            secondSystem.addDevice(new Thermometer());
            secondSystem.addDevice(new Barometer());

            //запрашиваю у систем показания измерений
            Console.WriteLine("Опрос систем: ");

            Console.WriteLine("\nFirst Analysis System: ");
            firstSystem.getAllMeasurements();
            Console.WriteLine("\nSecond Analysis System: ");
            secondSystem.getAllMeasurements();
        }
        public void test2()
        {
            WorkingAnalysisSystem newSystem = new WorkingAnalysisSystem();
            ProxyAnalysisSystem proxySystem = new ProxyAnalysisSystem(newSystem);

            //добавляю через прокси дозиметр и барометр
            proxySystem.addDevice(new Dosimeter());
            proxySystem.addDevice(new Barometer());

            //вывожу данные системы напрямую и через прокси
            Console.WriteLine("\nAnalysis System: ");
            newSystem.getAllMeasurements();
            Console.WriteLine("\nProxy Analysis System: ");
            proxySystem.getAllMeasurements();
        }
        static void Main(string[] args)
        {
           
           
            Program test = new Program();
            test.test1();
            test.test2();

        }
    }
}
