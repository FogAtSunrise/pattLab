using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.BridgePatt
{
    class WaterAnalyzer: DeviceHandler
    {
        public string name = "водоанализатор";
        public override void getMeasurement() { Console.WriteLine("Показатели воды получены"); }
        public override void ggetStateDevice() { Console.WriteLine("Состояние водоанализатора стабильное"); }
    }
}
