using LoginAndRegistrationPage.Data;
using LoginAndRegistrationPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LoginAndRegistrationPage.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly AppDbContext ?_appDbContext;
        public UserController(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        [HttpGet("Login/{UserName}")]
        public async Task<IActionResult> UserLogin(UserModel userModel)
        {
            return null;
        }
    }
}
        
