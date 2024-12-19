using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_csharp_2.entity;

namespace Projet_csharp_2.mao
{
    internal class CompteImpl 
    {
        private List<Compte> comptes = new List<Compte>();
        public void AjouterCompte(Compte compte)
        {
            comptes.Add(compte);
            Console.WriteLine($"Compte ajouté avec succès ");
        }

        public void ModifierCompte(int id, Compte compteModifier)
        {
            var compte = comptes.Find(c => c.GetId() == id);
            if (compte != null)
            {
                compte.SetSolde(compteModifier.GetSolde());
                compte.SetNumeroCompte(compteModifier.GetNumeroCompte());
                Console.WriteLine("compte modifier");

            }
            else
            {
                Console.WriteLine("ce compte n existe pas");

            }
        }

        public void SupprimerCompte(int id)
        {
            var compte = comptes.Find(c => c.GetId() == id);

            if (compte != null)
            {
                comptes.Remove(compte);
                Console.WriteLine("compte supprimer avec succes");
            }
            else
            {
                Console.WriteLine("ce compte n existe pas");

            }

        }
        public void AfficherComptes()
        {
            
            if (comptes.Count == 0)
            {
                Console.Write("la liste est vide");
            }
            else
            {
                Console.WriteLine("Liste des comptes :");
                foreach (var compte in comptes)
                {
                    Console.WriteLine(compte);
                }
            }
        }

        public Compte GetCompteById(int id)
        {
            var compte = comptes.Find(c => c.GetId() == id);
            if (compte != null)
            {
                return compte;
            }
            else
            {
                Console.WriteLine($"Aucun compte trouvé avec l'ID : {id}");
                return null;
            }
        }

        
    }
}
