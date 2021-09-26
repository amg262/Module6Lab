# Module 6 Lab #

Modify the Try It program to also have a Recipe class. A Recipe has a List of Ingredients and a name which is a string.

The user should be able to enter multiple recipes. When the user is done, the program should print out all recipes.

```
Enter recipe name: PB&J Sandwich
Ingredient (NA when done): Peanut Butter
Quantity: 3
Measurement: Tablespoons
Ingredient (NA when done): Grape Jelly
Quantity: 2
Measurement: Tablespoons
Ingredient (NA when done): Bread
Quantity: 2
Measurement: Slices
Ingredient (NA when done): NA
Enter another recipe? (Y/N): N

PB&J Sandwich
3 Tablespoons Peanut Butter
2 Tablespoons Grape Jelly
2 Slices Bread
```

# THIS IS THE FINAL CODE #

```c#
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
```