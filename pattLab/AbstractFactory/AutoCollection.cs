using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.AbstractFactory
{
    class AutoCollection: AbstractCollectType
    {
        public AutoCollection()
        {
            Console.WriteLine("Создан автоматический тип отбора пробы");
        }
        public override void collectSample() { }
        public override string getTypeCollect() { return "автоматический"; }
    }
}
