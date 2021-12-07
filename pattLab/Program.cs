using pattLab.Composite;
using pattLab.Decorator;
using pattLab.FactoryMethod;
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
        //Composite
        public void test5()
        {
            //Создаю отдельного пользователя и группу
            User oneUser = new CertainUser("ira", "hjr", 2);
            User groupUsers = new CompositeUser();
            User groupDop = new CompositeUser();

            //заполняю дополнительную группу
            groupDop.addUser(new CertainUser("l", "1", 4));
            groupDop.addUser(new CertainUser("hjh", "yui", 3));

            //заполняю основную группу (дополнительная становится ее подгруппой)
            groupUsers.addUser(new CertainUser("lia", "123", 3));
            groupUsers.addUser(oneUser);
            groupUsers.addUser(groupDop);
            groupUsers.addUser(new CertainUser("kkk", "o23", 1));

            Console.WriteLine("Отдельный пользователь");
            oneUser.operation();
            Console.Write("\n\nГруппа пользователей");
            groupUsers.operation();
            Console.WriteLine("\n___________________________________________"); 
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

        public void test7()
        {
            //конкретные фабричные методы
            ObjectMet FabMetA = new AirObject();
            ObjectMet FabMetW = new WaterObject();

            //создаю два газаанализатора с номерами 1 и 2
            SampleAnalysisSystem air1 = FabMetA.createSampleAnalysisSystem(1);
            SampleAnalysisSystem air2 = FabMetA.createSampleAnalysisSystem(2);

            //создаю водоанализатор с номером 234
            SampleAnalysisSystem wat234 = FabMetW.createSampleAnalysisSystem(234);

            Console.WriteLine("\nРезультаты:\n");
            //вывожу результаты для созданных анализаторов
            air1.getResults();
            air2.getResults();
            wat234.getResults();
        }
        static void Main(string[] args)
        {
           
           
            Program test = new Program();
              test.test1();
              test.test2();
              test.test3();
              test.test4();
              test.test5();
              test.test6();
            
            test.test7();
        }
    }
}
