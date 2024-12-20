using System;
using System.Collections.Generic;
using Gestions_banques.entity;
using Gestions_banques.Implemente;

namespace Gestions_banques
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Agence agence = new Agence("AG001", "Agence CBAO");
                Client client1 = new Client("AMADOU", "DIOUF", "773614746");
                Client client2 = new Client("MOUSTAPHA", "Diouf", "781070063");

                ICompte compte1 = new CompteSimple(5000, 10);
                ICompte compte2 = new CompteEpargne(20000, 12);

                client1.AjouterCompte(compte1);
                client2.AjouterCompte(compte2);

                agence.AjouterClient(client1);
                agence.AjouterClient(client2);

                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\nMENU PRINCIPAL");
                    Console.WriteLine("1. Afficher les détails de l'agence");
                    Console.WriteLine("2. Ajouter un client");
                    Console.WriteLine("3. Ajouter un compte");
                    Console.WriteLine("4. Quitter");
                    Console.Write("Choisissez une option: ");

                    if (int.TryParse(Console.ReadLine(), out int choix))
                    {
                        switch (choix)
                        {
                            case 1:
                                agence.AfficherDetails();
                                break;
                            case 2:
                                Console.Write("Prénom du client: ");
                                string prenom = Console.ReadLine();
                                Console.Write("Nom du client: ");
                                string nom = Console.ReadLine();
                                Console.Write("Téléphone du client: ");
                                string telephone = Console.ReadLine();

                                Client nouveauClient = new Client(prenom, nom, telephone);
                                agence.AjouterClient(nouveauClient);
                                Console.WriteLine("Client ajouté avec succès!");
                                break;
                            case 3:
                                Console.Write("ID du client pour ajouter un compte: ");
                                int clientId = int.Parse(Console.ReadLine());
                                var client = agence.Clients.Find(c => c.Id == clientId);
                                if (client != null)
                                {
                                    Console.WriteLine("Type de compte: 1. Simple, 2. Épargne");
                                    int typeCompte = int.Parse(Console.ReadLine());

                                    Console.Write("Solde initial: ");
                                    double solde = double.Parse(Console.ReadLine());

                                    if (typeCompte == 1)
                                    {
                                        Console.Write("Taux Couvert: ");
                                        double tauxCouvert = double.Parse(Console.ReadLine());
                                        ICompte compteSimple = new CompteSimple(solde, tauxCouvert);
                                        client.AjouterCompte(compteSimple);
                                    }
                                    else if (typeCompte == 2)
                                    {
                                        Console.Write("Durée (en mois): ");
                                        int duree = int.Parse(Console.ReadLine());
                                        ICompte compteEpargne = new CompteEpargne(solde, duree);
                                        client.AjouterCompte(compteEpargne);
                                    }

                                    Console.WriteLine("Compte ajouté avec succès!");
                                }
                                else
                                {
                                    Console.WriteLine("Client introuvable.");
                                }
                                break;
                            case 4:
                                exit = true;
                                Console.WriteLine("Au revoir!");
                                break;
                            default:
                                Console.WriteLine("Option invalide. Veuillez réessayer.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
                    }
                }
            }
        }
    }
