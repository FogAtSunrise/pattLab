using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattLab.Flyweight
{
    class FlyweightFactory
    {
       static List<FlyweightData> list = new List<FlyweightData>();

       static public FlyweightData createFlyweight(string c, string t)
        {
            //Predicate<FlyweightData> fly = new Predicate<FlyweightData>(new FlyweightData(c, t));
             FlyweightData fly = list.Find(x => x.chart.Contains(c)&& x.type.Contains(t));
            
            if (fly == null)
            { list.Add(new FlyweightData(c, t));
                fly = list.Last();
                Console.WriteLine("\nДанные добавлены---");
            }
            else Console.WriteLine("\nДанные уже существуют---");
            return fly;
        }
    }
}
