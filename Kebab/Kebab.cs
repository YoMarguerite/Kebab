using System;
using System.Collections.Generic;
using System.Linq;

namespace Kebab
{
    public class Kebab
    {
        public Dictionary<Ingredient, int> ingredients = new Dictionary<Ingredient, int>();

        public string IsVegetable()
        {
            string vegetable = Ingredient.VEGETARIEN;
            for (int i = 0; i < ingredients.Count; i++)
            {
                if (ingredients.ElementAt(i).Key.type == Ingredient.CARNIVORE)
                    return Ingredient.CARNIVORE;
                if (ingredients.ElementAt(i).Key.type == Ingredient.PESCETARIEN)
                    vegetable = Ingredient.PESCETARIEN;
            }
            return vegetable;
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
