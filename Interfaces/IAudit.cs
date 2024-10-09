using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IAudit
    {
        Audit AddOneAudit(Audit audit);
        Task<IEnumerable<Audit>> GetAllAudit();
        Task<IEnumerable<Audit>> GetAllAuditBy(string UserId);
        Audit GetOneAudit(int auditId);
        void UpdateOneAudit(string UserId, Audit audit);

        bool Exists(int auditId);


    }
}
