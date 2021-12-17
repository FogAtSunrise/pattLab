﻿using pattLab.AbstractFactory;
using pattLab.Composite;
using pattLab.Decorator;
using pattLab.FactoryMethod;
using pattLab.Iterator;
using pattLab.ObserverPat;
using pattLab.StatePat;
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

            //до внедрения фабричного метода
           // firstSystem.addDevice(new Adapter(new SampleAnalysisSystem())); 
           //после
            firstSystem.addDevice(new Adapter((new AirObject()).createSampleAnalysisSystem(6)));

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

        public void test8()
        {
            //конкретные системы анализа или точнее их фабрики
            AirAuto FabA = new AirAuto();
            WaterNotAuto FabW1 = new WaterNotAuto();
            WaterAuto FabW2 = new WaterAuto();

            //создаю автоматический анализатор воздуха 
            SampleAnalysisSystem air1 = FabA.createAnalisSystem();

            //создаю не автоматический анализатор воды  
            SampleAnalysisSystem wat1 = FabW1.createAnalisSystem();

            //создаю автоматический анализатор воды
            SampleAnalysisSystem wat2 = FabW2.createAnalisSystem();

            Console.WriteLine("\nРезультаты:\n");
            //вывожу результаты для созданных анализаторов
            air1.getResult();
            wat1.getResult();
            wat2.getResult();
        }

        public void test9()
        {
            //Создаю два экземпляра системы мониторинга
            MonitoringSystem sys1 = MonitoringSystem.getInstance("МАИС");
            MonitoringSystem sys2 = MonitoringSystem.getInstance("Галлифрей");

            Console.WriteLine("\nРезультаты:\n");

            //вывожу имена 
            sys1.getData();
            sys2.getData();
        
        }

        public void test10()
        {
            //Создаю пользователя и клонирую его в нового
            CertainUser oneUser = new CertainUser("ira", "hjr", 2);
            User twoUser = oneUser.clone();

            Console.WriteLine("Результат с пользователем:\n");
            Console.Write("Первый пользователь: ");
            oneUser.operation();

            Console.Write("\nВторой пользователь (клон):");
            twoUser.operation();

            //меняю логин первого пользователя
            oneUser.setLog("NEWname");

            Console.WriteLine("\n\nРезультат с пользователем после замены логина первого:\n");
            Console.Write("Первый пользователь: ");
            oneUser.operation();

            Console.Write("\nВторой пользователь (клон):");
            twoUser.operation();

            //создаю группу
            CompositeUser groupUsers = new CompositeUser();
 
            //заполняю группу 
            groupUsers.addUser(new CertainUser("LILI", "123", 3));
            groupUsers.addUser(new CompositeUser(new List<User>() { new CertainUser("IRA", "yui", 3) , twoUser}));
            groupUsers.addUser(new CertainUser("KIM", "o23", 1));

            //клонирую группу
            User groupClone = groupUsers.clone();

            Console.WriteLine("\n___________________________________________");
            Console.WriteLine("\n\nРезультат с группой:");
            Console.Write("\nГруппа пользователей");
            groupUsers.operation();
            Console.WriteLine("\n___________________________________________");

            Console.Write("Клон группы пользователей");
            groupClone.operation();
            Console.WriteLine("\n___________________________________________");
        }

        public void test11()
        {
            //Создаю систему мониторинга
            MonitoringSystem sys = MonitoringSystem.getInstance("Галлифрей");

            //Задаю начальное состояние
            sys.setState(new WaitState());

            //вывожу состояния 
            for (int i = 0; i < 15; i++)
            {
                sys.run();
            }
        }

        public void test12()
        {
            //Создаю систему мониторинга и наблюдателя
            MonitoringSystem sys = MonitoringSystem.getInstance("Галлифрей");
            CommissionOfMNRandE comis = new CommissionOfMNRandE();

            //подпишем наблюдателя на мониторинг
            sys.attach(comis);

            Console.Write("\n_____________Задаю начальное состояние_______________");
            sys.setState(new WaitState());

            Console.WriteLine("\n________________Цикл по шагам________________________");
            //на каждом шаге вывожу данные о наблюдаемом объекте с точки зрения наблюдателя
            for (int i = 0; i < 7; i++)
            {
                //прохожу работу состояний пошагово
                sys.run();
                //данные о наблюдаемом объекте 
                comis.getSubjectState();  
            }
        }
        static void Main(string[] args)
        {
           
           
            Program test = new Program();
            /* test.test1();
             test.test2();
             test.test3();
             test.test4();
             test.test5();
             test.test6();
             test.test7();
             test.test8();
             test.test9();
            test.test10();
            test.test11();*/

            test.test12();
        }
    }
}
