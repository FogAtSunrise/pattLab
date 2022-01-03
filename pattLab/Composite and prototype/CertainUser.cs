using pattLab.BuilderPat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pattLab.MeasuringDeviceFile;
namespace pattLab.Composite
{
    //конкретный пользователь
    class CertainUser : User
    {
    
            public AnalysisSystem constructSystemAir()
        {
            b.setNumber(456);
            b.addBaseDevices();
            return b.getResult();
        }

        public CertainUser(Builder build)
        {
            b = build;
        }

        private Builder b;
        private string login;
        private string password;
        private int privilegeLevel;

        public void setLog(string log) { login = log; }
        public string getLog() { return login; }

        public void setPas(string pas) { password = pas; }
        public string getPas() { return password; }

        public CertainUser(string l, string p, int pr)
        {
            login=l;
            password=p;
            privilegeLevel=pr; }

        public override void operation () {
            Console.Write("login: " + login+ "; password: " + password+ "; privilege level: " + privilegeLevel);
        }

        public override User clone() { return new CertainUser(login, password, privilegeLevel); }
    }
}
