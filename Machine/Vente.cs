using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur_De_Boisson_Chaude.Machine
{
    public class Vente
    {
        private readonly Commande _commande;
        // Marge de 30%
        private const decimal Marge = 0.3m;

        public Vente(Commande commande)
        {
            _commande = commande;
        }

        // Calcul du prix de vente (coût de la recette + marge)
        public decimal GetSellingPrice(string recipeName)
        {
            decimal cost = _commande.GetRecipeCost(recipeName);
            decimal sellingPrice = cost * (1 + Marge);
            return sellingPrice;
        }
    }

}
