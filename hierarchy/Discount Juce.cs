using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchy
{
    class Discount_Juce: drinks
    {
        public Discount_Juce(string Name, double Cost, int Quantity) : base(Name, Cost, Quantity)
        {
            if (Quantity > 5 && Quantity <= 10)
                discount = "Скидка 11%";
            if (Quantity > 10 && Quantity <= 20)
                discount = "Скидка 22%";
            if (Quantity > 20)
                discount = "Скидка 33%";
        }

        public override string Discount()
        {
            Console.WriteLine(discount);
            return discount;
        }
    }
}
