using pattLab.MeasuringDeviceFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.BuilderPat
{
    interface Builder
    {
        AnalysisSystem  getResult();
        void setNumber(int n);
        void addBaseDevices();
        void addAnotherDevice(MeasuringDevice dev);



    }
}
