using System.Collections.Generic;

namespace Module6Lab
{
    public class Recipe
    {
        public Recipe(string name = null, List<Ingredient> ingredients = null)
        {
            this.Name = name;
            this.Ingredients = ingredients;
        }

        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Ingredients.ToString()}";
        }

    }
}