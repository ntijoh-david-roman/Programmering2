using System;
using System.Collections.Generic;
using System.Text;

namespace uppgiften
{
    class Products
    {
        public string _product;
        public int _amount;

        public void Purchase()
        {
            Console.WriteLine(_product + " Do you want to purchase this item?");
        }
    }
}
