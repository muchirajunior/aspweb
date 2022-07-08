using System.Threading.Tasks;
using helloweb.Data;
using Microsoft.AspNetCore.Identity;

namespace helloweb.Services{
    public interface IUserService{
        Task<IdentityResult> CreateUser(RegisterUser user);
    }
}