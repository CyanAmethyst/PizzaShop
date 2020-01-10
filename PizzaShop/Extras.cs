using System;
using System.Collections.Generic;
namespace PizzaShop
{
    class Extras
    {
        int id;
        string name;
        double price;

        public Extras(int _id, string _name, double _price)
        {
            id = _id;
            name = _name;
            price = _price;
        }
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }
        public int ChooseExtra()
        {
            WareHouse extrasInStock = new WareHouse();
            extrasInStock.PrintExtrasInStock();
            Console.WriteLine("Write the id of the dough you want to use");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        public string PizzaExtra(int userInput)
        {
            if (userInput == 1)
            {
                return "jalapeno";
            }
            else if (userInput == 2)
            {
                return "onions";
            }
            else if (userInput == 3)
            {
                return "pineapple";
            }
            else
            {
                return "undefined";
            }
        }

        public double ExtrasPrice(int userInput)
        {
            if (userInput == 1)
            {
                return 0.83;
            }
            else if (userInput == 2)
            {
                return 0.61;
            }
            else if (userInput == 3)
            {
                return 0.77;
            }
            else
            {
                return 0;
            }
        }

    }
}
