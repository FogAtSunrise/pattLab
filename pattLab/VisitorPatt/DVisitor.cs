using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.VisitorPatt
{
    class DVisitor: Visitor
    {
        public override void visit(Dosimeter dev) { Console.WriteLine("Дозиметр встревожен ростом интенсивности излучения"); }
       

    }
}
