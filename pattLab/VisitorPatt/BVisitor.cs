using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.VisitorPatt
{
    class BVisitor: Visitor
    {
        public override void visit(Barometer dev) { Console.WriteLine("Барометр сегодня подавлен атмосферным больше, чем вчера"); }
    }
}
