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

        public static Ingredient blanche = new Ingredient("Sauce Blanche", VEGETARIEN);

        public static Ingredient bechamel = new Ingredient("Sauce Béchamel", VEGETARIEN);

        public static Ingredient algerienne = new Ingredient("Sauce Algérienne", VEGETARIEN);

        public static Ingredient ketchup = new Ingredient("Sauce Ketchup", VEGETARIEN);

        public static Ingredient mayo = new Ingredient("Sauce Mayo", VEGETARIEN);

        public static Ingredient moutarde = new Ingredient("Sauce Moutarde", VEGETARIEN);

        public static Ingredient barbecue = new Ingredient("Sauce Barbecue", VEGETARIEN);

        public static Ingredient samourai = new Ingredient("Sauce Samouraï", VEGETARIEN);

        public static Ingredient cheddar = new Ingredient("Cheddar", VEGETARIEN);

        public static Ingredient raclette = new Ingredient("Raclette", VEGETARIEN);

        public static Ingredient maroille = new Ingredient("Maroille", VEGETARIEN);

        public static List<Ingredient> ingredients = new List<Ingredient>()
        {
            viande,
            poulet,
            salade,
            tomate,
            oignon,
            crevette,
            poisson,
            surimi,
            cheddar,
            raclette,
            maroille,
            blanche,
            bechamel,
            algerienne,
            ketchup,
            mayo,
            moutarde,
            barbecue,
            samourai
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
