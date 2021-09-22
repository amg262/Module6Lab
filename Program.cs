using System;

namespace Module6Lab
{
    class Program
    {
        static void Main(string[] args)
        {
     

            Console.WriteLine("Qty: ");
            Int32.TryParse(Console.ReadLine(), out int qty);
            Console.WriteLine("Measure: ");
            string meas = Console.ReadLine();
            Console.WriteLine("Desc");
            string desc = Console.ReadLine();
            Ingredient ing = new Ingredient(qty, meas, desc);

            Console.WriteLine(ing.Print());
            // Console.WriteLine(ing.GetDesc());
            // Console.WriteLine(ing.GetMeasurement());
            // Console.WriteLine(ing.GetQty());
            //
            
            
        }
    }
}