using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> collection = new List<Animal>
            {
                new Bat(),
                new Cat(),
                new Bat(),
                new Duck(),
                new Dog(),
                new Cat(),
                new Bat(),
                new Duck(),
                new Cat(),
                new Dog()
            };
            foreach (Animal animal in collection)
            {
                if (animal is IFlyable)
                {
                    (animal as IFlyable).Fly();
                }
            }
            Console.ReadKey();
        }
    }
}
