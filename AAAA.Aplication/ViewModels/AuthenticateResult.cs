using System.Collections.Generic;
using System.Security.Claims;

namespace AAAA.Aplication.ViewModels
{
    public class AuthenticateResult : Result
    {
        public IEnumerable<Claim> Claims { get; set; }
        public string NewToken { get; set; }
    }
}
