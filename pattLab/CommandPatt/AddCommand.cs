using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.CommandPatt
{
    class AddCommand:Command
    {
        WorkingAnalysisSystem receiver;
        MeasuringDevice param;

        public AddCommand(WorkingAnalysisSystem rec, MeasuringDevice par)
        {
            receiver = rec;
            param = par;

        }

        public void execute()
        {
            Console.WriteLine("AddCommand для системы №" + receiver.num);
            //receiver.addDevice(param);
        }
    }
}
