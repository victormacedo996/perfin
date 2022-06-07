using GestaoFinanceira.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestaoFinanceira.Service.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersControllers : ControllerBase
    {
        private readonly IUserApplication _userApplication;

        public UsersControllers(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userApplication.GetAll();

            return Ok(users);
        }
    }
}