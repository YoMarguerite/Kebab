using System;
using System.Collections.Generic;
using System.Linq;

namespace Kebab
{
    public class Kebab
    {
        public Dictionary<Ingredient, int> ingredients = new Dictionary<Ingredient, int>();

        public bool IsVegetable()
        {
            var el = ingredients.Where(ing => !ing.Key.vegetal).FirstOrDefault();
            return el.Key == null;
        }

        public void Display()
        {
            Console.WriteLine("Le kebab contient :");
            for(int i = 0; i<ingredients.Count; i++)
            {
                Console.WriteLine($"{ingredients.ElementAt(i).Value} {ingredients.ElementAt(i).Key.nom}");
            }
        }
    }
}
