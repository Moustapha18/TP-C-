using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestions_banques.entity;

namespace Gestions_banques.Implemente
{
    internal interface IClient
    {
        void AjouterCompte(ICompte compte);
        void AfficherDetails();
    }
}