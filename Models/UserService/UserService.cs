using LoginAndRegistrationPage.Data;

namespace LoginAndRegistrationPage.Models.UserService
{
    public class UserService
    {
        private AppDbContext _appDbContext {  get; set; }
        private UserModel ?_userModel { get; set; }
        public UserService(UserModel user)
        { 
            _userModel = user;
        }
        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public bool AutorizationCondition()
        {
            var CurrentUser = _appDbContext.Users.FirstOrDefault(User => (User.UserName == _userModel.UserName && User.Password == _userModel.Password));
            if (CurrentUser == null)
            {
                return false;
            }
            return true;
        }
        public void UserAddCondition(UserModel usermodel)
        {
        }
    }
}
