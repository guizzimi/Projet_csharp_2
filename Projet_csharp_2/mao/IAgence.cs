using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_csharp_2.entity;

namespace Projet_csharp_2.mao
{
    internal interface IAgence
    {
        void AjouterAgence(Agence agence);
        void Afficher();
        void Modifier(int id, Agence updatedAgence);
        void Supprimer(int id);


    }
}
