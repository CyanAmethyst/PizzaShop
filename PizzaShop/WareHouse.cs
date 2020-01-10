using System;
using System.Collections.Generic;
namespace PizzaShop
{
    class WareHouse
    {
        List<Dough> DoughsInStock;
        List<Extras> ExtrasInStock;
        List<Ingredient> IngredientsInStock;
        double total = 0;

        public WareHouse()
        {
            DoughsInStock = new List<Dough>();
            ExtrasInStock = new List<Extras>();
            IngredientsInStock = new List<Ingredient>();
            Dough wheatDough = new Dough(1, "wheat dough", 0.29);
            DoughsInStock.Add(wheatDough);
            Dough ryeDough = new Dough(2, "rye dough", 0.39);
            DoughsInStock.Add(ryeDough);
            Extras jalapeno = new Extras(1, "jalapeno", 0.83);
            ExtrasInStock.Add(jalapeno);
            Extras onions = new Extras(2, "onions", 0.61);
            ExtrasInStock.Add(onions);
            Extras pineapple = new Extras(3, "pineapple", 0.77);
            ExtrasInStock.Add(pineapple);
            Extras noMore = new Extras(4, "no extras/done choosing extras", 0);
            ExtrasInStock.Add(noMore);
            Ingredient tomatoSauce = new Ingredient(1, "tomato sauce", 0.36);
            IngredientsInStock.Add(tomatoSauce);
            Ingredient chicken = new Ingredient(2, "chicken", 0.96);
            IngredientsInStock.Add(chicken);
            Ingredient pepperoni = new Ingredient(3, "pepperoni", 0.79);
            IngredientsInStock.Add(pepperoni);
            Ingredient cheese = new Ingredient(4, "cheese", 0.32);
            IngredientsInStock.Add(cheese);
            Ingredient tomatoes = new Ingredient(5, "tomatoes", 0.64);
            IngredientsInStock.Add(tomatoes);
            Ingredient mushrooms = new Ingredient(6, "mushrooms", 0.76);
            IngredientsInStock.Add(mushrooms);
            Ingredient bacon = new Ingredient(7, "bacon", 0.55);
            IngredientsInStock.Add(bacon);
            Ingredient olives = new Ingredient(8, "olives", 0.57);
            IngredientsInStock.Add(olives);
            Ingredient bellPepper = new Ingredient(9, "bell pepper", 0.72);
            IngredientsInStock.Add(bellPepper);
            Ingredient ham = new Ingredient(10, "ham", 0.86);
            IngredientsInStock.Add(ham);

        }
        public void PrintDoughsInStock()
        {
            foreach(Dough dough in DoughsInStock)
            {
                Console.WriteLine($"ID: {dough.Id}");
                Console.WriteLine($"Name: {dough.Name}");
                Console.WriteLine($"Price: {dough.Price}");
            }
        }
        public int ChooseDough()
        {
            Console.WriteLine("Write the id of the dough you want to use");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        public string PizzaDough(int userInput)
        {
            if (userInput == 1)
            {
                total += 0.29;
                return "wheat dough";
            }
            else if (userInput == 2)
            {
                total += 0.39;
                return "rye dough";
            }
            else
            {
                return "undefined";
            }
        }

        public void PrintIngredientsInStock()
        {
            foreach (Ingredient ingredient in IngredientsInStock)
            {
                Console.WriteLine($"ID: {ingredient.Id}");
                Console.WriteLine($"Name: {ingredient.Name}");
                Console.WriteLine($"Price: {ingredient.Price}");
            }
        }
        public int ChooseIngredient()
        {
            Console.WriteLine("Write the id of the ingredient you want to use");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        public string PizzaIngredient(int userInput)
        {
            if (userInput == 1)
            {
                total += 0.36;
                return "tomato sauce";
            }
            else if (userInput == 2)
            {
                total += 0.96;
                return "chicken";
            }
            else if (userInput == 3)
            {
                total += 0.79;
                return "pepperoni";
            }
            else if (userInput == 4)
            {
                total += 0.32;
                return "cheese";
            }
            else if (userInput == 5)
            {
                total += 0.64;
                return "tomatoes";
            }
            else if (userInput == 6)
            {
                total += 0.76;
                return "mushrooms";
            }
            else if (userInput == 7)
            {
                total += 0.55;
                return "bacon";
            }
            else if (userInput == 8)
            {
                total += 0.57;
                return "olives";
            }
            else if (userInput == 9)
            {
                total += 0.72;
                return "bell pepper";
            }

            else if (userInput == 10)
            {
                total += 0.86;
                return "ham";
            }
            else
            {
                return "undefined";
            }
        }

        public void PrintExtrasInStock()
        {
            foreach (Extras extras in ExtrasInStock)
            {
                Console.WriteLine($"ID: {extras.Id}");
                Console.WriteLine($"Name: {extras.Name}");
                Console.WriteLine($"Price: {extras.Price}");
            }
        }
        public int ChooseExtra()
        {
            Console.WriteLine("Write the id of the dough you want to use");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        public string PizzaExtra(int userInput)
        {
            if (userInput == 1)
            {
                total += 0.83;
                return "jalapeno";
            }
            else if (userInput == 2)
            {
                total += 0.61;
                return "onions";
            }
            else if (userInput == 3)
            {
                total += 0.77;
                return "pineapple";
            }
            else if (userInput == 4)
            {
                return "no extras";
            }
            else
            {
                return "undefined";
            }
        }

    }
}
