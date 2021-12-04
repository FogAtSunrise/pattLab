using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Iterator
{
    interface IteratorCollection<T>
    {
        Iterator<T> createIterator();
    }
}
