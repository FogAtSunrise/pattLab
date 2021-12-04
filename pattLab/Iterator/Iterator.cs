using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Iterator
{

    interface Iterator<T>
    {
       void getNext();
        bool hasNext();
        T getCurrent();
    }
}
