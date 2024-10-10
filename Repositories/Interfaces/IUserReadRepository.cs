using LoginAndRegistrationPage.Models;

namespace LoginAndRegistrationPage.Repositories.Interfaces
{
    public interface IUserReadRepository : IUserRepository
    {
        Task<User> GetUserByIdAsync(int userId);
        Task<User> GetUserByUserNameAsync(string userName);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<bool> UserVerify(UserModel user);
    }
}
