using pattLab.Decorator;
using pattLab.Iterator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pattLab
{
    class Program
    {
        //делегирование
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

        //прокси
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

        //адаптер
        public void test3()
        {
            //создаю систему анализа
            WorkingAnalysisSystem firstSystem = new WorkingAnalysisSystem();

            //добавляю дозиметр, термометр и анализатор пробы
            firstSystem.addDevice(new Dosimeter());
            firstSystem.addDevice(new Thermometer());
            firstSystem.addDevice(new Adapter(new SampleAnalysisSystem()));

            //запрашиваю у системы показания измерений
            Console.WriteLine("Опрос системы: ");

            firstSystem.getAllMeasurements();
        }

        //декоратор
        public void test4()
        {
            //создаю систему анализа
            WorkingAnalysisSystem firstSystem = new WorkingAnalysisSystem();
            //добавляю дозиметр, термометр и барометр
            firstSystem.addDevice(new Dosimeter());
            firstSystem.addDevice(new Thermometer());
            firstSystem.addDevice(new Barometer());

            //создаю расширенные версии
            AnalysisSystemWithAnalyse syst1 = new AnalysisSystemWithAnalyse(firstSystem);
            AnalysisSystemWithReport syst2 = new AnalysisSystemWithReport(firstSystem);

            Console.WriteLine("\nДополнительный функционал:");
            Console.WriteLine("___________________________________________");
            syst1.analyseMeasurements();
            Console.WriteLine("___________________________________________");
            syst2.generateReport();
            Console.WriteLine("___________________________________________");
        }

        //итератор
        public void test6()
        {
            //создаю систему анализа
            WorkingAnalysisSystem firstSystem = new WorkingAnalysisSystem();
            //добавляю дозиметр, термометр и барометр
            firstSystem.addDevice(new Dosimeter());
            firstSystem.addDevice(new Thermometer());
            firstSystem.addDevice(new Barometer());

            Iterator<MeasuringDevice> it = firstSystem.createIterator();
            Console.WriteLine("Считываю параметры измерительных устройств системы с помощью итератора: ");
            do {
                MeasuringDevice device = it.getCurrent();
                device.getMeasurement();
                it.getNext();
            } while (it.hasNext());
        }
        static void Main(string[] args)
        {
           
           
            Program test = new Program();
            test.test4();
         //   test.test2();

        }
    }
}
