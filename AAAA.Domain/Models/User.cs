using AAAA.Domain.Core.Models;

namespace AAAA.Domain
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
