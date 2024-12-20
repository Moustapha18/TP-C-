using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Gestions_banques.Implemente;

namespace Gestions_banques.entity
{
    internal class Client : IClient
    {
        private static int compteurId = 1;
        private int id;
        private string prenom;
        private string nom;
        private string telephone;
        private List<ICompte> comptes = new List<ICompte>();

        public int Id { get => id; private set => id = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public List<ICompte> Comptes { get => comptes; }

        public Client(string prenom, string nom, string telephone)
        {
            this.Id = compteurId++;
            this.Prenom = prenom;
            this.Nom = nom;
            this.Telephone = telephone;
        }

        public void AjouterCompte(ICompte compte)
        {
            Comptes.Add(compte);
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"Client ID: {Id}, Prénom: {Prenom}, Nom: {Nom}, Téléphone: {Telephone}");
            foreach (var compte in Comptes)
            {
                compte.AfficherDetails();
            }
        }
    }
}
