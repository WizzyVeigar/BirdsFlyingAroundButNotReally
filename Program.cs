using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundButNotReally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>()
            {
                new Pidget(),
                new Emu()
            };

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird.Draw());
                Console.WriteLine(bird.SetLocation(50,100));
                if (bird is ICanFly)
                {
                    Console.WriteLine(((ICanFly)bird).SetAltitude(50));
                }
            }

            Console.ReadKey();
        }
    }
}
