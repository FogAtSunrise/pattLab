using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.BridgePatt
{
    class Analyzer : DataProcessor
    {
        public Analyzer(DeviceHandler d) : base(d)
        { }
        public override void getAnalysis() {
            Console.WriteLine("АНАЛИЗ");
            dev.getMeasurement();
            Console.WriteLine("Показатели превышают норму на 5%");
        }
    }
}
