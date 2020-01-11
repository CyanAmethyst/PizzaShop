using System;
using System.Collections.Generic;
namespace PizzaShop
{
    class WareHouse
    {
        List<Dough> DoughsInStock;
        List<Extras> ExtrasInStock;
        List<Ingredient> IngredientsInStock;
        protected static double total = 0;

        public WareHouse()
        {
            DoughsInStock = new List<Dough>();
            ExtrasInStock = new List<Extras>();
            IngredientsInStock = new List<Ingredient>();
            Dough wheatDough = new Dough(1, "wheat dough", 0.79);
            DoughsInStock.Add(wheatDough);
            Dough ryeDough = new Dough(2, "rye dough", 0.99);
            DoughsInStock.Add(ryeDough);
            Extras jalapeno = new Extras(1, "jalapeno", 0.83);
            ExtrasInStock.Add(jalapeno);
            Extras onions = new Extras(2, "onions", 0.61);
            ExtrasInStock.Add(onions);
            Extras pineapple = new Extras(3, "pineapple", 0.77);
            ExtrasInStock.Add(pineapple);
            Ingredient tomatoSauce = new Ingredient(1, "tomato sauce", 2.36);
            IngredientsInStock.Add(tomatoSauce);
            Ingredient chicken = new Ingredient(2, "chicken", 2.96);
            IngredientsInStock.Add(chicken);
            Ingredient pepperoni = new Ingredient(3, "pepperoni", 2.79);
            IngredientsInStock.Add(pepperoni);
            Ingredient cheese = new Ingredient(4, "cheese", 1.52);
            IngredientsInStock.Add(cheese);
            Ingredient tomatoes = new Ingredient(5, "tomatoes", 1.64);
            IngredientsInStock.Add(tomatoes);
            Ingredient mushrooms = new Ingredient(6, "mushrooms", 1.76);
            IngredientsInStock.Add(mushrooms);
            Ingredient bacon = new Ingredient(7, "bacon", 2.55);
            IngredientsInStock.Add(bacon);
            Ingredient olives = new Ingredient(8, "olives", 1.57);
            IngredientsInStock.Add(olives);
            Ingredient bellPepper = new Ingredient(9, "bell pepper", 1.72);
            IngredientsInStock.Add(bellPepper);
            Ingredient ham = new Ingredient(10, "ham", 2.86);
            IngredientsInStock.Add(ham);

        }

        public double Total {
            get { return total; }
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
                total += 0.79;
                return "wheat dough";
            }
            else if (userInput == 2)
            {
                total += 0.99;
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
                total += 2.36;
                return "tomato sauce";
            }
            else if (userInput == 2)
            {
                total += 2.96;
                return "chicken";
            }
            else if (userInput == 3)
            {
                total += 2.79;
                return "pepperoni";
            }
            else if (userInput == 4)
            {
                total += 1.52;
                return "cheese";
            }
            else if (userInput == 5)
            {
                total += 1.64;
                return "tomatoes";
            }
            else if (userInput == 6)
            {
                total += 1.76;
                return "mushrooms";
            }
            else if (userInput == 7)
            {
                total += 2.55;
                return "bacon";
            }
            else if (userInput == 8)
            {
                total += 1.57;
                return "olives";
            }
            else if (userInput == 9)
            {
                total += 1.72;
                return "bell pepper";
            }

            else if (userInput == 10)
            {
                total += 2.86;
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
            else
            {
                return "undefined";
            }
        }

    }
}
