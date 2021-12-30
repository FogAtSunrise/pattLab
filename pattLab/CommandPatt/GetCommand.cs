
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.CommandPatt
{
    class GetCommand:Command
    {
        WorkingAnalysisSystem reciever;
        public GetCommand(WorkingAnalysisSystem rec)
        {
            reciever = rec;
        }

        public void execute()
        {
            Console.WriteLine("GetCommand для системы №"+ reciever.num);
            reciever.getAllMeasurements();
        }
    }
}
