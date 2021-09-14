using System;
using System.Collections.Generic;
using System.Linq;

namespace Jedi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1.
            Dictionary<string, int> _ = new();

            // Opgave 2.
            Dictionary<string, int> people = new();
            people.Add("Emir", 23);
            people["Daniel"] = 23;
            Console.WriteLine(people.ElementAt(0));

            // Opgave 3.
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };
            characters.Remove("Han");

            // Opgave 4.
            foreach (var item in characters)
                Console.WriteLine($"{item.Value}");
        }
    }
}
