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
        public Dictionary<Ingredient, int> Ingredients { get; }

        public Recipe(string name, Dictionary<Ingredient, int> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }

}
