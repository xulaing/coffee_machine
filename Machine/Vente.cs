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
        private readonly decimal _marge; // Marge 

        public Vente(Commande commande, decimal marge)
        {
            _commande = commande;
            _marge = marge;
        }

        // Calcul du prix de vente (coût de la recette + marge)
        public decimal GetSellingPrice(string recipeName)
        {
            decimal cost = _commande.GetRecipeCost(recipeName);
            decimal sellingPrice = cost * (1 + _marge);
            return sellingPrice;
        }
    }
}
