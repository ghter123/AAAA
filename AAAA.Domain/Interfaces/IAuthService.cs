namespace AAAA.Domain.Interfaces
{
    public interface IAuthService
    {
        bool Passed(string account,string password);
        string CreateToken(string account, string password);
        void DeactivateToken(string token);
        string RefreshToken(string token);
    }
}
