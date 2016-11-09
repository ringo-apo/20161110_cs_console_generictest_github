using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        class Syohin
        {
            public int id;
            public string name;
            public int price;

            public Syohin(int id, string name, int price)
            {
                this.id = id;
                this.name = name;
                this.price = price;
            }
        }

        static void Main(string[] args)
        {
            List<Syohin> shina = new List<Syohin> {
                new Syohin (1,"apple",100),
                new Syohin (2,"banana",200),
                new Syohin (3,"pine",300)
            };

            shina.Add(new Syohin(4, "ichigo", 400));

            foreach (Syohin _ in shina)
            {
                Console.WriteLine("id={0} , name={1} , price={2}",_.id,_.name,_.price);
            }

            Console.ReadLine();
        }
    }
}
