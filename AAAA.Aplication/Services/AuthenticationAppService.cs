using AAAA.Aplication.Interfaces;
using AAAA.Domain.Interfaces;
using AAAA.Aplication.ViewModels;

namespace AAAA.Aplication.Services
{
    public class AuthenticationAppService : IAuthenticationAppService
    {
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepository;

        public AuthenticationAppService(ITokenService tokenService, IUserRepository userRepository)
        {
            _tokenService = tokenService;
            _userRepository = userRepository;
        }

        public AuthenticateResult Authenticate(string token)
        {
            var claims = _tokenService.Authenticate(token);
            if (claims != null)
            {
                return new AuthenticateResult
                {
                    Claims = claims,
                    Suceessed = true
                };
            }

            var newToken = _tokenService.Refresh(token);
            if (newToken == null) return new AuthenticateResult { Suceessed = false };
            return new AuthenticateResult
            {
                Claims = _tokenService.Authenticate(newToken),
                Suceessed = true,
                NewToken = newToken
            };
        }

        public SignInResult SignIn(string account, string password)
        {
            var user = _userRepository.GetByAccount(account, password);

            if (user == null)
            {
                return new SignInResult
                {
                    Suceessed = false
                };
            }

            return new SignInResult
            {
                Suceessed = true,
                Token = _tokenService.Create(user.GetClaims())
            };
        }

        public void SignOut(string token)
        {
            throw new System.NotImplementedException();
        }
    }
}
