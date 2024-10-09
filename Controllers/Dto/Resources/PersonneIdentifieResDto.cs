using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Dto.Resources
{
    public class PersonneIdentifieResDto
    {

        public string Matricule { get; set; }
        public string NomPrenoms { get; set; }    
        public string Direction { get; set; }
        public string Fonction { get; set; }
        public string NumeroTelphone { get; set; }
        public string UserIdCreation { get; set; }
        public DateTime DateUserIdCreation { get; set; }
        public string UserIdModification { get; set; }
        public DateTime DateUserIdModification { get; set; }
        public string EquipeAffectation { get; set; } // le nom de l'equipe à qui est affecte le numero flotte ;
        public string MembreEquipe { get; set; }  // matricule de ce lui à qui appartient le numéro



    }
}
