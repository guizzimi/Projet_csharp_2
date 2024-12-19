using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_csharp_2.entity
{
    internal class CompteEpargne : Compte
    {
        protected int Duree { get; set; }

        public CompteEpargne( double solde, int duree, Client titulaire)
            : base( solde, titulaire)
        {
            this.Duree = duree;
        }

        public int GetDuree()
        {
            return this.Duree;
        }

        public void SetDuree(int duree)
        {
            this.Duree = duree;
        }

        public override string ToString()
        {
            return $"Compte Epargne [ID: {Id}, Numéro: {NumeroCompte}, Solde: {Solde}, Durée: {Duree} mois, Titulaire: {Titulaire}]";
        }


    }
}
