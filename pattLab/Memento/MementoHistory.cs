using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Memento
{
    class MementoHistory
    {
        private Stack<MementoReport> states;

        public MementoHistory()
        {
            states = new Stack<MementoReport>();
        }

        public void pushMemento(MementoReport s)
        {
            states.Push(s);
        }

        public MementoReport popMemento()
        {
            if (states.Count != 0)
                return states.Pop();
            else return null;
        }

    }
}
