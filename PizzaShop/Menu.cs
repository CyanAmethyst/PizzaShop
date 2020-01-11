using System;
using System.Collections.Generic;
namespace PizzaShop
{
    class PizzaMenu
    {

        public PizzaMenu()
        {

        }
        public void MakePizza()
        {
            string makePizza = "yes";
            WareHouse wareHouse = new WareHouse();
            while (makePizza == "yes")
            {
                Console.WriteLine("Welcome to our shop! Here's the list of our pizzas.");
                Console.WriteLine("Option 1: chicken pizza tomato sauce/chicken/bell pepper/cheese.");
                Console.WriteLine("Option 2: mushroom pizza tomato sauce/mushrooms/ham/bell pepper.");
                Console.WriteLine("Option 3: pepperoni pizza tomato sauce/pepperoni/bell pepper/cheese.");
                Console.WriteLine("Option 4: bacon pizza tomato sauce/ham/bacon/cheese.");
                Console.WriteLine("Option 5: vegan pizza tomato sauce/olives/bell pepper/tomatoes.");
                Console.WriteLine("Option 6: custom pizza with atleast 4 ingredients.");
                Console.WriteLine("Write the number of the pizza you want.");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    wareHouse.PrintDoughsInStock();
                    int userDough = wareHouse.ChooseDough();
                    string dough = wareHouse.PizzaDough(userDough);
                    List<string> ingredients = new List<string>();
                    ingredients.Add(wareHouse.PizzaIngredient(1));
                    ingredients.Add(wareHouse.PizzaIngredient(2));
                    ingredients.Add(wareHouse.PizzaIngredient(9));
                    ingredients.Add(wareHouse.PizzaIngredient(4));

                    Console.WriteLine("Do you want to add extra ingredients? yes/no");
                    string userIngredientsAnswer = Console.ReadLine().ToLower();
                    while (userIngredientsAnswer == "yes")
                    {
                        wareHouse.PrintIngredientsInStock();
                        int newIngredient = wareHouse.ChooseIngredient();
                        ingredients.Add(wareHouse.PizzaIngredient(newIngredient));
                        Console.WriteLine("Do you want to add ingredients? yes/no");
                        userIngredientsAnswer = Console.ReadLine().ToLower();
                    }

                    List<string> extras = new List<string>();
                    Console.WriteLine("Do you want to add extras? yes/no");
                    string userExtrasAnswer = Console.ReadLine().ToLower();
                    while (userExtrasAnswer == "yes")
                    {
                        wareHouse.PrintExtrasInStock();
                        int newExtra = wareHouse.ChooseExtra();
                        extras.Add(wareHouse.PizzaExtra(newExtra));
                        Console.WriteLine("Do you want to add extras? yes/no");
                        userExtrasAnswer = Console.ReadLine().ToLower();
                    }

                    Pizza pizza = new Pizza(dough, ingredients, extras);
                    Console.WriteLine($"The cost of your order is {Math.Round(wareHouse.Total,2)}");
                    Console.WriteLine("Do you wanna make another pizza? yes/no");
                    makePizza = Console.ReadLine().ToLower();
                }
                else if (userInput == 2)
                {
                    wareHouse.PrintDoughsInStock();
                    int userDough = wareHouse.ChooseDough();
                    string dough = wareHouse.PizzaDough(userDough);
                    List<string> ingredients = new List<string>();
                    ingredients.Add(wareHouse.PizzaIngredient(1));
                    ingredients.Add(wareHouse.PizzaIngredient(6));
                    ingredients.Add(wareHouse.PizzaIngredient(10));
                    ingredients.Add(wareHouse.PizzaIngredient(9));

                    Console.WriteLine("Do you want to add extra ingredients? yes/no");
                    string userIngredientsAnswer = Console.ReadLine().ToLower();
                    while (userIngredientsAnswer == "yes")
                    {
                        wareHouse.PrintIngredientsInStock();
                        int newIngredient = wareHouse.ChooseIngredient();
                        ingredients.Add(wareHouse.PizzaIngredient(newIngredient));
                        Console.WriteLine("Do you want to add ingredients? yes/no");
                        userIngredientsAnswer = Console.ReadLine().ToLower();
                    }

                    List<string> extras = new List<string>();
                    Console.WriteLine("Do you want to add extras? yes/no");
                    string userExtrasAnswer = Console.ReadLine().ToLower();
                    while (userExtrasAnswer == "yes")
                    {
                        wareHouse.PrintExtrasInStock();
                        int newExtra = wareHouse.ChooseExtra();
                        extras.Add(wareHouse.PizzaExtra(newExtra));
                        Console.WriteLine("Do you want to add extras? yes/no");
                        userExtrasAnswer = Console.ReadLine().ToLower();
                    }

                    Pizza pizza = new Pizza(dough, ingredients, extras);
                    Console.WriteLine($"The cost of your order is {Math.Round(wareHouse.Total, 2)}");
                    Console.WriteLine("Do you wanna make another pizza? yes/no");
                    makePizza = Console.ReadLine().ToLower();
                }
                else if (userInput == 3)
                {
                    wareHouse.PrintDoughsInStock();
                    int userDough = wareHouse.ChooseDough();
                    string dough = wareHouse.PizzaDough(userDough);
                    List<string> ingredients = new List<string>();
                    ingredients.Add(wareHouse.PizzaIngredient(1));
                    ingredients.Add(wareHouse.PizzaIngredient(3));
                    ingredients.Add(wareHouse.PizzaIngredient(9));
                    ingredients.Add(wareHouse.PizzaIngredient(4));

                    Console.WriteLine("Do you want to add extra ingredients? yes/no");
                    string userIngredientsAnswer = Console.ReadLine().ToLower();
                    while (userIngredientsAnswer == "yes")
                    {
                        wareHouse.PrintIngredientsInStock();
                        int newIngredient = wareHouse.ChooseIngredient();
                        ingredients.Add(wareHouse.PizzaIngredient(newIngredient));
                        Console.WriteLine("Do you want to add ingredients? yes/no");
                        userIngredientsAnswer = Console.ReadLine().ToLower();
                    }

                    List<string> extras = new List<string>();
                    Console.WriteLine("Do you want to add extras? yes/no");
                    string userExtrasAnswer = Console.ReadLine().ToLower();
                    while (userExtrasAnswer == "yes")
                    {
                        wareHouse.PrintExtrasInStock();
                        int newExtra = wareHouse.ChooseExtra();
                        extras.Add(wareHouse.PizzaExtra(newExtra));
                        Console.WriteLine("Do you want to add extras? yes/no");
                        userExtrasAnswer = Console.ReadLine().ToLower();
                    }

                    Pizza pizza = new Pizza(dough, ingredients, extras);
                    Console.WriteLine($"The cost of your order is {Math.Round(wareHouse.Total, 2)}");
                    Console.WriteLine("Do you wanna make another pizza? yes/no");
                    makePizza = Console.ReadLine().ToLower();
                }
                else if (userInput == 4)
                {
                    wareHouse.PrintDoughsInStock();
                    int userDough = wareHouse.ChooseDough();
                    string dough = wareHouse.PizzaDough(userDough);
                    List<string> ingredients = new List<string>();
                    ingredients.Add(wareHouse.PizzaIngredient(1));
                    ingredients.Add(wareHouse.PizzaIngredient(7));
                    ingredients.Add(wareHouse.PizzaIngredient(10));
                    ingredients.Add(wareHouse.PizzaIngredient(4));

                    Console.WriteLine("Do you want to add extra ingredients? yes/no");
                    string userIngredientsAnswer = Console.ReadLine().ToLower();
                    while (userIngredientsAnswer == "yes")
                    {
                        wareHouse.PrintIngredientsInStock();
                        int newIngredient = wareHouse.ChooseIngredient();
                        ingredients.Add(wareHouse.PizzaIngredient(newIngredient));
                        Console.WriteLine("Do you want to add ingredients? yes/no");
                        userIngredientsAnswer = Console.ReadLine().ToLower();
                    }

                    List<string> extras = new List<string>();
                    Console.WriteLine("Do you want to add extras? yes/no");
                    string userExtrasAnswer = Console.ReadLine().ToLower();
                    while (userExtrasAnswer == "yes")
                    {
                        wareHouse.PrintExtrasInStock();
                        int newExtra = wareHouse.ChooseExtra();
                        extras.Add(wareHouse.PizzaExtra(newExtra));
                        Console.WriteLine("Do you want to add extras? yes/no");
                        userExtrasAnswer = Console.ReadLine().ToLower();
                    }

                    Pizza pizza = new Pizza(dough, ingredients, extras);
                    Console.WriteLine($"The cost of your order is {Math.Round(wareHouse.Total, 2)}");
                    Console.WriteLine("Do you wanna make another pizza? yes/no");
                    makePizza = Console.ReadLine().ToLower();
                }
                else if (userInput == 5)
                {
                    wareHouse.PrintDoughsInStock();
                    int userDough = wareHouse.ChooseDough();
                    string dough = wareHouse.PizzaDough(userDough);
                    List<string> ingredients = new List<string>();
                    ingredients.Add(wareHouse.PizzaIngredient(1));
                    ingredients.Add(wareHouse.PizzaIngredient(8));
                    ingredients.Add(wareHouse.PizzaIngredient(5));
                    ingredients.Add(wareHouse.PizzaIngredient(9));

                    Console.WriteLine("Do you want to add extra ingredients? yes/no");
                    string userIngredientsAnswer = Console.ReadLine().ToLower();
                    while (userIngredientsAnswer == "yes")
                    {
                        wareHouse.PrintIngredientsInStock();
                        int newIngredient = wareHouse.ChooseIngredient();
                        ingredients.Add(wareHouse.PizzaIngredient(newIngredient));
                        Console.WriteLine("Do you want to add ingredients? yes/no");
                        userIngredientsAnswer = Console.ReadLine().ToLower();
                    }

                    List<string> extras = new List<string>();
                    Console.WriteLine("Do you want to add extras? yes/no");
                    string userExtrasAnswer = Console.ReadLine().ToLower();
                    while (userExtrasAnswer == "yes")
                    {
                        wareHouse.PrintExtrasInStock();
                        int newExtra = wareHouse.ChooseExtra();
                        extras.Add(wareHouse.PizzaExtra(newExtra));
                        Console.WriteLine("Do you want to add extras? yes/no");
                        userExtrasAnswer = Console.ReadLine().ToLower();
                    }

                    Pizza pizza = new Pizza(dough, ingredients, extras);
                    Console.WriteLine($"The cost of your order is {Math.Round(wareHouse.Total, 2)}");
                    Console.WriteLine("Do you wanna make another pizza? yes/no");
                    makePizza = Console.ReadLine().ToLower();
                }
                else if (userInput == 6)
                {
                    wareHouse.PrintDoughsInStock();
                    int userDough = wareHouse.ChooseDough();
                    string dough = wareHouse.PizzaDough(userDough);
                    List<string> ingredients = new List<string>();
                    int ingredientCounter = 4;
                    while (ingredientCounter > 0)
                    {
                        Console.WriteLine($"You have {ingredientCounter} ingredient(s) left to choose.");
                        wareHouse.PrintIngredientsInStock();
                        int addIngredient = wareHouse.ChooseIngredient();
                        ingredients.Add(wareHouse.PizzaIngredient(addIngredient));
                        ingredientCounter--;
                    }

                    Console.WriteLine("Do you want to add extra ingredients? yes/no");
                    string userIngredientsAnswer = Console.ReadLine().ToLower();
                    while (userIngredientsAnswer == "yes")
                    {
                        wareHouse.PrintIngredientsInStock();
                        int newIngredient = wareHouse.ChooseIngredient();
                        ingredients.Add(wareHouse.PizzaIngredient(newIngredient));
                        Console.WriteLine("Do you want to add ingredients? yes/no");
                        userIngredientsAnswer = Console.ReadLine().ToLower();
                    }

                    List<string> extras = new List<string>();
                    Console.WriteLine("Do you want to add extras? yes/no");
                    string userExtrasAnswer = Console.ReadLine().ToLower();
                    while (userExtrasAnswer == "yes")
                    {
                        wareHouse.PrintExtrasInStock();
                        int newExtra = wareHouse.ChooseExtra();
                        extras.Add(wareHouse.PizzaExtra(newExtra));
                        Console.WriteLine("Do you want to add extras? yes/no");
                        userExtrasAnswer = Console.ReadLine().ToLower();
                    }

                    Pizza pizza = new Pizza(dough, ingredients, extras);
                    Console.WriteLine($"The cost of your order is {Math.Round(wareHouse.Total, 2)}");
                    Console.WriteLine("Do you wanna make another pizza? yes/no");
                    makePizza = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("You have entered an invalid number/character. Try again!");
                    makePizza = "yes";
                }
            }
        }

    }
}
