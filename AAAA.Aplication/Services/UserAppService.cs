using AAAA.Aplication.Interfaces;
using AAAA.Aplication.ViewModels;
using AAAA.Domain.Interfaces;

namespace AAAA.Aplication.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IAuthService _authService;

        public UserAppService(IAuthService authService)
        {
            _authService = authService;
        }
        public string SignIn(UserViewModel userViewModel)
        {
            return _authService.CreateToken(userViewModel.Account, userViewModel.Password);
        }

        public void SignOut()
        {
            throw new System.NotImplementedException();
        }

        public void SignUp(UserViewModel userViewModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
