using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Composite
{
    class User
    {
       public virtual void addUser(User a) { }
        public virtual void delUser(User a) { }
        public virtual List<User> getCompositeUsers() { return new List<User>(); }
        public virtual void operation() { }
    }
}
