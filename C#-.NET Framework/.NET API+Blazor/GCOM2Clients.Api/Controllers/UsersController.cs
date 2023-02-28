using Microsoft.AspNetCore.Mvc;
using BAL.Services;
using BAL.Models;
using Microsoft.AspNetCore.Authorization;

namespace GCOM2Users.Api.Controllers
{
    [ApiController]

    [Route("api/[controller]/[action]")]

    [Authorize]
    public class UsersController : ControllerBase
    {
        private UserBAL _BAL;
        public UsersController()
        {
            _BAL = new UserBAL();
        }

        [HttpGet]
        public IActionResult GetAllUsers(int page)
        {
            var utilizadores = _BAL.GetAllUsers(page);
            return Ok(utilizadores);

        }
        [HttpGet]
        public IActionResult GetAllActiveUsers(int page)
        {
            var utilizadores = _BAL.GetAllActiveUsers(page);
            return Ok(utilizadores);
        }

        [HttpGet("{id}")]
        public ActionResult <UtilizadorModel> GetUtilizadorById(int id)
        {
            return _BAL.GetById(id);
        }

        [HttpPost]
        public void PostUser(UtilizadorModel novoUtilizador)
        {
            _BAL.AddUser(novoUtilizador);
        }

        [HttpPut("{id}")]
        public void UpdateUser(UtilizadorModel utilizadorModel)
        {
            _BAL.UpdateUser(utilizadorModel);
        }
    }
}
