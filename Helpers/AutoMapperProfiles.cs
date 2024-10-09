using AutoMapper;
using WebApi.Controllers.Dto.Requetes;
using WebApi.Models;

namespace WebApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {

            #region ------ // (domaine to ressource) // -----
  

            #endregion


            #region ----- // ( ressource to domaine ) // -----
            CreateMap<LoginReqDto, Utilisateur>();
        
            #endregion


        }

    }
}
