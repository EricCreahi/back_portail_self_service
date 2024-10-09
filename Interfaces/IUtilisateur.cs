using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IUtilisateur
    {
        public bool  PremierConnexion { get; set; }
        IEnumerable<Utilisateur> GetAllUtilisateur();  

        Utilisateur getOneutilisateur(string loginuser);
        Utilisateur getOneutilisateurByMatricule(string matricule);
        void UpdateOneUtilisateur(string matricule, Utilisateur utilisateur);
     
        Utilisateur Authentification(string login, string motDePasse);
        bool Exists(string UserId);


    }
}
