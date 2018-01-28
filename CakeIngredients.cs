using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingrediend = Console.ReadLine();
            int count = 0;

            while (ingrediend != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingrediend}.");
                count++;
                ingrediend = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
