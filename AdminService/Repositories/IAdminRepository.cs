using AdminService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminService.Repositories
{
    public interface IAdminRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(int id);
        Task AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
    }
}
