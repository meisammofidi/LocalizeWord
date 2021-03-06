using System.Threading.Tasks;
using LocalizeWord.API.Models;

namespace LocalizeWord.API.Repository
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
         Task<bool> emailExists(string email);
    }
}