using AAAA.Domain.Core.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace AAAA.Domain
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public IEnumerable<Claim> GetClaims()
        {
            return new List<Claim>
            {
               new Claim(ClaimTypes.Role,Role)
            };
        }
    }
}
