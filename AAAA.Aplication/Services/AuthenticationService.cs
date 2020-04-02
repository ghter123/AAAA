using AAAA.Aplication.Interfaces;
using System.Threading.Tasks;

namespace AAAA.Aplication.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<AuthenticateResult> AuthenticateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetTokenAsync(string tokenName)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> SignInAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task SignOutAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
