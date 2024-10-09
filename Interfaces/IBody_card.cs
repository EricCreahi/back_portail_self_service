using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IBody_card
    {
        Body_card AddOneBody_card(Body_card body_Card);
        Task<IEnumerable<Body_card>> GetAllBody_card();

        bool Exists(int Id);
    }



}
