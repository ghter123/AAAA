using AAAA.Aplication.ViewModels;

namespace AAAA.Aplication.Interfaces
{
    public interface IUserAppService
    {
        void SignUp(UserViewModel userViewModel);
        string SignIn(UserViewModel userViewModel);
        void SignOut();
    }
}
