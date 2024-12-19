using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_csharp_2.entity
{
    internal class Client
    {
        static int nextid = 1;
        private int Id { get; set; }
        private string Prenom { get; set; }
        private string Nom { get; set; }
        private string NumeroTel { get; set; }

        private Agence AgenceClient { get; set; }
        public Client(string prenom, string nom, string Numerotel, Agence agenceClient)
        {
            this.Id = nextid++;
            this.Prenom = prenom;
            this.Nom = nom;
            this.NumeroTel = Numerotel;
            this.AgenceClient = agenceClient;
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetNom()
        {
            return this.Nom;
        }

        public void SetNom(string nom)
        {
            this.Nom = nom;
        }

        public string GetPrenom()
        {
            return this.Prenom;
        }

        public void SetPrenom(string prenom)
        {
            this.Prenom = prenom;
        }

        public string GetNumeroTel()
        {
            return this.NumeroTel ?? "0000000000"; 
        }

        public void SetNumeroTel(string numeroTel)
        {
            this.NumeroTel = numeroTel;
        }

        public Agence GetAgenceClient()
        {
            return this.AgenceClient;
        }

        public void SetAgenceClient(Agence agence)
        {
            this.AgenceClient = agence;
        }

        
        public override string ToString()
        {
            return $"Client [ID: {Id}, Nom: {Nom}, Prénom: {Prenom}, Téléphone: {NumeroTel}, Agence: {AgenceClient}]";
        }

       

    }
}
