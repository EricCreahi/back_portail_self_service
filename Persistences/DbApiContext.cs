using WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Persistences
{
    public class DbApiContext: DbContext
    {

        public DbApiContext(DbContextOptions<DbApiContext> options): base(options)
        {

        }

          public DbSet<Body_card> Body_Cards { get; set; }
        public DbSet<DroitAcces> DroitAcces { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Audit> Audites { get; set; }
        public DbSet<Employe> Employes { get; set; }
 

    }


}
