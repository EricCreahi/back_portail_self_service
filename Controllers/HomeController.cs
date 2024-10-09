using WebApi.Controllers.Dto.Requetes;
using WebApi.Helpers;
using WebApi.Interfaces;
using WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class HomeController : ControllerBase
    {
        private readonly IUtilisateur repo;
      

        public HomeController(IUtilisateur repo)
        {
            this.repo = repo;      
        }


        [HttpGet("one/{matricule}")]
        public IActionResult InfosUser(string matricule)
        {
            var utilisateur = repo.getOneutilisateurByMatricule(matricule);

            var response = new Reponse<Utilisateur>()
            {
                NbreData= 1,
                OneData = utilisateur != null ? utilisateur : null

            };
            return Ok(response);
        }


        [HttpPost("Login")]      
        public IActionResult Login(LoginReqDto loginReq)
        {
            var emp = new Utilisateur();

            if (loginReq.UserId != null && loginReq.UserPassword != null)
            {
                emp = repo.Authentification(loginReq.UserId.Trim(), loginReq.UserPassword.Trim());
            }


            if (emp == null)
            {
                RedirectToAction("Index");
            }


            var reponse = new Reponse<Utilisateur>()
            {
                OneData = emp,
                Connexion = repo.PremierConnexion

            };


            return Ok(reponse);
        }


        [HttpGet("one/getOneutilisateur/{loginUser}")]
        public IActionResult getOneutilisateur(string loginUser)
        {
            var emp = new Utilisateur();

            if (loginUser != null)
            {

                emp = repo.getOneutilisateur(loginUser);

            }
            else
            {

                emp = null;
            }




            var reponse = new Reponse<Utilisateur>()
            {
                OneData = emp
                

            };

            return Ok(reponse);

        }


    }
}
