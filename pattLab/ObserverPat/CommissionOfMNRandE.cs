using pattLab.StatePat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.ObserverPat
{
    class CommissionOfMNRandE:Observer
    {
        State subjectState;

      public   CommissionOfMNRandE()
        { subjectState = null;
            Console.WriteLine("Создан наблюдатель");
        }
        public void update(State s) {
            Console.WriteLine("*** Оповещение об изменении состояния");
            subjectState = s;

        }

        public void getSubjectState()
        {
            Console.WriteLine("---------------- Состояние наблюдаемой системы: "+ subjectState.getName());
        }
    }
}
