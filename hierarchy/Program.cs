using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            drinks Energi = new drinks("Burn",100.0, 7);
            Console.WriteLine(Energi.GetName());
            Console.WriteLine(Energi.GetCost());
            Energi.Discount();

            drinks Juce = new drinks("Rich", 150.0, 12);
            Console.WriteLine(Juce.GetName());
            Console.WriteLine(Juce.GetCost());


            Console.ReadKey();
        }
    }
}
