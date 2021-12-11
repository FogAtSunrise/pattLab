﻿using pattLab.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab
{
    class MonitoringSystem
    {
       private List<AnalysisSystem> listAnalysisSystem;
        private static string name="name";
        private static MonitoringSystem instance = null;
        private MonitoringSystem() { Console.WriteLine("Создана центральная система мониторинга"); }
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
