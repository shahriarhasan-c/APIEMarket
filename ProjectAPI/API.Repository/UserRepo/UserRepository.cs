using API.Model.DataConnection;
using API.Model.Models;
using API.Model.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Repository.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly ProjectContext _db;
        public UserRepository(ProjectContext db)
        {
            _db = db;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            List<User> response = await _db.Users.ToListAsync();
            return response;
        }

        public async Task<User> GetByIdAsync(Guid Id)
        {
            var response = await _db.Users.SingleOrDefaultAsync(x => x.Id == Id);
            return response;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _db.Users.Add(user);
            if (await _db.SaveChangesAsync() > 0)
            {
                return user;
            }
            return null;
        }

        public async Task<bool> GetByUserNameAsync(User user)
        {
            return await _db.Users.AnyAsync(x => x.Username == user.Username);

        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _db.Users.Update(user);
            if (await _db.SaveChangesAsync() > 0)
            {
                return user;
            }
            return null;

        }
    }
}
