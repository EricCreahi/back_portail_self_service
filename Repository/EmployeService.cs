using WebApi.Interfaces;
using WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Persistences;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Repository
{
    public class EmployeService : IEmploye
    {
        private readonly DbApiContext db;

        public EmployeService(DbApiContext db)
        {
            this.db = db;
        }

        public Employe AddOneEmploye(Employe employe)
        {
            if (employe != null && Exists(employe.Matricule) == false)
            {
                db.Employes.Add(employe);
            }
            else
            {
                employe = null;
            }
            return employe;

        }
        public void DeletedOneEmploye(string matricule)
        {
            if (matricule != null)
            {
                Employe employe = db.Employes.Find(matricule);
                db.Remove(employe);
            }
        }

        public bool Exists(string matricule)
        {
            return db.Employes.Any(e => e.Matricule == matricule);
        }

        public async Task<IEnumerable<Employe>> GetAllEmploye()
        {
          return await db.Employes              
          .Select(p => new Employe()
          {
                Matricule = p.Matricule,
                NomPrenoms = p.NomPrenoms,            
                Fonction = p.Fonction,
                Direction = p.Direction,         
                Statut = p.Statut
                   

          }).OrderByDescending(y => y.Matricule).ToListAsync();
        }

        public async Task<IEnumerable<Employe>> GetAllEmployeByDirection(string direction)
        {
            return await db.Employes
                  .Where(v => v.Direction == direction)
                  .Select(p => new Employe()
                  {
                        Matricule = p.Matricule,
                        NomPrenoms = p.NomPrenoms,
                        Fonction = p.Fonction,
                        Direction = p.Direction,
                        Statut = p.Statut
                                  

                  }).ToListAsync();
        }


        public Employe GetOneEmploye(string matricule)
        {
           // var nbre = string.Format("{0:000000}", double.Parse(matricule));
            return db.Employes              
                 .Select(p => new Employe()
                 {
                        Matricule = p.Matricule,
                        NomPrenoms = p.NomPrenoms,
                        Fonction = p.Fonction,
                        Direction = p.Direction,                         
                        Statut = p.Statut                                   

                 }).FirstOrDefault(o => o.Matricule == matricule);
        }

        public void UpdateOneEmploye(string matricule, Employe employe)
        {
            throw new System.NotImplementedException();
        }
    }
}
