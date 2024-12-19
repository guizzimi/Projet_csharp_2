using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_csharp_2.entity;

namespace Projet_csharp_2.mao
{
    internal interface IClient
    {
        void AjouterClient(Client client);
        void ModifierClient(int id, Client updatedClient);
        void SupprimerClient(int id);
        void AfficherClients();
        Client GetClientById(int id);
    }
}
