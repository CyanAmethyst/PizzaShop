using System;
using System.Collections.Generic;
namespace PizzaShop
{
    class PizzaMenu
    {

        public PizzaMenu()
        {

        }
        public void WriteMenu()
        {
            Console.WriteLine("Welcome to our shop! Here's the list of our pizzas.");
            Console.WriteLine("Option 1: chicken pizza tomato sauce/chicken/bell pepper/cheese.");
            Console.WriteLine("Option 2: mushroom pizza tomato sauce/mushrooms/ham/bell pepper.");
            Console.WriteLine("Option 3: pepperoni pizza tomato sauce/pepperoni/bell pepper/cheese.");
            Console.WriteLine("Option 4: bacon pizza tomato sauce/ham/bacon/cheese.");
            Console.WriteLine("Option 5: vegan pizza tomato sauce/olives/bell pepper/tomatoes.");
            Console.WriteLine("Option 6: custom pizza with atleast 4 ingredients.");
        }
        public void MakePizza()
        {
            Console.WriteLine("Write the number of the pizza you want.");
            int userInput = int.Parse(Console.ReadLine());
            WareHouse wareHouse = new WareHouse();

            if (userInput == 1)
            {
                wareHouse.PrintDoughsInStock();
                int userDough = wareHouse.ChooseDough();
                string dough = wareHouse.PizzaDough(userInput);
                List<string> ingredients = new List<string>();
                ingredients.Add(wareHouse.PizzaIngredient(1));
                ingredients.Add(wareHouse.PizzaIngredient(2));
                ingredients.Add(wareHouse.PizzaIngredient(9));
                ingredients.Add(wareHouse.PizzaIngredient(4));
                
                List<string> extras = new List<string>();
                wareHouse.PrintExtrasInStock();
                int userExtras = wareHouse.ChooseExtra();
                while (userExtras != 4)
                {
                    string extra = wareHouse.PizzaExtra(userExtras);
                    extras.Add(extra);
                    userExtras = wareHouse.ChooseExtra();
                }

                Pizza pizza = new Pizza(dough, ingredients, extras);
            }
        }
    }
}
