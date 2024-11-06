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
            Discount_Energi Energi_Burn = new Discount_Energi("Burn  ",100.0, 7);
            Console.Write(Energi_Burn.GetName());
            Console.WriteLine(Energi_Burn.GetCost());
            Energi_Burn.Discount();

            Discount_Juce Juce_Rich = new Discount_Juce("Rich  ", 150.0, 12);
            Console.Write(Juce_Rich.GetName());
            Console.WriteLine(Juce_Rich.GetCost());
            Juce_Rich.Discount();


            Console.ReadKey();
        }
    }
}
