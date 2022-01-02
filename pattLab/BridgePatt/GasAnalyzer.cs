using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.BridgePatt
{
    class GasAnalyzer: DeviceHandler
    {
        public string name = "газоанализатор";
        public override void getMeasurement() { Console.WriteLine("Показатели газа получены"); }
        public override void ggetStateDevice() { Console.WriteLine("Состояние газоанализатора стабильное"); }
    }
}
