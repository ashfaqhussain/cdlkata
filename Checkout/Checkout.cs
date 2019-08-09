using System.Collections.Generic;

namespace Checkout
{
    public class Checkout : ICheckout
    {
        private readonly List<string> _items = new List<string>();

        public void Scan(string item)
        {
            _items.Add(item);
        }

        public int GetTotalPrice()
        {
            var groups = _items.Count / 3;
            var units = _items.Count - (groups * 3);

            return (groups * 130) + (units * 50);
        }
    }
}