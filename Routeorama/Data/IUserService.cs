using System.Threading.Tasks;
using Routeorama.Models;

namespace Routeorama.Data
{
    public interface IUserService {
        Task<User> ValidateLogin(string username, string password);
        void Logout();
        Task<bool> Register(User user);
    }
}