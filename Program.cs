using System;
using System.Collections.Generic;

namespace Module6Lab
{
    class Program
    {
        public void EnterRecipe()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            List<Recipe> recipes = new List<Recipe>();
            string recipeName = "";
            string ingredientName = "";

            do
            {
                Console.Write("Enter Recipe Name (NA when done): ");
                recipeName = Console.ReadLine();

                if (recipeName.ToUpper() != "NA")
                {
                    Recipe recipe = new Recipe();
                    recipe.Name = recipeName;

                    do
                    {
                        Console.Write("Ingredient (NA when done): ");
                        ingredientName = Console.ReadLine();

                        if (ingredientName.ToUpper() != "NA")
                        {
                            Ingredient ingredient = new Ingredient();

                            Console.Write("Quantity: ");
                            Double.TryParse(Console.ReadLine(), out double quan);
                            Console.Write("Measurement: ");
                            string measure = Console.ReadLine();

                            ingredients.Add(new Ingredient(quan, measure, ingredientName));
                        }

                        recipe.Ingredients = ingredients;
                    } while (ingredientName.ToUpper() != "NA");

                    recipes.Add(recipe);
                }
            } while (recipeName.ToUpper() != "NA");

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine();
                Console.WriteLine($"-------- {recipe.Name.ToUpper()} --------");

                foreach (Ingredient i in recipe.Ingredients)
                {
                    Console.WriteLine(i.Print());
                }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.EnterRecipe();
        }
    }
}