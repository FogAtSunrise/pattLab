using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.BridgePatt
{
    abstract class DataProcessor
    {
        protected DeviceHandler dev;

        public DataProcessor(DeviceHandler d)
        { 
            dev = d;
        }

        public virtual void getReport() { }

        public virtual void getAnalysis() { }

    }
}
