using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.StatePat
{
    class SurveyState : State
    {
        bool time;
        public SurveyState()
        {
            time = false;
            Console.WriteLine("\nОПРОС: Запрос отправлен");
        }
        public void make(MonitoringSystem sys)
        {
            if (!time)
            {
                Console.WriteLine("ОПРОС: Ожидание ответа");
                time =true;
            }
            else
            {
                Console.WriteLine("ОПРОС: Ответ получен");
                sys.setState(new ProcessingState());
            }
        }



    }
}
