using System.Collections.Generic;
using System.ComponentModel;

namespace Module6Lab
{
    public class Recipe
    {
        private string name;

        private List<Ingredient> ingredients;


        public Recipe(string name = null, List<Ingredient> ingredients = null)
        {
            this.name = name;
            this.ingredients = ingredients;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Ingredient> Ingredients
        {
            get => ingredients;
            set => ingredients = value;
        }
    }
}