using API.Repository.AdminRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers.AdminProfile
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminProfileController : ControllerBase
    {
        private readonly IAdminRepository _adminRepository;
        public AdminProfileController(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        [HttpGet]
        public Task<IActionResult> Get()
        { 

        }
        
    }
}
