using System.Threading.Tasks;
using helloweb.Data;
using Microsoft.AspNetCore.Identity;

namespace helloweb.Services{
    public class UserService : IUserService{
        private readonly UserManager<IdentityUser> _userManager;

        public UserService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> CreateUser(RegisterUser registerUser){
            var user= new IdentityUser{
                UserName=registerUser.Username,
                Email=registerUser.Username
            };

            var result= await _userManager.CreateAsync(user,registerUser.Password);
            return result;
        }
        
    }
}