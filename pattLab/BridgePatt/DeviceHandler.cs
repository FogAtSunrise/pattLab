using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.BridgePatt
{
    abstract class DeviceHandler
    {
        public virtual void getMeasurement() { }
        public virtual void ggetStateDevice() { }
    }
}
