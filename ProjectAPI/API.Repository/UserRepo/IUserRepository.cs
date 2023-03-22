using API.Model.Models;
using API.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Repository.UserRepo
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetByIdAsync(Guid Id);
        Task<User> CreateUserAsync(User user);
        Task<bool> GetByUserNameAsync(User user);
        Task<User>UpdateUserAsync(User user);
        Task<bool> DeleteAsync(User user);
    }
}
