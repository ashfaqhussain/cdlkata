﻿namespace Checkout
{
    public class Checkout : ICheckout
    {
        public void Scan(string item)
        {
        }

        public int GetTotalPrice()
        {
            return -1;
        }
    }
}