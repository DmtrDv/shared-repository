﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchy
{
    class Discount_Energi : drinks
    {
        public Discount_Energi(string Name, double Cost, int Quantity) : base(Name, Cost, Quantity)
        {                   
            if (Quantity > 5 && Quantity <= 10)
             discount = "Скидка 10%";
            if (Quantity > 10 && Quantity <= 20)
                discount = "Скидка 20%";
            if (Quantity > 20)
                discount = "Скидка 30%";                            
        }

        public override string Discount()
        { 
            Console.WriteLine(discount);
            return discount;
        }
    }
}
