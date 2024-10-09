using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers.Dto.Requetes
{
    public class LoginReqDto
    {


        private string _login;
        private string _motDePasse;


        public LoginReqDto()
        {
            this._login = UserId;
            this._motDePasse = UserPassword;
        }


        public string UserId
        { 
            get { return _login; } 
            set { _login = value; }
        }
        public string UserPassword
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }

    }


}
