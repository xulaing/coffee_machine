using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur_De_Boisson_Chaude.Boisson
{
    public class Ingredient
    {
        public string Name { get; }
        public decimal Cost { get; }

        // Définition des ingrédients comme des propriétés statiques pour un accès facile
        public static Ingredient Café { get; } = new Ingredient("Café", 1);
        public static Ingredient Sucre { get; } = new Ingredient("Sucre", 0.1m);
        public static Ingredient Crème { get; } = new Ingredient("Crème", 0.5m);
        public static Ingredient Thé { get; } = new Ingredient("Thé", 2);
        public static Ingredient Eau { get; } = new Ingredient("Eau", 0.2m);
        public static Ingredient Chocolat { get; } = new Ingredient("Chocolat", 1);
        public static Ingredient Lait { get; } = new Ingredient("Lait", 0.4m);

        public Ingredient(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
