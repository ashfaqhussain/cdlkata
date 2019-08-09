using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout
{
    public class Pricing
    {
        public List<Price> Items;

        public Pricing()
        {
            Items = new List<Price>
                    {
                        new Price("A", 50, 3, 130),
                        new Price("B", 30, 2, 45),
                        new Price("C", 20),
                        new Price("D", 15)
                    };
        }
    }

    public class Price
    {
        public Price(string sku, int unitPrice, int specialPriceQuantity, int specialPrice)
        {
            SKU = sku;
            UnitPrice = unitPrice;
            SpecialPriceQuantity = specialPriceQuantity;
            SpecialPrice = specialPrice;
        }
        public Price(string sku, int unitPrice) : this(sku, unitPrice, 0, 0)
        {
        }

        public readonly string SKU;
        public readonly int UnitPrice;
        public readonly int SpecialPriceQuantity;
        public readonly int SpecialPrice;
    }
}
