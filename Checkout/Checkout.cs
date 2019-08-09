using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Checkout : ICheckout
    {
        private readonly List<string> _items = new List<string>();
        private readonly Pricing _pricing = new Pricing();

        public void Scan(string item)
        {
            _items.Add(item);
        }

        public int GetTotalPrice()
        {
            var total = 0;

            var itemGroups = _items.GroupBy(x => x);

            foreach (var itemGroup in itemGroups)
            {
                var price = _pricing.Items.First(x => x.SKU == itemGroup.Key);

                var specialPriced = itemGroup.Count() / price.SpecialPriceQuantity;
                var unitPriced = itemGroup.Count() - (specialPriced * price.SpecialPriceQuantity);

                total += (specialPriced * price.SpecialPrice) + (unitPriced * price.UnitPrice);
            }

            return total;
        }
    }
}