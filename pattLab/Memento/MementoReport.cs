using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Memento
{
    class MementoReport
    {
        private string dataSurvey;
        private int typeReport;

        public MementoReport(string d, int t)
        {
            dataSurvey = d;
            typeReport = t;

        }
        public string getData() { return dataSurvey; }
        public int getType() { return typeReport; }

    }
}
