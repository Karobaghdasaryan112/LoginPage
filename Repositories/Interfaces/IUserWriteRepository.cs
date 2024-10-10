using LoginAndRegistrationPage.Models;

namespace LoginAndRegistrationPage.Repositories.Interfaces
{
    public interface IUserWriteRepository : IUserRepository
    {
        Task AddUserAsync(User user);
    }
}
