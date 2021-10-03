using System.Collections.Generic;

namespace Module6Lab
{
    public class Dessert : Recipe
    {
        public string IsFrozen { get; set; }

        public Dessert(string isFrozen, string name = null, List<Ingredient> ingredients = null) : base(name,
            ingredients)
        {
            IsFrozen = isFrozen;
        }
    }
}