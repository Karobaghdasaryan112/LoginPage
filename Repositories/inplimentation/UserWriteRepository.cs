using LoginAndRegistrationPage.Data;
using LoginAndRegistrationPage.Models;
using LoginAndRegistrationPage.Repositories.Interfaces;

namespace LoginAndRegistrationPage.Repositories.inplimentation
{
    public class UserWriteRepository : IUserWriteRepository
    {

        private AppDbContext? _appDbContext;
        public UserWriteRepository(AppDbContext? appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task AddUserAsync(User user)
        {
            if(user == null)
                throw new ArgumentNullException(nameof(user));
            return null;
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
