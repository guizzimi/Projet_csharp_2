using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_csharp_2.mao;

namespace Projet_csharp_2.entity
{
    internal abstract class Compte
    {
        static int nextid = 1;
        protected int Id { get; set; }
        protected string NumeroCompte { get; set; }
        protected double Solde { get; set; }

        protected Client Titulaire { get; set; }

        public Compte( double solde, Client titulaire)
        {
            this.Id = nextid++;
            this.NumeroCompte = GenererNumeroCompte();
            this.Solde = solde;
            this.Titulaire = titulaire;
        }
        private string GenererNumeroCompte()
        {
            if (Titulaire != null)
            {
                
                return $"000{Id}{Titulaire.GetNumeroTel()}";
            }
            else
            {
                return $"000{Id}0000000000"; 
            }
        }


        public int GetId()
        {
            return this.Id;
        }

        public string GetNumeroCompte()
        {
            return this.NumeroCompte;
        }

        public void SetNumeroCompte(string numeroCompte)
        {
            this.NumeroCompte = numeroCompte;
        }

        public double GetSolde()
        {
            return this.Solde;
        }

        public Client GetTitulaire()
        {
            return this.Titulaire;
        }

        public void SetSolde(double solde)
        {
            this.Solde = solde;
        }

        public override string ToString()
        {
            return $"Compte [ID: {Id}, Numéro: {NumeroCompte}, Solde: {Solde}, Titulaire: {Titulaire}]";
        }

        public void SetTitulaire(Client titulaire)
        {
            this.Titulaire = titulaire;

            
            this.NumeroCompte = GenererNumeroCompte();
        }



    }
}
