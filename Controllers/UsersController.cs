using System.Linq;
using Accountant.Api.Filters;
using Accountant.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Accountant.Api.Controllers
{
    [Route("[controller]")]
    [ExceptionHandler]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get() => Json(_userRepository.GetAll().Select(x => x.Name));

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            throw new System.Exception("Oops....");
            var user = _userRepository.GetUser(name);
            if(user == null)
            {
                return NotFound();
            }
            return Json(user);

        }
    }
}