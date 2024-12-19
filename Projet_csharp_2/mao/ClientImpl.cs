using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_csharp_2.entity;

namespace Projet_csharp_2.mao
{
    internal class ClientImpl : IClient
    {
        private List<Client> clients = new List<Client>();

        
        public void AjouterClient(Client client)
        {
            clients.Add(client);
            Console.WriteLine($"Client ajouté avec succès ");
        }

        
        public void ModifierClient(int id, Client updatedClient)
        {
            var client = clients.Find(c => c.GetId() == id);
            if (client != null)
            {
                client.SetNom(updatedClient.GetNom());
                client.SetPrenom(updatedClient.GetPrenom());
                client.SetNumeroTel(updatedClient.GetNumeroTel());
                client.SetAgenceClient(updatedClient.GetAgenceClient());
                Console.WriteLine("Client mis à jour avec succès !");
            }
            else
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID : {id}");
            }
        }

        
        public void SupprimerClient(int id)
        {
            var client = clients.Find(c => c.GetId() == id);
            if (client != null)
            {
                clients.Remove(client);
                Console.WriteLine($"Client avec l'ID {id} supprimé avec succès !");
            }
            else
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID : {id}");
            }
        }

        
        public void AfficherClients()
        {
            
            if (clients.Count == 0)
            {
                Console.WriteLine("Aucun client disponible.");
            }
            else
            {
                Console.WriteLine("Liste des clients :");
                foreach (var client in clients)
                {
                    Console.WriteLine(client);
                }
            }
        }

        
        public Client GetClientById(int id)
        {
            var client = clients.Find(c => c.GetId() == id);
            if (client != null)
            {
                return client;
            }
            else
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID : {id}");
                return null;
            }
        }
    }
}
