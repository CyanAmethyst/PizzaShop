using System;
using System.Collections.Generic;
namespace PizzaShop
{
    class Pizza
    {
        string dough;
        List<string> ingredients;
        List<string> extras;
        public Pizza(string _dough,List<string> _ingredients,List<string> _extras)
        {
            dough = _dough;
            ingredients = _ingredients;
            extras = _extras;
        }
    }
}
