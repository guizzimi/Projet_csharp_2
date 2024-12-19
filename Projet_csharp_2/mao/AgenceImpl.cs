using System;
using System.Collections.Generic;
using Projet_csharp_2.entity;

namespace Projet_csharp_2.mao
{
    internal class AgenceImpl : IAgence
    {
        private List<Agence> agences = new List<Agence>();

        public void AjouterAgence(Agence agence)
        {
            agences.Add(agence);
            Console.WriteLine($"Agence ajoutée avec succès : {agence}");
        }

        public void Afficher()
        {
            Console.WriteLine("Liste des agences :");
            foreach (Agence agence in agences)
            {
                Console.WriteLine(agence);
            }
        }
        public Agence GetAgenceById(int id)
        {
            var agence = agences.Find(a => a.GetId() == id);
            if (agence != null)
            {
                return agence;
            }
            else
            {
                Console.WriteLine($"Aucune agence trouvée avec l'ID : {id}");
                return null;
            }
        }

        public void Modifier(int id, Agence updatedAgence)
        {
            var agence = agences.Find(a => a.GetId() == id);
            if (agence != null)
            {
                agence.SetCode(updatedAgence.GetCode());
                agence.SetLibelle(updatedAgence.GetLibelle());
                Console.WriteLine("Agence mise à jour !");
            }
            else
            {
                Console.WriteLine("Agence introuvable.");
            }
        }

        public void Supprimer(int id)
        {
            var agence = agences.Find(a => a.GetId() == id);
            if (agence != null)
            {
                agences.Remove(agence);
                Console.WriteLine("Agence supprimée !");
            }
            else
            {
                Console.WriteLine("Agence introuvable.");
            }
        }
        public void AfficherAgence()
        {
           
            if (agences.Count == 0)
            {
                Console.WriteLine("la liste est vide");
            }
            else
            {
                Console.WriteLine("Liste des agences :");
                foreach (var agence in agences)
                {
                    Console.WriteLine(agence);
                }
            }
        }
    }
}
