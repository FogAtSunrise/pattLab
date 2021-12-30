using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.VisitorPatt
{
    class TVisitor: Visitor
    {
        public override void visit(Thermometer dev) {

            Console.WriteLine("Термометр считает, что вчера было теплее");
        }
    }
}
