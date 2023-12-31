using DocsHub.Core.Common;
using DocsHub.Core.Models;

namespace DocsHub.Core.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> AddAsync(User user);
        Task<User?> GetByEmailAsync(string email);
         Task<PagedList<User>> GetAllUsersAsync(int pageIndex, int pageSize);
         Task<User?> GetUserByIdAsync(Guid id);
        Task DeleteUserByIdAsync(User user);
        Task<User> UpdateUserAsync(User user);
    }
}