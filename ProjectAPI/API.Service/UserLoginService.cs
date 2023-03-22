using API.Model.Models;
using API.Repository.UserRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Service
{
    public class UserLoginService
    {
        private readonly IUserRepository _userRepository;
        public UserLoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> UserIsExist(User user)
        {
            var UserExist = await _userRepository.GetByUserNameAsync(user);
            if (UserExist)
            {
                throw new DbUpdateException("User Already Exist!");
            }
            await _userRepository.CreateUserAsync(user);
            return user;
        }

    }
}
