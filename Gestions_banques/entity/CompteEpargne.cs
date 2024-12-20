using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions_banques.entity
{
    internal class CompteEpargne : Compte
    {
        private int duree;

        public int Duree { get => duree; set => duree = value; }

        public CompteEpargne(double solde, int duree)
            : base(solde)
        {
            this.Duree = duree;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Compte Épargne - Numéro: {NumeroCompte}, Solde: {Solde}, Durée: {Duree} mois");
        }
    }
}
