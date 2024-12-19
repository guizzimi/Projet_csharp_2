using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_csharp_2.entity
{
    internal class CompteSimple : Compte
    {
        protected double TauxDecouvert { get; set; }

        public CompteSimple( double solde, double tauxDecouvert, Client titulaire)
            : base(  solde, titulaire)
        {
            this.TauxDecouvert = tauxDecouvert;
        }

        public double GetTauxDecouvert()
        {
            return this.TauxDecouvert;
        }

        public void SetTauxDecouvert(double tauxDecouvert)
        {
            this.TauxDecouvert = tauxDecouvert;
        }

        public override string ToString()
        {
            return $"Compte Simple [ID: {Id}, Numéro: {NumeroCompte}, Solde: {Solde}, Taux Découvert: {TauxDecouvert}%, Titulaire: {Titulaire}]";
        }


    }
}
