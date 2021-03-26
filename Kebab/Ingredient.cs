using System;
using System.Collections.Generic;
using System.Text;

namespace Kebab
{
    public class Ingredient
    {
        public string nom;
        public string type;

        public const string CARNIVORE = "Carnivore";
        public const string VEGETARIEN = "Végétarien";
        public const string PESCETARIEN = "Pescetarien";

        public Ingredient(string nom, string type)
        {
            this.nom = nom;
            this.type = type;
        }

        public static Ingredient viande = new Ingredient("Viande", CARNIVORE);

        public static Ingredient poulet = new Ingredient("Poulet", CARNIVORE);

        public static Ingredient salade = new Ingredient("Salade", VEGETARIEN);

        public static Ingredient tomate = new Ingredient("Tomate", VEGETARIEN);

        public static Ingredient oignon = new Ingredient("Oignon", VEGETARIEN);

        public static Ingredient crevette = new Ingredient("Crevette", PESCETARIEN);

        public static Ingredient poisson = new Ingredient("Poisson", PESCETARIEN);

        public static Ingredient surimi = new Ingredient("Surimi", PESCETARIEN);

        public static List<Ingredient> ingredients = new List<Ingredient>()
        {
            viande,
            poulet,
            salade,
            tomate,
            oignon,
            crevette,
            poisson,
            surimi
        };

        public static void Display()
        {
            for(int i = 0; i<ingredients.Count; i++)
            {
                Console.WriteLine($"{i} - {ingredients[i].nom}");
            }
        }
    }
}
