using System.Threading.Tasks;
using helloweb.Data;
using helloweb.Services;
using Microsoft.AspNetCore.Mvc;

namespace aspweb.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            // TODO: Your code here
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUser user)
        {
           await  _userService.CreateUser(user);
            
            return View();
        }


        public IActionResult Login()
        {
            // TODO: Your code here
            return View();
        }
        
        
    }
}