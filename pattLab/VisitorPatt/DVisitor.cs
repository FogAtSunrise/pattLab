using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pattLab.MeasuringDeviceFile;

namespace pattLab.VisitorPatt
{
    class DVisitor: Visitor
    {
        public void visit(Dosimeter dev) { Console.WriteLine("Дозиметр встревожен ростом интенсивности излучения"); }
       

    }
}
