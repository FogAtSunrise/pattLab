using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pattLab.MeasuringDeviceFile;

namespace pattLab.VisitorPatt
{
    class TVisitor: Visitor
    {
        public void visit(Thermometer dev) {

            Console.WriteLine("Термометр считает, что вчера было теплее");
        }
    }
}
