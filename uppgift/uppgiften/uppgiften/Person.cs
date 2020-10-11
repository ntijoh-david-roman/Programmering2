using System;
using System.Collections.Generic;

namespace uppgiften
{
    class Person
    {

        public string _name;

        public List<Products> _cart = new List<Products>();

        Products _item;
        public Person(string name, Products item)
        {
            _name = name;
            _item = item;

        }
        public void ActivateItem()
        {
            _item.Purchase();
        }
    }
}
