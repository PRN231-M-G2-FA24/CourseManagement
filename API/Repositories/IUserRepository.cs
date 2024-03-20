using API.Models;

namespace API.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string email);
    }
}
