using System.Threading.Tasks;

namespace AAAA.Aplication.Interfaces
{
    public interface IAuthenticationService
    {
        // 验证在 SignInAsync 中颁发的证书，并返回一个 AuthenticateResult 对象，表示用户的身份。
        Task<AuthenticateResult> AuthenticateAsync();

        // 用户登录成功后颁发一个证书（加密的用户凭证），用来标识用户的身份。
        Task<string> SignInAsync();

        // 退出登录。
        Task SignOutAsync();

        // 用来获取Token。
        Task<string> GetTokenAsync(string tokenName);
    }
}
