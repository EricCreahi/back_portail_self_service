using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Body_cardController : ControllerBase
    {
        private readonly IBody_card repo;

        public Body_cardController(IBody_card repo)
        {
            this.repo = repo;
        }




        [HttpGet("all")]
        public async Task<ActionResult<IEnumerator<Body_card>>> listeBodyCard()
        {
            var async_body_card = await repo.GetAllBody_card();

            var response = new Reponse<Body_card>()
            {
                Data = async_body_card != null ? async_body_card : null,
                NbreData = async_body_card.Count()
            };

            return Ok(response);
        }



    }



}
