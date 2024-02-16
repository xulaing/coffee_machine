using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distributeur_De_Boisson_Chaude.Boisson;

namespace Distributeur_De_Boisson_Chaude.Machine
{
    public class Commande
    {
        private readonly List<Recipe> _recipes;

        public Commande(List<Recipe> recipes)
        {
            _recipes = recipes;
        }

        // Calcul du prix de la recette
        public decimal GetRecipeCost(string recipeName)
        {
            // Récupération de la recette de la boisson choisie
            var recipe = _recipes.Find(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
            if (recipe == null)
            {
                throw new ArgumentException("Recipe not found", nameof(recipeName));
            }

            // Calcul du prix en foncion des ingrédients et quantité
            decimal totalCost = 0;
            foreach (var ingredientAndQuantity in recipe.Ingredients)
            {
                // ingredientAndQuantity est un dictionnaire <Ingredient, int> contenant l'ingrédient en clé et la quantité en valeur
                totalCost += ingredientAndQuantity.Key.Cost * ingredientAndQuantity.Value;
            }

            return totalCost;
        }
    }
}
