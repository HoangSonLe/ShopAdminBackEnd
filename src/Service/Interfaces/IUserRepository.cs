using Application.Repository;
using Infrastructure.Entitites;

namespace Application.Interfaces
{
    public interface IUserRepository : IRepositoryGenerator<User>
    {
        Task<User> GetUserWithRolesByUserNameAsync(string userName);
    }
}
