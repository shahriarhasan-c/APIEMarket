using API.Repository.UserRepo;
using Microsoft.AspNetCore.Mvc;
using API.Model.Models;
using API.Model.ViewModel;
using API.Service;
using Microsoft.EntityFrameworkCore;

namespace ProjectAPI.Controllers.UserLogin
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly UserLoginService _userService;
        public UserLoginController(IUserRepository userRepository, UserLoginService userService)
        {
            _userRepository = userRepository;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersAsync()
        {
            var response = await _userRepository.GetUsersAsync();
            if (response.Count == 0)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var response = await _userRepository.GetByIdAsync(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(User user)
        {
            try
            {
                var CreatedUser = await _userService.UserIsExist(user);
                return Ok(CreatedUser);
            }
            catch (DbUpdateException)
            {
                return Conflict();
            }

        }

    }
}
