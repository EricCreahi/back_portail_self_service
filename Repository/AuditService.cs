using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Persistences;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Repository
{
    public class AuditService : IAudit
    {
        private readonly DbApiContext db;

        public AuditService(DbApiContext db)
        {
            this.db = db;
        }

        public Audit AddOneAudit(Audit audit)
        {
            throw new System.NotImplementedException();
        }

        public bool Exists(int auditId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Audit>> GetAllAudit()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Audit>> GetAllAuditBy(string UserId)
        {
            return await db.Audites.Select(o => new Audit()
            {
                AuditId = o.AuditId,
                DateTrace = o.DateTrace,
                DetailAction = o.DetailAction,
                TypeAction = o.TypeAction,
                UserId = o.UserId,
                IpSource = o.IpSource

            }).ToListAsync();
        }

        public Audit GetOneAudit(int auditId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateOneAudit(string UserId, Audit audit)
        {
            if (UserId != null && audit != null)
            {
                Audit oldAudit = db.Audites.Where(p => p.UserId == UserId).FirstOrDefault();
                if (oldAudit != null)
                {
                    db.Audites.Update(oldAudit);
                }

            }
        }
    }
}
