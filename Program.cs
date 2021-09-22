using System;
using System.Collections.Generic;

namespace Module6Lab
{
    class Program
    {
        static void Main(string[] args)
        {
  
            List<Ingredient> ings = new List<Ingredient>();

            string desc;
            do
            {
                Console.WriteLine("Ingrdient (NA when done)");
                desc = Console.ReadLine();

                if (desc.ToUpper() != "NA")
                {
                    Console.WriteLine("Qty: ");
                    Int32.TryParse(Console.ReadLine(), out int qty);
                    Console.WriteLine("Measure: ");
                    string meas = Console.ReadLine();

                    ings.Add(new Ingredient(qty, meas, desc));
                }
            } while (desc.ToUpper() != "NA");

            foreach (var i in ings)
            {
                Console.WriteLine($"{i.Print()}");
            }
        }
    }
}