using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.AbstractFactory
{
    abstract class AbstractSampleType
    {
        public AbstractSampleType()
        {
        }

        public abstract void prepareSample();
        public abstract void analyzeSample();

        public abstract string getType();

    }
}
