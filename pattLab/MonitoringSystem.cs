using pattLab.CommandPatt;
using pattLab.Composite;
using pattLab.ObserverPat;
using pattLab.StatePat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    class MonitoringSystem : Subject
    {
        Command command;

        //получаю от клиента объект конкретной команды
        public void setCommand(Command  com)
        {
            command = com;
        }

        //выполняю команду
        public void executeCommand()
        {
            command.execute();
        }
       //--------------------------------------------------------------------------------------------
        private State curState;

        //изменить статус системы
        public void setState(State s) { 
            curState = s;
            notify();
        }

        public void run() { curState.make(instance); }

        //оотправить оповещение наблюдателю
        public override void notify() {
            if(observer!=null)
            observer.update(curState);
        }

        private List<AnalysisSystem> listAnalysisSystem;
        private static string name="name";
        private static MonitoringSystem instance = null;
        public MonitoringSystem() { Console.WriteLine("Создана центральная система мониторинга"); }
        private MonitoringSystem(string n) { 
            name = n;
            Console.WriteLine("Создана центральная система мониторинга \""+name+ "\""); 
        }
        public static MonitoringSystem getInstance(string n)
        {
            if (instance == null)
             instance = new MonitoringSystem(n); 
            else Console.WriteLine("Система \"" + n + "\" не может быть создана, т.к. уже создана система \"" + name + "\"");
            return instance;
        }

        public void getData()
        {
            Console.WriteLine("Система мониторинга \"" + name + "\"");
        }
        CompositeUser users;
        public void addAnalysisSystem(AnalysisSystem newAnalysisSystem) { }
        public void getAllAnalysisResults() { }

    }
}
