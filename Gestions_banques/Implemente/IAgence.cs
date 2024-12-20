using System;
using System.Collections.Generic;
using Gestions_banques.entity;

namespace Gestions_banques.Implemente
{
    // Interface pour les fonctionnalités d'une agence
    internal interface IAgence
    {
        void AjouterClient(Client client);
        void AfficherDetails();
    }
}
