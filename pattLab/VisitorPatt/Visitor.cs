using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.VisitorPatt
{
   abstract class Visitor
    {
        public virtual void visit(Thermometer dev) { }
        public virtual void visit(Dosimeter dev) { }
      public virtual void visit(Barometer dev) { }


    }
}
