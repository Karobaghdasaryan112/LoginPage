using LoginAndRegistrationPage.Data;
using LoginAndRegistrationPage.Models;
using LoginAndRegistrationPage.Repositories.inplimentation;
using Microsoft.AspNetCore.Mvc;

namespace LoginAndRegistrationPage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SharedController : Controller
    {
        private readonly UserReadRepository _userReadRepository;
        private readonly AppDbContext _appDbContext;
        private UserModel _userModel;
        public SharedController(AppDbContext appDbContext, UserReadRepository userReadRepository)
        {
            _appDbContext = appDbContext;
            _userReadRepository = userReadRepository;
        }
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("Submit")]
        public async Task<IActionResult> Submit([FromForm] UserModel user)
        {
            if (await _userReadRepository.UserVerify(user))
            {
                var currentUser = await _userReadRepository.GetUserByUserNameAsync(user.UserName);

                if (currentUser == null)
                {
                    return View("Login", user);
                }
                return View("Account", currentUser);
            }

            ViewBag.MessageLogin = "Invalid Login";
            ViewBag.MessagePassword = "Invalid Password";
            return View("Login", user);
        }
    }
}