using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions_banques.entity
{
    internal class CompteSimple : Compte
    {
        private double tauxCouvert;

        public double TauxCouvert { get => tauxCouvert; set => tauxCouvert = value; }

        public CompteSimple(double solde, double tauxCouvert)
            : base(solde)
        {
            this.TauxCouvert = tauxCouvert;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Compte Simple - Numéro: {NumeroCompte}, Solde: {Solde}, Taux Couvert: {TauxCouvert}%");
        }
    }
}
