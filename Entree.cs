using System.Collections.Generic;

namespace Module6Lab
{
    public class Entree : Recipe
    {
        public string Nationality { get; set; }

        public Entree(string nationality, string name = null, List<Ingredient> ingredients = null) : base(name,
            ingredients)
        {
            Nationality = nationality;
        }
    }
}