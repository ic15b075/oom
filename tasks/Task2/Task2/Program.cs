using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car(true, "blue", 50);
            Car b = new Car(false, "red", 40);
            Car c = new Car(false, "red", 20);

            Console.WriteLine("Tankgrösse Auto a:"+ a.Tank);
            Console.WriteLine("Farbe von Auto a:"+ a.Color);
            Console.WriteLine("Trebstoffart von Auto b:" + b.Fuel);
            Console.WriteLine("Farbe von Auto b:"+ b.Color);

            Console.WriteLine("Farbe von Auto c:"+ (c.Color = "yellow"));
            Console.WriteLine("tanken von Auto a, Kosten:"+ a.FillUp(true,50));

            Console.WriteLine("Tankgrösse Auto c:" + c.Tank);
            c.ChangeTank(55);
            Console.WriteLine("Neue Tankgrösse Auto c:" + c.Tank);

        }
    }
}
