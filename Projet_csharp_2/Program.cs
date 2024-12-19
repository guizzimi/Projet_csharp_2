using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_csharp_2.entity;
using Projet_csharp_2.mao;

namespace Projet_csharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgenceImpl gestionAgence = new AgenceImpl();
            ClientImpl gestionClient = new ClientImpl();
            CompteImpl gestionCompte = new CompteImpl();

            int choixM;
            do
            {
                Console.WriteLine("--------Bienvenue-------");
                Console.WriteLine("   1-- CRUD Agence");
                Console.WriteLine("   2-- CRUD  client");
                Console.WriteLine("   3-- CRUD  compte");
                Console.WriteLine("    4-- quitter");
                choixM = int.Parse(Console.ReadLine());

                switch (choixM)
                {
                    case 1:

                        int choix1;
                        do
                        {

                            Console.WriteLine("   1-- creer Agence");
                            Console.WriteLine("   2-- modifier Agence");
                            Console.WriteLine("   3-- supprimmer Agence");
                            Console.WriteLine("   4 -- Afficher Agence");
                            Console.WriteLine("   5--quitter gestion agence");
                            choix1 = int.Parse(Console.ReadLine());
                            switch (choix1)
                            {
                                case 1:
                                    Console.WriteLine("donner le code de l agence");
                                    String code = Console.ReadLine();

                                    Agence agence = new Agence(code);
                                    gestionAgence.AjouterAgence(agence);
                                    break;
                                case 2:

                                    Console.WriteLine("Donnez l'ID de l'agence à modifier :");
                                    if (int.TryParse(Console.ReadLine(), out int idModifier))
                                    {

                                        Agence agenceExistante = gestionAgence.GetAgenceById(idModifier);
                                        if (agenceExistante != null)
                                        {
                                            Console.WriteLine("Donnez le nouveau code de l'agence :");
                                            string codeCh = Console.ReadLine();

                                            Agence agenceModifiee = new Agence(codeCh);
                                            gestionAgence.Modifier(idModifier, agenceModifiee);
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Aucune agence trouvée avec l'ID : {idModifier}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("L'ID saisi est invalide. Veuillez entrer un entier.");
                                    }

                                    break;
                                case 3:

                                    Console.WriteLine("Donnez l'ID de l'agence à supprimer :");
                                    if (int.TryParse(Console.ReadLine(), out int idSupprimer))
                                    {

                                        Agence agenceExistante = gestionAgence.GetAgenceById(idSupprimer);
                                        if (agenceExistante != null)
                                        {

                                            gestionAgence.Supprimer(idSupprimer);
                                            Console.WriteLine("Agence supprimée avec succès !");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Aucune agence trouvée avec l'ID : {idSupprimer}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("L'ID saisi est invalide. Veuillez entrer un entier.");
                                    }
                                    break;
                                case 4:
                                    gestionAgence.AfficherAgence();
                                    break;
                                default:
                                    Console.WriteLine("siasir un nombre entre 1 et 5");
                                    break;
                            }
                        } while (choix1 != 5);

                        break;
                    case 2:

                        int choix2;
                        do
                        {
                            Console.WriteLine("    1-- creer Client");
                            Console.WriteLine("    2-- modifier client");
                            Console.WriteLine("    3-- supprimmer client");
                            Console.WriteLine("    4-- Afficher Client");
                            Console.WriteLine("    5-- quitter gestion client");
                            choix2 = int.Parse(Console.ReadLine());
                            switch (choix2)
                            {
                                case 1:
                                    Console.WriteLine("donner le nom du client");
                                    String nom = Console.ReadLine();
                                    Console.WriteLine("donner le prenom du client");
                                    String prenom = Console.ReadLine();
                                    Console.WriteLine("donner le numero de telephone du client");
                                    String NumeroTel = Console.ReadLine();
                                    Console.WriteLine("donner l id de l agende du client");
                                    int id = int.Parse(Console.ReadLine());

                                    Agence agence = gestionAgence.GetAgenceById(id);

                                    Client client = new Client(nom, prenom, NumeroTel, agence);
                                    gestionClient.AjouterClient(client);
                                    break;
                                case 2:
                                    Console.WriteLine("donner l id de l agende du client");
                                    int id1 = int.Parse(Console.ReadLine());
                                    if (id1 > 0)
                                    {
                                        Client clientExistant = gestionClient.GetClientById(id1);
                                        if (clientExistant != null)
                                        {

                                            Console.WriteLine("donner le nom du client");
                                            String nom1 = Console.ReadLine();
                                            Console.WriteLine("donner le prenom du client");
                                            String prenom1 = Console.ReadLine();
                                            Console.WriteLine("donner le numero de telephone du client");
                                            String NumeroTel1 = Console.ReadLine();

                                            Console.WriteLine("donner l id de l agende du client");
                                            int idA = int.Parse(Console.ReadLine());

                                            Agence agence2 = gestionAgence.GetAgenceById(idA);

                                            Client clientModifier = new Client(nom1, prenom1, NumeroTel1, agence2);

                                            gestionClient.ModifierClient(clientExistant.GetId(), clientModifier);

                                        }
                                        else
                                        {
                                            Console.WriteLine("le client n exite pas donner un id valide");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("veuiller donner un id positif ou nul");
                                    }

                                    break;
                                case 3:
                                    Console.WriteLine("donner l id du client a supprimer");
                                    int idC = int.Parse(Console.ReadLine());
                                    if (idC > 0)
                                    {
                                        Client clientExistante = gestionClient.GetClientById(idC);
                                        if (clientExistante != null)
                                        {
                                            gestionClient.SupprimerClient(idC);
                                        }
                                        else
                                        {
                                            Console.WriteLine("le clent n existe pas");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("l id doit etre un entier positif");
                                    }
                                    break;
                                case 4:
                                    gestionClient.AfficherClients();
                                    break;
                                default:
                                    Console.WriteLine("siasir un nombre entre 1 et 5");
                                    break;
                            }
                        } while (choix2 != 5);
                     break;
                    case 3:
                        int choix3;
                        do
                        {
                            Console.WriteLine("    1-- creer Compte");
                            Console.WriteLine("    2-- modifier compte");
                            Console.WriteLine("    3-- supprimmer compte");
                            Console.WriteLine("    4-- Afficher compte");
                            Console.WriteLine("    5-- quitter gestion compte");
                            choix3 = int.Parse(Console.ReadLine());
                            switch (choix3)
                            {
                                case 1:
                                    Console.WriteLine("quelle type de compte voulez vous creer");
                                    Console.WriteLine("1 --- CompteSimple");
                                    Console.WriteLine("2--- CompteEpargne");
                                    int typeCompte;
                                    bool valider = false;
                                    do
                                    {

                                        string input = Console.ReadLine();

                                        if (int.TryParse(input, out typeCompte) && (typeCompte == 1 || typeCompte == 2))
                                        {
                                            valider = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("choisir entre 1 pour Compte simple ou 2 pour compte epargne");
                                        }
                                    } while (!valider);
                                    Console.WriteLine("donner le solde du compte");
                                    double solde = int.Parse(Console.ReadLine());
                                    
                                    
                                    Console.WriteLine("donner l id du titulaire de ce compte");
                                    int id = int.Parse(Console.ReadLine());
                                    Client client = gestionClient.GetClientById(id);
                                    if (typeCompte == 1)
                                    {
                                        Console.WriteLine("donner le taux decouvert");
                                        double tauxDecouvert = int.Parse(Console.ReadLine());
                                        gestionCompte.AjouterCompte(new CompteSimple(solde,tauxDecouvert,client));
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("donner la duree");
                                        int duree = int.Parse(Console.ReadLine());
                                        gestionCompte.AjouterCompte(new CompteEpargne( solde, duree, client));
                                    }
                                    
                                   
                                    break;
                                case 2:
                                    Console.WriteLine("donner l id du compte que vous voulez modifier");
                                    int id1 = int.Parse(Console.ReadLine());
                                    if (id1 > 0)
                                    {
                                        Compte compteExistant = gestionCompte.GetCompteById(id1);
                                        if (compteExistant != null)
                                        {
                                            Console.WriteLine("donner le nouveau solde");
                                            double solde1 = double.Parse(Console.ReadLine());
                                            
                                            Client client2 = compteExistant.GetTitulaire();
                                            if (compteExistant is CompteSimple)
                                            {
                                                Console.WriteLine("donner le taux Decouvert du compte Simple");
                                                double tauxDecouvert1 = double.Parse(Console.ReadLine());
                                                Compte compteSimple = new CompteSimple( solde1, tauxDecouvert1 ,client2);
                                                gestionCompte.ModifierCompte(id1 ,compteSimple);
                                            }
                                            else
                                            {
                                                Console.WriteLine("donner le taux Decouvert du compte Epargne");
                                                int duree1 = int.Parse(Console.ReadLine());
                                                Compte compteEpargne = new CompteEpargne( solde1, duree1, client2);
                                                gestionCompte.ModifierCompte(id1, compteEpargne);
                                            }
                                        }
                                    }
                                        break;
                                case 3:
                                    Console.WriteLine("donner l id du compte a supprimer");
                                    int idC = int.Parse(Console.ReadLine());
                                    if (idC > 0)
                                    {
                                        Compte compteExistant = gestionCompte.GetCompteById(idC);
                                        if (compteExistant != null)
                                        {
                                            gestionCompte.SupprimerCompte(idC);
                                        }
                                        else
                                        {
                                            Console.WriteLine("le compte n existe pas");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("l id doit etre un entier positif");
                                    }
                                    break;
                                case 4:
                                    gestionCompte.AfficherComptes();
                                break;
                                default:
                                    Console.WriteLine("siasir un nombre entre 1 et 5");
                                    break;
                            }
                                
                                  

                        } while (choix3 != 5) ;
                        break;
                    default:
                        Console.WriteLine("faite un cgoix entre 1 et 4");
                        break;
                 } 

             } while (choixM != 4);
        }
    }
}
