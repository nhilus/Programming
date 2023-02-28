using BAL.Models.Auth;
using BAL.Dtos.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using DAL.Entities;
using DAL.DataContext;
using BAL.Services;
using System.Collections;

namespace GCOM2Users.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private AuthenticationBAL _ABAL;
        public AuthController(AuthenticationBAL authenticationBAL)
        {
            _ABAL = authenticationBAL;
        }

        [HttpGet]
        public IEnumerable Get()
        {
            var userData = _ABAL.GetAll();
            return userData;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserLogin>> Register(UserAuthDto request)
        {
            var registo = await _ABAL.Register(request);
            
            return Ok(registo);
        }

        [HttpPost("login")]
        public string Login(UserAuthDto request)
        {
            var login = _ABAL.Login(request);
            return login;
        }
    }
}
    

