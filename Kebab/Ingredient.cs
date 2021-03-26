using System;
using System.Collections.Generic;
using System.Text;

namespace Kebab
{
    public class Ingredient
    {
        public string nom;
        public bool vegetal;

        public Ingredient(string nom, bool vegetal)
        {
            this.nom = nom;
            this.vegetal = vegetal;
        }

        public static Ingredient viande = new Ingredient("Viande", false);

        public static Ingredient salade = new Ingredient("Salade", true);

        public static Ingredient tomate = new Ingredient("Tomate", true);

        public static Ingredient oignon = new Ingredient("Oignon", true);
    }
}
