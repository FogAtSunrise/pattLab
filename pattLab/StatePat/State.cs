using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.StatePat
{
    interface State
    {
       
        void make(MonitoringSystem sys);
        string getName();
       
    }
}
