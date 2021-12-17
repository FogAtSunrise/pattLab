using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.ObserverPat
{
    class Subject
    {
        protected Observer observer=null;

        public void attach(Observer o)
        { observer = o; }

        public void detach(Observer o)
        {
            if (observer == o)
                observer = null;
        }

        public virtual void notify() { }
    }
}
