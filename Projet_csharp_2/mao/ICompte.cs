using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_csharp_2.entity;

namespace Projet_csharp_2.mao
{
    internal interface ICompte
    {
        void AjouterCompte(Compte compte);
        void ModifierCompte(int id, Compte compteModifieru);
        void SupprimerCompte(int id);
        void AfficherComptes();
        Compte GetCompteById(int id);
    }
}
