using System.ComponentModel.DataAnnotations;
namespace LoginAndRegistrationPage.Models
{
    public class UserModel
    {
        [Required]
        public string ?UserName { get; set; }
        [Required]
        public string ?Password { get; set; }
    }
}
