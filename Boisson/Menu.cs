using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distributeur_De_Boisson_Chaude.Boisson;

namespace Distributeur_De_Boisson_Chaude.Boisson
{
    public static class Menu
    {
        // Initialisation de la liste des ingrédients
        public static List<Ingredient> GetIngredients()
        {
            var ingredients = new List<Ingredient>
        {
            Ingredient.Café,
            Ingredient.Sucre,
            Ingredient.Crème,
            Ingredient.Thé,
            Ingredient.Eau,
            Ingredient.Chocolat,
            Ingredient.Lait
        };

            return ingredients;
        }

        // Initialisation de la liste des recettes
        public static List<Recipe> GetRecipes(List<Ingredient> ingredients)
        {
            var recipes = new List<Recipe>();

            // Define recipes using ingredients
            var expressoIngredients = new Dictionary<Ingredient, int>
        {
            { Ingredient.Café, 1 },
            { Ingredient.Eau, 1 }
        };
            recipes.Add(new Recipe("Expresso", expressoIngredients));

            var allongeIngredients = new Dictionary<Ingredient, int>
        {
            { Ingredient.Café, 1 },
            { Ingredient.Eau, 2 }
        };
            recipes.Add(new Recipe("Allongé", allongeIngredients));

            var capuccinoIngredients = new Dictionary<Ingredient, int>
        {
            { Ingredient.Café, 1 },
            { Ingredient.Eau, 1 },
            { Ingredient.Crème, 1 },
            { Ingredient.Chocolat, 1 }
        };
            recipes.Add(new Recipe("Capuccino", capuccinoIngredients));

            var chocolatIngredients = new Dictionary<Ingredient, int>
        {
            { Ingredient.Chocolat, 3 },
            { Ingredient.Lait, 2 },
            { Ingredient.Eau, 1 },
            { Ingredient.Sucre, 1 }
        };
            recipes.Add(new Recipe("Chocolat", chocolatIngredients));

            var theIngredients = new Dictionary<Ingredient, int>
        {
            { Ingredient.Thé, 1 },
            { Ingredient.Eau, 2 },
        };
            recipes.Add(new Recipe("Thé", theIngredients));


            // Ajouter des recettes ici...

            return recipes;
        }
    }
}
