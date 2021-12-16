using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.StatePat
{
    class WaitState : State
    {
        int time;
       public WaitState()
        { time = 0;
            Console.WriteLine("");
        }
        public void make(MonitoringSystem sys)
        {
            if (time < 20)
            {
                Console.WriteLine("ОЖИДАНИЕ: " + (time+5) + " минут ожидания");
                time += 5;
            }
            else
            {
                sys.setState(new SurveyState());
            }
        }
    }
}
