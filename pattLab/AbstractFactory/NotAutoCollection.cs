using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.AbstractFactory
{
    class NotAutoCollection: AbstractCollectType
    {
        public NotAutoCollection()
        {
            Console.WriteLine("Создан НЕ автоматический тип отбора пробы");
        }
        public override void collectSample() { }
        public override string getTypeCollect() { return "не автоматический"; }
    }
}
