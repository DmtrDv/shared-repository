﻿using System;
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
            DiscountEnergi Energi_Burn = new DiscountEnergi("Burn ",100.0, 7);
            Console.Write(Energi_Burn.GetName());
            Console.WriteLine(Energi_Burn.GetCost());
            Energi_Burn.Discount();

            drinks Juce_Rich = new drinks("Rich", 150.0, 12);
            Console.WriteLine(Juce_Rich.GetName());
            Console.WriteLine(Juce_Rich.GetCost());


            Console.ReadKey();
        }
    }
}
