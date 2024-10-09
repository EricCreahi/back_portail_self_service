using WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Interfaces
{
    public interface IEmploye
    {
        Employe AddOneEmploye(Employe employe);
        Task<IEnumerable<Employe>> GetAllEmploye();      
        Task<IEnumerable<Employe>> GetAllEmployeByDirection(string direction);
        Employe GetOneEmploye(string matricule);

        void UpdateOneEmploye(string matricule, Employe employe);
        void DeletedOneEmploye(string matricule);
      
        bool Exists(string matricule);

    }
}
