using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur_De_Boisson_Chaude.Boisson
{
    public interface IIngredient
    {
        string Name { get; }
        decimal Cost { get; }
    }

    public class Ingredient : IIngredient
    {
        public string Name { get; }
        public decimal Cost { get; }

        public Ingredient(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }

    public static class IngredientsProvider
    {
        // Initialisation de la liste des ingrédients
        public static List<IIngredient> GetIngredients()
        {
            var ingredients = new List<IIngredient>
        {
            new Ingredient("Café", 1),
            new Ingredient("Sucre", 0.1m),
            new Ingredient("Crème", 0.5m),
            new Ingredient("Thé", 2),
            new Ingredient("Eau", 0.2m),
            new Ingredient("Chocolat", 1),
            new Ingredient("Lait", 0.4m)
        };

            return ingredients;
        }
    }
}
