using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur_De_Boisson_Chaude.Boisson
{
    public class Recipe
    {
        // Nom de la recette
        public string Name { get; }
        // Ingrédients et quantité
        public Dictionary<IIngredient, int> Ingredients { get; }

        public Recipe(string name, Dictionary<IIngredient, int> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }

    public static class RecipesProvider
    {
        // Initialisation de la liste des recettes
        public static List<Recipe> GetRecipes(List<IIngredient> ingredients)
        {
            var recipes = new List<Recipe>();

            var expressoIngredients = new Dictionary<IIngredient, int>
        {
            { FindIngredientByName(ingredients, "Café"), 1 },
            { FindIngredientByName(ingredients, "Eau"), 1 }
        };
            recipes.Add(new Recipe("Expresso", expressoIngredients));

            var allongeIngredients = new Dictionary<IIngredient, int>
        {
            { FindIngredientByName(ingredients, "Café"), 1 },
            { FindIngredientByName(ingredients, "Eau"), 2 }
        };
            recipes.Add(new Recipe("Allongé", allongeIngredients));

            var capuccinoIngredients = new Dictionary<IIngredient, int>
        {
            { FindIngredientByName(ingredients, "Café"), 1 },
            { FindIngredientByName(ingredients, "Eau"), 1 },
            { FindIngredientByName(ingredients, "Crème"), 1 },
            { FindIngredientByName(ingredients, "Chocolat"), 1 }
        };
            recipes.Add(new Recipe("Capuccino", capuccinoIngredients));

            var chocolatIngredients = new Dictionary<IIngredient, int>
        {
            { FindIngredientByName(ingredients, "Chocolat"), 3 },
            { FindIngredientByName(ingredients, "Lait"), 2 },
            { FindIngredientByName(ingredients, "Eau"), 1 },
            { FindIngredientByName(ingredients, "Sucre"), 1 }
        };
            recipes.Add(new Recipe("Chocolat", chocolatIngredients));

            var theIngredients = new Dictionary<IIngredient, int>
        {
            { FindIngredientByName(ingredients, "Thé"), 1 },
            { FindIngredientByName(ingredients, "Eau"), 2 }
        };
            recipes.Add(new Recipe("Thé", theIngredients));

            // Ajout des recettes ici...

            return recipes;
        }

        // Recherche d'un ingrédient par son nom
        private static IIngredient FindIngredientByName(List<IIngredient> ingredients, string name)
        {
            IIngredient ingredient = ingredients.Find(i => i.Name == name);
            if (ingredient == null)
            {
                throw new InvalidOperationException($"Ingredient '{name}' not found.");
            }
            return ingredient;
        }
    }
}
