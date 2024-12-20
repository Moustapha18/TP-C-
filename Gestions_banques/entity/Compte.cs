using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestions_banques.Implemente;
using static Gestions_banques.entity.Compte;

namespace Gestions_banques.entity
{
    internal abstract class Compte : ICompte
    {
        private static int compteurId = 1000;
        private int id;
        private double solde;
        private string numeroCompte;

        public int Id { get => id; private set => id = value; }
        public double Solde { get => solde; set => solde = value; }
        public string NumeroCompte { get => numeroCompte; private set => numeroCompte = value; }

        protected Compte(double solde)
        {
            this.Id = compteurId++;
            this.Solde = solde;
            this.NumeroCompte = "CPT-" + Id;
        }

        public abstract void AfficherDetails();
    }
}