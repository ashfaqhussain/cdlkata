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
            return _items.Count * 50;
        }
    }
}