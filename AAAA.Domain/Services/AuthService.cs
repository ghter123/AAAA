using AAAA.Domain.Interfaces;

namespace AAAA.Aplication.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string CreateToken(string account, string password)
        {
            var user = _userRepository.GetByAccount(account);
            return "This a valid token";
        }

        public void DeactivateToken(string token)
        {
            throw new System.NotImplementedException();
        }

        public bool Passed(string account, string password)
        {
            var user = _userRepository.GetByAccount(account);
            return user.Password == user.Password;
        }

        public string RefreshToken(string token)
        {
            throw new System.NotImplementedException();
        }
    }
}
