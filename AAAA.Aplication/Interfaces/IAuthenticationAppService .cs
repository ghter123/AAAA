using AAAA.Aplication.ViewModels;

namespace AAAA.Aplication.Interfaces
{
    public interface IAuthenticationAppService
    {
        // 验证在SignInAsync中颁发的证书，并返回一个claim集合。
        AuthenticateResult Authenticate(string token);

        // 用户登录成功后颁发一个证书（加密的用户凭证），用来标识用户的身份。
        SignInResult SignIn(string account,string password);

        // 退出登录。
        void SignOut(string token);
    }
}
