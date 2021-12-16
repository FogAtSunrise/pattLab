using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.StatePat
{
    class ProcessingState: State
    {
        int time;
        public ProcessingState()
        {
            time = 0;
            Console.WriteLine("");
        }
        public void make(MonitoringSystem sys)
        {
            if (time < 2)
            {
                Console.WriteLine("ОБРАБОТКА ДАННЫХ: Идет обработка");
                time += 1;
            }
            else
            {
                Console.WriteLine("ОБРАБОТКА ДАННЫХ: Обработка завершена");
                sys.setState(new WaitState());
            }
        }
    }
}
