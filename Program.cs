using Distributeur_De_Boisson_Chaude.Machine;
using Distributeur_De_Boisson_Chaude.Boisson;
using System;
using System.Collections.Generic;

namespace Distributeur
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisation des données
            List<Ingredient> ingredients = Menu.GetIngredients();
            List<Recipe> recipes = Menu.GetRecipes(ingredients);
            Commande commande = new Commande(recipes);
            Vente vente = new Vente(commande);

            // Interface utilisateur
            while (true)
            {
                while (true)
                {
                    // Association d'un chiffre à chaque recette
                    for (int i = 0; i < recipes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {recipes[i].Name}");
                    }

                    // Input utilisateur sur le choix de la recette
                    Console.WriteLine("Entrez le numéro de la boisson que vous souhaitez commander (ou '0' pour quitter) : ");
                    string input = Console.ReadLine();

                    // Choix de sortie
                    if (input == "0")
                        break;

                    // Choix d'une boisson existante
                    if (int.TryParse(input, out int choice) && choice >= 1 && choice <= recipes.Count)
                    {
                        try
                        {
                            string selectedRecipeName = recipes[choice - 1].Name;
                            decimal price = vente.GetSellingPrice(selectedRecipeName);
                            Console.WriteLine($"Prix de vente de {selectedRecipeName} : {price} €");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Boisson non trouvée. Veuillez réessayer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrée invalide. Veuillez entrer le numéro correspondant à la boisson que vous souhaitez commander.");
                    }

                    Console.WriteLine("Souhaitez-vous commander une autre boisson ? (o/n) : ");
                    string continueInput = Console.ReadLine();
                    if (continueInput.ToLower() != "o")
                        break;
                }

                Console.WriteLine("Merci pour votre visite !");
                Console.WriteLine("Appuyez sur n'importe quelle touche pour quitter.");
                Console.ReadKey();
                return;
            }
        }
    }
}
