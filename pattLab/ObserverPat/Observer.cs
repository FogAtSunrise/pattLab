﻿using pattLab.StatePat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.ObserverPat
{
    interface Observer
    {
        void update(State s);
    }
}
