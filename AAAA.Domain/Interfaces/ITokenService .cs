using System.Collections.Generic;
using System.Security.Claims;

namespace AAAA.Domain.Interfaces
{
    public interface ITokenService
    {
        // 验证颁发的证书。
        public IEnumerable<Claim> Authenticate(string token);

        // 颁发JWT。
        string Create(IEnumerable<Claim> claims);

        // 刷新Token。
        string Refresh(string token);

        // 退出登录。
        void Deactivate(string token);
    }
}
