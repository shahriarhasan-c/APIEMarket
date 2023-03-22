using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Model.ViewModel
{
    public class UserVM
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
    }
}
