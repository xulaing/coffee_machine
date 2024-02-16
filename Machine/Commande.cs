using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distributeur_De_Boisson_Chaude.Boisson;

namespace Distributeur_De_Boisson_Chaude.Machine
{
    public class Commande {
        private readonly List<Recipe> _recipes;

        public Commande(List<Recipe> recipes)
        {
            _recipes = recipes;
        }

        // Calcul du prix de la recette
        public decimal GetRecipeCost(string recipeName)
        {
            var recipe = FindRecipeByName(recipeName);
            if (recipe == null)
            {
                throw new ArgumentException("Recipe not found", nameof(recipeName));
            }

            decimal totalCost = CalculateTotalCost(recipe);
            return totalCost;
        }

        // Recherche d'une recette par son nom
        private Recipe FindRecipeByName(string recipeName)
        {
            return _recipes.Find(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
        }

        // Calcul du coût total d'une recette
        private decimal CalculateTotalCost(Recipe recipe)
        {
            decimal totalCost = 0;
            foreach (var ingredientAndQuantity in recipe.Ingredients)
            {
                totalCost += ingredientAndQuantity.Key.Cost * ingredientAndQuantity.Value;
            }
            return totalCost;
        }
    }
}

