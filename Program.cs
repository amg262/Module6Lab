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
                Console.WriteLine("Enter Recipe Name");
                recipeName = Console.ReadLine();

                if (recipeName.ToUpper() != "NA")
                {
                    Recipe recipe = new Recipe();
                    recipe.Name = recipeName;
                    
                    do
                    {
                        Console.WriteLine("Ingredient (NA when done)>");
                        ingredientName = Console.ReadLine();

                        if (ingredientName.ToUpper() != "NA")
                        {
                            Ingredient ingredient = new Ingredient();

                            Console.WriteLine("Quantity:");
                            Double.TryParse(Console.ReadLine(), out double quan);
                            Console.WriteLine("Measurement");
                            string measure = Console.ReadLine();

                            ingredients.Add(new Ingredient(quan, measure, ingredientName));
                        }

                        recipe.Ingredients = ingredients;
                    } while (ingredientName.ToUpper() != "NA");
                    recipes.Add(recipe);
                }
                
            } while (recipeName.ToUpper() != "NA");


            foreach (var recipe in recipes)
            {
                Console.WriteLine(recipe.Name);

                foreach (var i in recipe.Ingredients)
                {
                    var ingredient = new Ingredient();
                    Console.WriteLine(ingredient.Print());
                }
            }
            
        }
        public void Print()
        {

            
            
                
        }

        static void Main(string[] args)
        {

            Program p = new Program();
            p.EnterRecipe();

        }

        // static void Main2(string[] args)
        // {
        //
        //     List<Ingredient> ings = new List<Ingredient>();
        //
        //     string desc;
        //     do
        //     {
        //         Console.WriteLine("Ingrdient (NA when done)");
        //         desc = Console.ReadLine();
        //
        //         if (desc.ToUpper() != "NA")
        //         {
        //             Console.WriteLine("Qty: ");
        //             Int32.TryParse(Console.ReadLine(), out int qty);
        //             Console.WriteLine("Measure: ");
        //             string meas = Console.ReadLine();
        //
        //             ings.Add(new Ingredient(qty, meas, desc));
        //         }
        //     } while (desc.ToUpper() != "NA");
        //
        //     foreach (var i in ings)
        //     {
        //         Console.WriteLine($"{i.Print()}");
        //     }
        // }
    }
}