using System;

namespace Kebab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, qu'est-ce que je vous sert ?");

            Kebab kebab = new Kebab();

            do
            {
                Console.WriteLine("Choisissez un ingrédient.");
                Ingredient.Display();

                int ing = -1;
                do
                {
                    string read = Console.ReadLine();
                    if(!Int32.TryParse(read, out ing))
                    {
                        ing = -1;
                        Console.WriteLine("Oups j'ai pas compris ce que vous avez dit...");
                    }

                    if(ing > Ingredient.ingredients.Count-1)
                    {
                        ing = -1;
                        Console.WriteLine("Oups j'ai pas compris ce que vous avez dit...");
                    }
                } while (ing < 0);

                Console.WriteLine("Eh, dis donc j'en mets combien ?");
                int quantity = -1;
                do
                {
                    string read = Console.ReadLine();
                    if (!Int32.TryParse(read, out quantity))
                    {
                        quantity = -1;
                        Console.WriteLine("Oups j\'ai pas compris ce que vous avez dit...");
                    }
                } while (quantity < 0);

                kebab.ingredients.Add(Ingredient.ingredients[ing], quantity);

                Console.WriteLine();
                kebab.Display();
                Console.WriteLine("Je vous rajoute autre chose ? ENTER");

            } while (Console.ReadKey().Key == ConsoleKey.Enter);

            Console.WriteLine();
            if (kebab.IsVegetable())
            {
                Console.WriteLine("C'est un joli kebab végétarien pour la madame !");
            }
            else
            {
                Console.WriteLine("C'est un joli kebab cannibale pour le monsieur !");
            }

            Console.ReadLine();
            
        }
    }
}
