using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestions_banques.Implemente;

namespace Gestions_banques.entity
{
    internal  class Agence : IAgence
    {
        private static int compteurId = 1;
        private int id;
        private string code;
        private string libelle;
        private List<Client> clients = new List<Client>();

        public int Id { get => id; private set => id = value; }
        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public List<Client> Clients { get => clients; }

        public Agence(string code, string libelle)
        {
            Id = compteurId++;
            Code = code;
            Libelle = libelle;
        }


        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }

        public void AfficherDetails()
        {
            Console.WriteLine($"Agence ID: {Id}, Code: {Code}, Libellé: {Libelle}");
            foreach (var client in Clients)
            {
                client.AfficherDetails();
            }
        }
    }
}