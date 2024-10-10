using LoginAndRegistrationPage.Data;
using LoginAndRegistrationPage.Models;
using LoginAndRegistrationPage.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace LoginAndRegistrationPage.Repositories.inplimentation
{
    public class UserReadRepository : IUserReadRepository
    {
        private AppDbContext ?_appDbContext;
        public UserReadRepository(AppDbContext? appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _appDbContext?.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            var CurrentUser = await _appDbContext?.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            return CurrentUser;
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            var CurrentUser = await _appDbContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
            return CurrentUser;
        }

        public Task SaveChangesAsync()
        {
            return _appDbContext?.SaveChangesAsync();
        }

        public async Task<bool> UserVerify(UserModel user)
        {
            return await _appDbContext.Users.FirstOrDefaultAsync(x => x.UserName == user.UserName && x.Password == user.Password) != null;
        }
    }
}
