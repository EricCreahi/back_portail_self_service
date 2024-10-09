using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeController : Controller
    {
        private readonly IEmploye repo;

        public EmployeController(IEmploye repo)
        {
            this.repo = repo;
        }


        [HttpGet("one/{matricule}")]
        public IActionResult GetOneEmploye(string matricule)
        {

            Employe employe = null;
            if (matricule != "" || matricule != null || matricule != string.Empty) employe = repo.GetOneEmploye(matricule); else employe = null;

            var response = new Reponse<Employe>()
            {
                NbreData = 1,
                OneData = employe != null ? employe : null

            };
            return Ok(response);



            }









    }
}
