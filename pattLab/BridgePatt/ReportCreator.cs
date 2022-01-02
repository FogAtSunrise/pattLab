using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.BridgePatt
{
    class ReportCreator : DataProcessor
    {
        public ReportCreator(DeviceHandler d) :base(d)
            {}
        public override void getReport()
        {
            Console.WriteLine("ОТЧЕТ");
            dev.getMeasurement();
            dev.ggetStateDevice();
        }
    }
}
