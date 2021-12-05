using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Composite
{
    //конкретный пользователь
    class CertainUser : User
    {
        private string login;
        private string password;
        private int privilegeLevel;
        public CertainUser(string l, string p, int pr)
        {
            login=l;
            password=p;
            privilegeLevel=pr; }

        public override void operation () {
            Console.Write("login: " + login+ "; password: " + password+ "; privilege level: " + privilegeLevel);
        }
   
    }
}
